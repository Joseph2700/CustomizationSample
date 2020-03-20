using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomizationSample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public string Orientation { get; set; }
        public MainPageViewModel()
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientation>().GetOrientation();
            if (orientation.ToString() == "Portrait")
            {
                Orientation = "Portrait";
            }
            else
            {
                Orientation = "Landscape";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
