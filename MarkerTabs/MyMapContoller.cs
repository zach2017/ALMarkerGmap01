using Foundation;
using System;
using UIKit;

namespace MarkerTabs
{
    public partial class MyMapContoller : UIViewController
    {
        public MyMapContoller (IntPtr handle) : base (handle)
        {
            
        }
		
		public override void ViewDidLoad()
        {
			base.ViewDidLoad();
			string htmlstring = System.IO.File.ReadAllText("TemplateMap.html");
            myWeb.LoadHtmlString(htmlstring, null);

            // Intercept URL loading to handle native calls from browser
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
        bool HandleShouldStartLoad(UIWebView webView, NSUrlRequest request, UIWebViewNavigationType navigationType)
		{
			// Filter out clicked links
			if (navigationType == UIWebViewNavigationType.LinkClicked)
			{
				if (UIApplication.SharedApplication.CanOpenUrl(request.Url))
				{
					// Open in Safari instead
					UIApplication.SharedApplication.OpenUrl(request.Url);
					return false;
				}
			}

			return true;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}