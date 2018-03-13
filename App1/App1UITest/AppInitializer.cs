using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace App1UITest2
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {

                return ConfigureApp
                    .Android
                    .InstalledApp("com.companyname.App1")
                    .StartApp();

                //return ConfigureApp
                //***MMM .ApkFile();
                //***MMM .InstalledApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

