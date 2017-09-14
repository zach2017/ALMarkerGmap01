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

namespace MarkerTabs
{
    [Register ("MyMapContoller")]
    partial class MyMapContoller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIWebView myWeb { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (myWeb != null) {
                myWeb.Dispose ();
                myWeb = null;
            }
        }
    }
}