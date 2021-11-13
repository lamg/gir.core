﻿using Generator3.Renderer.Native;

namespace Generator3.Generation.Record
{
    public class NativeMethodsTemplate : Template<NativeMethodsModel>
    {
        public string Render(NativeMethodsModel model)
        {
            return $@"
using System;
using System.Runtime.InteropServices;

#nullable enable

namespace { model.NamespaceName }
{{
    // AUTOGENERATED FILE - DO NOT MODIFY

    public partial class { model.Name }
    {{
        public partial class Methods
        {{
            {model.TypeFunction.Render()}
            {model.Functions.Render()}
            {model.Methods.Render()}
            {model.Constructors.Render()}
        }}
    }}
}}";
        }
    }
}
