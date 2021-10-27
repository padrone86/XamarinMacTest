using System;

using AppKit;
using Foundation;
using XamarinMacTest.Models;

namespace XamarinMacTest
{
    public partial class ViewController : NSViewController
    {
        private Hoge hoge = new Hoge("HOGE");

        [Export("Hoge")]
        public Hoge Hoge
        {
            get { return hoge; }
            set
            {
                WillChangeValue("Hoge");
                hoge = value;
                DidChangeValue("Hoge");
            }
        }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //hoge.AddObserver("InputString", NSKeyValueObservingOptions.New, (sender) =>
            //{
            //    Console.WriteLine($"InputString: {hoge.InputString}");
            //});
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
