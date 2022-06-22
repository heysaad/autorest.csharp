﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.MgmtTest.Models;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure.Core;

namespace AutoRest.CSharp.MgmtTest.Extensions
{
    internal static class CodeWriterExtensions
    {
        /// <summary>
        /// Write an ExampleValue, using the given type as a hint.
        /// If the type is not provided, a type will be created from TypeFactory instead
        /// In a case that a property's type is replaced, we will have to provide the actual type otherwise the type from TypeFactory will always be the one that is replaced.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="exampleValue"></param>
        /// <param name="type"></param>
        /// <param name="includeCollectionInitialization"></param>
        /// <returns></returns>
        public static CodeWriter AppendExampleValue(this CodeWriter writer, ExampleValue exampleValue, CSharpType? type = null, bool includeCollectionInitialization = true)
        {
            // get the type of this schema in the type factory if the type is not specified
            // get the type from TypeFactory cannot get the replaced types, therefore we need to put an argument in the signature as a hint in case this might happen in the replaced type case
            type ??= MgmtContext.Context.TypeFactory.CreateType(exampleValue.Schema, false);

            return type.IsFrameworkType ?
                writer.AppendFrameworkTypeValue(type, exampleValue, includeCollectionInitialization) :
                writer.AppendTypeProviderValue(type, exampleValue);
        }

        public static CodeWriter AppendExampleParameterValue(this CodeWriter writer, Parameter parameter, ExampleParameterValue exampleValue)
        {
            // for optional parameter, we write the parameter name here
            if (parameter.DefaultValue != null)
                writer.Append($"{parameter.Name}: ");
            if (exampleValue.Value != null)
                writer.AppendExampleValue(exampleValue.Value);
            else if (exampleValue.RawValue != null)
                writer.Append(exampleValue.RawValue);
            else
                throw new InvalidOperationException($"No value for parameter {exampleValue.Parameter.Name} assigned");
            return writer;
        }

        private static CodeWriter AppendFrameworkTypeValue(this CodeWriter writer, CSharpType type, ExampleValue exampleValue, bool includeCollectionInitialization = true)
        {
            if (TypeFactory.IsList(type))
                return writer.AppendListValue(type, exampleValue, includeCollectionInitialization);

            if (TypeFactory.IsDictionary(type))
                return writer.AppendDictionaryValue(type, exampleValue, includeCollectionInitialization);

            if (type.FrameworkType == typeof(BinaryData))
                return writer.AppendBinaryData(exampleValue);

            return writer.AppendSimpleFrameworkType(type.FrameworkType, exampleValue);
        }

        private static CodeWriter AppendListValue(this CodeWriter writer, CSharpType type, ExampleValue exampleValue, bool includeInitialization = true)
        {
            // since this is a list, we take the first generic argument (and it should always has this first argument)
            var elementType = type.Arguments.First();
            var initialization = includeInitialization ? (FormattableString)$"new {elementType}[]" : (FormattableString)$"";
            using (writer.Scope(initialization, newLine: false))
            {
                foreach (var itemValue in exampleValue.Elements)
                {
                    // TODO -- bad formatting will happen in collection initializer because roslyn formatter ignores things in these places: https://github.com/dotnet/roslyn/issues/8269
                    writer.AppendExampleValue(itemValue);
                    if (type.IsFrameworkType)
                        writer.AppendRaw(",");
                    else
                        writer.LineRaw(",");
                }
                writer.RemoveTrailingComma();
                writer.Line();
            }
            return writer;
        }

        private static CodeWriter AppendDictionaryValue(this CodeWriter writer, CSharpType type, ExampleValue exampleValue, bool includeInitialization = true)
        {
            // since this is a dictionary, we take the first generic argument as the key type which is always string
            // the second as the value type
            var valueType = type.Arguments[1];
            var initialization = includeInitialization ? (FormattableString)$"new {type}()" : (FormattableString)$"";
            using (writer.Scope(initialization, newLine: false))
            {
                foreach ((var key, var value) in (Dictionary<string, ExampleValue>)exampleValue.Properties)
                {
                    // write key
                    writer.Append($"[{key:L}] = ");
                    writer.AppendExampleValue(value);
                    writer.LineRaw(", ");
                }
            }
            return writer;
        }

        private static CodeWriter AppendBinaryData(this CodeWriter writer, ExampleValue exampleValue)
        {
            // TODO
            return writer.AppendRaw("default");
        }

        private static CodeWriter AppendSimpleFrameworkType(this CodeWriter writer, Type type, ExampleValue exampleValue) => exampleValue.RawValue switch
        {
            string str => writer.AppendStringValue(type, str), // we need this function to convert the string to real type. There might be a bug that some literal types (like bool and int) are deserialized to string
            null => throw new InvalidOperationException($"Example value is null for framework type {type}"),
            _ => writer.AppendRaw(exampleValue.RawValue.ToString()!)
        };

        private static CodeWriter AppendStringValue(this CodeWriter writer, Type type, string value) => type switch
        {
            _ when IsPrimitiveType(type) => writer.AppendRaw(value),
            _ when IsNewInstanceInitializedStringLikeType(type) => writer.Append($"new {type}({value:L})"),
            _ when IsParsableInitializedStringLikeType(type) => writer.Append($"{type}.Parse({value:L})"),
            _ => writer.Append($"{value:L}"),
        };

        private static bool IsStringLikeType(CSharpType type) => type.IsFrameworkType && IsStringLikeType(type.FrameworkType);

        private static bool IsStringLikeType(Type type)
            => IsNewInstanceInitializedStringLikeType(type) || IsParsableInitializedStringLikeType(type);

        private static bool IsPrimitiveType(Type type)
            => IsType<bool>(type) || IsType<int>(type) || IsType<long>(type) || IsType<double>(type) || IsType<decimal>(type);

        private static bool IsNewInstanceInitializedStringLikeType(Type type)
            => IsType<ResourceIdentifier>(type) || IsType<ResourceType>(type) || IsType<Uri>(type) || IsType<AzureLocation>(type);

        private static bool IsParsableInitializedStringLikeType(Type type)
            => IsType<DateTimeOffset>(type) || IsType<Guid>(type) || IsType<TimeSpan>(type);

        private static bool IsType<T>(Type type) => type == typeof(T) || (typeof(T).IsValueType && type == typeof(T?));

        private static CodeWriter AppendTypeProviderValue(this CodeWriter writer, CSharpType type, ExampleValue exampleValue)
        {
            switch (type.Implementation)
            {
                case ObjectType objectType:
                    return writer.AppendObjectTypeValue(objectType, (Dictionary<string, ExampleValue>)exampleValue.Properties);
                case EnumType enumType:
                    return writer.AppendEnumTypeValue(enumType, (string)exampleValue.RawValue!);
            }
            return writer.AppendRaw("default");
        }

        //private static string? GetPropertySerializedName(ObjectType objectType, ObjectTypeProperty property)
        //{
        //    if (objectType is not SystemObjectType systemObjectType)
        //        return property.SchemaProperty?.SerializedName;

        //    return SystemObjectTypeHandler.GetPropertySerializedName(systemObjectType, property.Declaration.Name);
        //}

        private static CodeWriter AppendObjectTypeValue(this CodeWriter writer, ObjectType objectType, Dictionary<string, ExampleValue> valueDict)
        {
            // get all the properties on this type, including the properties from its base type
            var properties = new HashSet<ObjectTypeProperty>(objectType.EnumerateHierarchy().SelectMany(objectType => objectType.Properties));
            var constructor = objectType.InitializationConstructor;
            writer.UseNamespace(objectType.Type.Namespace);
            writer.Append($"new {objectType.Type.Name}(");
            // build a map from parameter name to property
            var propertyDict = properties.ToDictionary(
                property => property.Declaration.Name.ToVariableName(), property => property);
            // find the corresponding properties in the parameters
            foreach (var parameter in constructor.Signature.Parameters)
            {
                // try every property, convert them to variable name and see if there are some of them matching
                var property = propertyDict[parameter.Name];
                ExampleValue? exampleValue;
                if (!valueDict.TryGetValue(property.SchemaProperty!.SerializedName, out exampleValue))
                {
                    // we could only stand the case that the missing property here is a collection, in this case, we pass an empty collection
                    if (TypeFactory.IsCollectionType(property.Declaration.Type))
                    {
                        exampleValue = new ExampleValue()
                        {
                            Schema = property.SchemaProperty!.Schema,
                        };
                    }
                    else if (IsStringLikeType(property.Declaration.Type))
                    {
                        // this is a patch that some parameter is not marked as required, but in our generated code, it inherits from ResourceData, in which location is in the constructor and our code will recognize it as required
                        exampleValue = new ExampleValue()
                        {
                            Schema = new StringSchema()
                            {
                                Type = AllSchemaTypes.String
                            },
                            RawValue = "placeholder",
                        };
                    }
                    else
                        throw new InvalidOperationException($"Example value for required property {property.SchemaProperty!.SerializedName} in class {objectType.Type.Name} is not found");
                }
                properties.Remove(property);
                writer.AppendExampleValue(exampleValue, type: property.Declaration.Type).AppendRaw(",");
            }
            writer.RemoveTrailingComma();
            writer.AppendRaw(")");
            var propertiesToWrite = GetPropertiesToWrite(objectType, properties, valueDict);
            if (propertiesToWrite.Count > 0) // only write the property initializers when there are properties to write
            {
                using (writer.Scope($"", newLine: false))
                {
                    foreach ((var propertyName, (var propertyType, var exampleValue)) in propertiesToWrite)
                    {
                        writer.Append($"{propertyName} = ");
                        // we need to pass in the current type of this property to make sure its initialization is correct
                        writer.AppendExampleValue(exampleValue, type: propertyType, includeCollectionInitialization: false);
                        writer.LineRaw(",");
                    }
                }
            }
            return writer;
        }

        private static Dictionary<string, (CSharpType PropertyType, ExampleValue ExampleValue)> GetPropertiesToWrite(ObjectType objectType, IEnumerable<ObjectTypeProperty> properties, Dictionary<string, ExampleValue> valueDict)
        {
            var propertiesToWrite = new Dictionary<string, (CSharpType PropertyType, ExampleValue ExampleValue)>();
            foreach (var property in properties)
            {
                var schemaProperty = property.SchemaProperty;
                if (!IsPropertyAssignable(property) || schemaProperty == null)
                    continue; // now we explicitly ignore all the AdditionalProperties

                if (!valueDict.TryGetValue(schemaProperty.SerializedName, out var exampleValue))
                    continue; // skip the property that does not have a value

                var hierarchyStack = new Stack<ObjectTypeProperty>();
                hierarchyStack.Push(property);
                BuildHeirarchy(property, hierarchyStack);
                // check if this property is safe-flattened
                if (hierarchyStack.Count > 1)
                {
                    // get example value out of the dict
                    exampleValue = UnwrapExampleValueFromSinglePropertySchema(exampleValue, hierarchyStack);
                    if (exampleValue == null)
                        continue;
                    // We could build a stack hierarchy here as well, and when we pop that, we only take the last result
                    // in the meantime we pop the example value once at a time, so that in this way we could just assign the innerest property with the innerest example values of the objects
                    var innerProperty = hierarchyStack.Pop();
                    var immediateParentProperty = hierarchyStack.Pop();
                    var myPropertyName = innerProperty.GetCombinedPropertyName(immediateParentProperty);
                    // we need to know if this property has a setter, code copied from ModelWriter.WriteProperties
                    if (!property.IsReadOnly && innerProperty.IsReadOnly)
                    {
                        if (ModelWriter.HasCtorWithSingleParam(property, innerProperty))
                        {
                            // this branch has a setter
                            propertiesToWrite.Add(myPropertyName, (innerProperty.Declaration.Type, exampleValue));
                        }
                    }
                    else if (!property.IsReadOnly && !innerProperty.IsReadOnly)
                    {
                        // this branch always has a setter
                        propertiesToWrite.Add(myPropertyName, (innerProperty.Declaration.Type, exampleValue));
                    }
                }
                else
                {
                    propertiesToWrite.Add(property.Declaration.Name, (property.Declaration.Type, exampleValue));
                }
            }

            return propertiesToWrite;
        }

        private static ExampleValue? UnwrapExampleValueFromSinglePropertySchema(ExampleValue exampleValue, Stack<ObjectTypeProperty> hierarchyStack)
        {
            // reverse the stack because it is a stack, iterating it will start from the innerest property
            // skip the first because this stack include the property we are handling here right now
            foreach (var property in hierarchyStack.Reverse().Skip(1))
            {
                var schemaProperty = property.SchemaProperty;
                if (schemaProperty == null || !exampleValue.Properties.TryGetValue(schemaProperty.SerializedName, out var inner))
                    return null;
                // get the value of this layer
                exampleValue = inner;
            }
            return exampleValue;
        }

        private static void BuildHeirarchy(ObjectTypeProperty property, Stack<ObjectTypeProperty> heirarchyStack)
        {
            if (property.IsSinglePropertyObject(out var childProp))
            {
                heirarchyStack.Push(childProp);
                BuildHeirarchy(childProp, heirarchyStack);
            }
        }

        private static bool IsPropertyAssignable(ObjectTypeProperty property)
            => TypeFactory.IsReadWriteDictionary(property.Declaration.Type) || TypeFactory.IsReadWriteList(property.Declaration.Type) || !property.IsReadOnly;

        private static CodeWriter AppendEnumTypeValue(this CodeWriter writer, EnumType enumType, string value)
        {
            // find value in one of the choices
            var choice = enumType.Values.FirstOrDefault(c => value.Equals(c.Value.Value));
            writer.UseNamespace(enumType.Type.Namespace);
            if (choice != null)
                return writer.Append($"{enumType.Type.Name}.{choice.Declaration.Name}");
            // if we did not find a match, check if this is a SealedChoice, if so, we throw exceptions
            if (!enumType.IsExtendable)
                throw new InvalidOperationException($"Enum value `{value}` in example does not find in type {enumType.Type.Name}");
            return writer.Append($"new {enumType.Type.Name}({value:L})");
        }
    }
}
