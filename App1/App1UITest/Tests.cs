using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

using System.Threading;

namespace App1UITest2
{
    [TestFixture(Platform.Android)]
 //***MMM   [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        //[Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void MikeTest()
        {
            System.Threading.Thread.Sleep(1000);
            //app.Tap(x => x.Class("ActionMenuView"));
            //System.Threading.Thread.Sleep(1000);
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

        //[Test]
        public void NewTest_Good001()
        {
            System.Threading.Thread.Sleep(1000);
            //app.Tap(x => x.Class("ActionMenuView"));
            //System.Threading.Thread.Sleep(1000);
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
        }




    }
}

