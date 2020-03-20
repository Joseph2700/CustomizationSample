using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomizationSample.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
    
[assembly: ExportRenderer(typeof(EntryRenderer), typeof(ExtendedEntryiOS))]
namespace CustomizationSample.iOS.Renderers
{
    public class ExtendedEntryiOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(102, 255, 102);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
        public ExtendedEntryiOS()
        {

        }
    }
}