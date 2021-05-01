﻿using System.Collections.Generic;
using Repository.Analysis;

namespace Repository.Model
{
    public class SingleParameter : Element, Parameter
    {
        public SymbolReference SymbolReference { get; }
        public Direction Direction { get; }
        public Transfer Transfer { get; }
        public bool Nullable { get; }
        public bool CallerAllocates { get; }
        public int? ClosureIndex { get; }
        public int? DestroyIndex { get; }
        public Scope CallbackScope { get; }
        public TypeInformation TypeInformation { get; }

        public SingleParameter(ElementName elementName, SymbolName symbolName, SymbolReference symbolReference, Direction direction, Transfer transfer, bool nullable, bool callerAllocates, int? closureIndex, int? destroyIndex, Scope scope, TypeInformation typeInformation) : base(elementName, symbolName)
        {
            SymbolReference = symbolReference;
            Direction = direction;
            Transfer = transfer;
            Nullable = nullable;
            CallerAllocates = callerAllocates;
            ClosureIndex = closureIndex;
            DestroyIndex = destroyIndex;
            CallbackScope = scope;
            TypeInformation = typeInformation;
        }

        public override IEnumerable<SymbolReference> GetSymbolReferences()
        {
            yield return SymbolReference;
        }

        public override bool GetIsResolved()
            => SymbolReference.GetIsResolved();
    }
}