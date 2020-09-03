// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IOSFirstApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRandom { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Lbl1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider sliderBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch switchToggle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView textView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btn1 != null) {
                btn1.Dispose ();
                btn1 = null;
            }

            if (btnRandom != null) {
                btnRandom.Dispose ();
                btnRandom = null;
            }

            if (Lbl1 != null) {
                Lbl1.Dispose ();
                Lbl1 = null;
            }

            if (lblSlider != null) {
                lblSlider.Dispose ();
                lblSlider = null;
            }

            if (lblSwitch != null) {
                lblSwitch.Dispose ();
                lblSwitch = null;
            }

            if (sliderBar != null) {
                sliderBar.Dispose ();
                sliderBar = null;
            }

            if (switchToggle != null) {
                switchToggle.Dispose ();
                switchToggle = null;
            }

            if (textField != null) {
                textField.Dispose ();
                textField = null;
            }

            if (textView != null) {
                textView.Dispose ();
                textView = null;
            }
        }
    }
}