﻿using Newtonsoft.Json.Linq;
using System.Linq;

namespace Mystique.Core.DomainModel
{
    public class DependanceItem
    {
        public DependanceItem(string packageName, string version, string assemblyVersion, string dllPath)
        {
            PackageName = packageName;

            if (!string.IsNullOrEmpty(assemblyVersion))
            {
                Version = assemblyVersion;
            }
            else
            {
                Version = version;
            }

            DLLPath = dllPath;
        }

        public string PackageName { get; private set; }

        public string Version { get; private set; }

        public string DLLPath { get; private set; }

        public string FileName
        {
            get
            {
                return DLLPath.Split('/').Last();
            }
        }
    }
}
