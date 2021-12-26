﻿using Generator3.Renderer.Public;

namespace Generator3.Generation.Class.Standard
{
    public class PublicSignalsTemplate : Template<PublicSignalsModel>
    {
        public string Render(PublicSignalsModel model)
        {
            return $@"
using System;
using GObject;
using System.Runtime.InteropServices;

#nullable enable

namespace { model.NamespaceName }
{{
    // AUTOGENERATED FILE - DO NOT MODIFY

    public partial class { model.Name }
    {{
        {model.RenderObjectIndexer()}
        {model.Signals.Render()}
    }}
}}";
        }
    }
}