using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using HP.LFT.SDK.Mobile;
using HP.LFT.Report;
using System.Drawing;

namespace Demo_CSharp_LeanFT_MobileCenter
{
    [TestClass]
    public class LeanFtTest : UnitTestClassBase<LeanFtTest>
    {
        IDevice device;
        IApplication app;
        IApplication web;



        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            device = MobileLab.LockDevice(new DeviceDescription
            {
                OsType = "Android",
                OsVersion = ">4.4.2"
            });




       app = device.Describe<IApplication>(new ApplicationDescription
            {
                Identifier = @"com.android2.calculator3",
                IsPackaged = false
            });

            app.Install();

            

        }

        [TestMethod]
        public void TestMethod1()
        {

            app.Describe<IButton>(new ButtonDescription
            {
                Text = @"2",
                ClassName = @"Button",
                MobileCenterIndex = 22
            }).Tap();

            app.Describe<IButton>(new ButtonDescription
            {
                Text = @"+",
                AccessibilityId = @"plus",
                ClassName = @"Button",
                MobileCenterIndex = 30
            }).Tap();

            app.Describe<IButton>(new ButtonDescription
            {
                Text = @"5",
                ClassName = @"Button",
                MobileCenterIndex = 19
            }).Tap();

            app.Describe<IButton>(new ButtonDescription
            {
                AccessibilityId = @"equals",
                ClassName = @"ImageButton",
                MobileCenterIndex = 0
            }).Tap();

            Image img = device.GetSnapshot();
            System.Threading.Thread.Sleep(1000);


            var answer = app.Describe<IEditField>(new EditFieldDescription
            {
                ClassName = @"Input",
                MobileCenterIndex = 0
            }).Text;

            int exp = 7;
            if (exp.ToString() == answer.ToString())
            {
                Reporter.ReportEvent("Simple Math", "It all adds up to " + answer.ToString(), Status.Passed, img);
            }
            else
            {
                Reporter.ReportEvent("Simple Math", "The answer was not " + exp.ToString() + ", it was: " + answer.ToString(), Status.Failed, img);
            }




        }

        [TestCleanup]
        public void TestCleanup()
        {
            device.Unlock(); 
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalTearDown();
        }
    }
}
