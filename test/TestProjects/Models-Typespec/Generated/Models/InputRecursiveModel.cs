// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ModelsInCadl.Models
{
    /// <summary> Input model that has property of its own type. </summary>
    public partial class InputRecursiveModel
    {
        /// <summary> Initializes a new instance of InputRecursiveModel. </summary>
        /// <param name="message"> Message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public InputRecursiveModel(string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Message = message;
        }

        /// <summary> Initializes a new instance of InputRecursiveModel. </summary>
        /// <param name="message"> Message. </param>
        /// <param name="inner"> Required Record. </param>
        internal InputRecursiveModel(string message, InputRecursiveModel inner)
        {
            Message = message;
            Inner = inner;
        }

        /// <summary> Message. </summary>
        public string Message { get; }
        /// <summary> Required Record. </summary>
        public InputRecursiveModel Inner { get; set; }
    }
}