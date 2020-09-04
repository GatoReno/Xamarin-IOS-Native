using Foundation;
using System;
using System.Threading.Tasks;
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
            textView.BackgroundColor = UIColor.FromRGB(255, 237, 255);

            // textField.KeyboardType = UIKeyboardType.EmailAddress;
            // textField.KeyboardType = UIKeyboardType.PhonePad;
            // textField.KeyboardType = UIKeyboardType.NumberPad;
            // textField.KeyboardType = UIKeyboardType.Url;

            sliderBar.ValueChanged += SlideBar_ValueChanged;
            switchToggle.ValueChanged += SwitchToggle_ValueChanged;
            btn1.TouchUpInside += (object sender, EventArgs e) => {
                Console.WriteLine("CLICKED YEAH!!!!! 💀");
               // textView.Text = textField.Text;
                TransferProgressBar();
                textField.ResignFirstResponder();

                View.BackgroundColor = UIColor.White;
            };


            async void TransferProgressBar()
            {
                textView.Text = "";
                //textView.Text = textField.Text;
                while (textField.Text != "")
                {
                    await Task.Factory.StartNew(()=> {
                        InvokeOnMainThread(()=>
                        {
                            var lt = textField.Text.Substring(0, 1);
                            textView.Text = textView.Text + lt;
                            textField.Text = textField.Text.Substring(1);
                            UpDateProgressView();
                        });
                    });

                    await Task.Delay(500); // if we really wanna a rave change 500 to 100
                    RandomColorBG();
                }
            }

            void UpDateProgressView()
            {
                var txtl = (float)(textField.Text.Length + textView.Text.Length);
                var transferProg = textView.Text.Length / txtl;
                progressView.Progress = transferProg;
            }

            btn1.TouchDragExit += (object sender, EventArgs e) => {
                Console.WriteLine("TouchDragExit YEAH!!!!! 💀");

                textField.Text = "";
                View.BackgroundColor = UIColor.FromRGB(255, 237, 255);
            };
            btnRandom.TouchUpInside += (object sender, EventArgs e) =>
            {

                Console.WriteLine("Random YEAH!!!!! 💀");

                if (switchToggle.On)
                {

                    RandomColorBG();
                }
            };

        }

        void RandomColorBG() {
            var randSeed = new Random();
            var rc1 = (float)randSeed.Next(50,100);
            var rc2 = (float)randSeed.Next(50, 100);
            var rc3 = (float)randSeed.Next(50, 100);

            // btnRandom.color = UIColor.FromRGB(rc1, rc2, rc3);
            btnRandom.SetTitleColor(UIColor.FromRGB(rc1/100, rc2/100, rc3/100), UIControlState.Normal);
            View.BackgroundColor = UIColor.FromRGB(rc1 / 100, rc2 / 100, rc3 / 100);


        }

      

        private void SlideBar_ValueChanged(object sender, EventArgs e)
        {
            var val = sliderBar.Value;
            textView.Font = UIFont.SystemFontOfSize(val + 10);
            lblSlider.Text = $"Slider : {val}";
        }
        private void SwitchToggle_ValueChanged(object sender, EventArgs e)
        {
            if (switchToggle.On)
            {
                lblSwitch.Text = "Random colors enable";
            } else
            {
                lblSwitch.Text = "Random colors disable";
            }
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