﻿namespace Bloxxer.AppData
{
    internal interface IAppData
    {
        string ProductName { get; }

        string BinaryType { get; }

        string RegistryName { get; }

        string ExecutableName { get; }

        string Directory { get; }

        string OldDirectory { get; }

        string LockFilePath { get; }

        string ExecutablePath { get; }

        AppState State { get; }

        IReadOnlyDictionary<string, string> PackageDirectoryMap { get; set; }
    }
}