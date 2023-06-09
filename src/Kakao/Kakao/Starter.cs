﻿using Kakao.Settings;
using System;

namespace Kakao
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            new App()
                .AddInversionModule<ViewModules>()
                .AddInversionModule<DirectModules>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
