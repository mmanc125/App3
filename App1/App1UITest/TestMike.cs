using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

using System.Threading;

namespace App1UITest2
{
    public class TestMike
    {

        //[Test]
        public void AndroidVzSamsungGalaxyS5()
        {
            IApp app;
            Platform platform;

            platform = platform = Platform.Android;

            if (platform == Platform.Android)
            {
            }

            app = ConfigureApp
                    .Android
                    .InstalledApp("com.companyname.App1")
                    .StartApp();


            
            System.Threading.Thread.Sleep(1000);
            app.Tap(x => x.Marked("Add"));
            System.Threading.Thread.Sleep(1000);
            app.Tap(x => x.Text("Item name"));
            System.Threading.Thread.Sleep(1000);
            app.EnterText(x => x.Class("FormsEditText").Text("Item name"), "rrrggg");
            System.Threading.Thread.Sleep(1000);
            app.Tap(x => x.Marked("Save"));
            System.Threading.Thread.Sleep(1000);
            app.Tap(x => x.Text("This is an item description.").Index(6));
            System.Threading.Thread.Sleep(1000);
            app.Tap(x => x.Class("AppCompatImageButton"));

            app.DismissKeyboard();   
        }
    }
}
