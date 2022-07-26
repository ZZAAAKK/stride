// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;
using System.Collections.Generic;

namespace Stride.Core.Assets
{
    internal sealed class SupportedLanguage
    {
        public string Name { get; private set; }
        public string Extension { get; private set; }

        public SupportedLanguage(string name, string extension) 
        {
            Name = name;
            Extension = extension;
        }

        public static List<SupportedLanguage> SupportedLanguages
        {
            get
            => new List<SupportedLanguage>()
            {
                new("C#", ".csproj"),
                new("F#", ".fsproj")
            };
        }
    }
}
