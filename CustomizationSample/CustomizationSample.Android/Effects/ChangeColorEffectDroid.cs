using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomizationSample.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ResolutionGroupName("CustomizationSample")]
[assembly: ExportEffect(typeof(ChangeColorEffectDroid), "ChangeColorEffect")]
namespace CustomizationSample.Droid.Effects
{
    public class ChangeColorEffectDroid : PlatformEffect
    {
        Android.Graphics.Color BackgroundColor = new Android.Graphics.Color(0, 0, 0, 0);
        Android.Graphics.Color NewBackgroundColor;
        protected override void OnAttached()
        {            
            try
            {
                NewBackgroundColor = Android.Graphics.Color.LightGreen;
                Control.SetBackgroundColor(NewBackgroundColor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == NewBackgroundColor)
                    {
                        Control.SetBackgroundColor(BackgroundColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(NewBackgroundColor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}