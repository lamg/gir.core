﻿using System.Collections.Generic;

#nullable enable

namespace Repository.Model
{
    public class Callback : BasicType
    {
        public ReturnValue ReturnValue { get; }
        public IEnumerable<Argument> Arguments { get; }

        public Callback(Namespace @namespace, string nativeName, string managedName, ReturnValue returnValue, IEnumerable<Argument> arguments) : base(@namespace, nativeName, managedName)
        {
            ReturnValue = returnValue;
            Arguments = arguments;
        }
    }
}
