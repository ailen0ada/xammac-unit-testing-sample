using System;

using AppKit;
using Foundation;
using UnitTestingSample.Models;

namespace UnitTestingSample
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
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

        private NSString _currentFileName;

        [Outlet]
        public NSString CurrentFileName
        {
            get => this._currentFileName;
            set
            {
                this.WillChangeValue(nameof(CurrentFileName));
                this._currentFileName = value;
                this.DidChangeValue(nameof(CurrentFileName));
            }
        }

        private TempFileNameGenerator _generator = new TempFileNameGenerator();

        partial void GenerateNew(NSObject sender)
        {
            this.CurrentFileName = (NSString)this._generator.Generate();
        }
    }
}
