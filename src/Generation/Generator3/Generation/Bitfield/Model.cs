﻿using System.Collections.Generic;
using System.Linq;
using Generator3.Model.Public;

namespace Generator3.Generation.Bitfield
{
    public class Model
    {
        private readonly GirModel.Bitfield _bitfield;

        public string Name => _bitfield.Name;
        public string NamespaceName => _bitfield.Namespace.Name;
        public IEnumerable<Member> Members { get; }

        public Model(GirModel.Bitfield bitfield)
        {
            _bitfield = bitfield;

            Members = bitfield.Members
                .Select(member => new Member(member))
                .ToList();
        }
    }
}
