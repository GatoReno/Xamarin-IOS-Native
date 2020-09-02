using Foundation;
using System;
using UIKit;

namespace IOSFirstApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Console.WriteLine("ViewDidLoad Launched 📡");
            // Perform any additional setup after loading the view, typically from a nib.

            btn1.TouchUpInside += (object sender, EventArgs e) => {
                Console.WriteLine("CLICKED YEAH!!!!! 💀");
                textView.Text = textField.Text;
            };

            btn1.TouchDragExit += (object sender, EventArgs e) => {
                Console.WriteLine("TouchDragExit YEAH!!!!! 💀");
               
                textField.Text = "";
            };
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            Console.WriteLine("ViewWillAppear Launched 📡");
        }
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            Console.WriteLine("ViewWillDisappear Launched 📡");
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}