﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SMH_UI_Test
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.StartApp();
            }

            if (platform == Platform.iOS)
            {
                return ConfigureApp.iOS.StartApp();
            }

            throw new Exception("Unknown platform");
        }
    }
}