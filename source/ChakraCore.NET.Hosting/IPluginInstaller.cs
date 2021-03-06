﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChakraCore.NET.Hosting
{
    public interface IPluginInstaller:ISDKProvider
    {
        void Install(JSValue target);
        string Name { get; }
    }
}
