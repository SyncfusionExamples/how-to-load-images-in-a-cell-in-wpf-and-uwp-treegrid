using Syncfusion.Data;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.TreeGrid.Converter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfTreeGridDemo
{
    class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string imageName = value.ToString();
            if (imageName=="US.jpg")
            {
                Uri uri = new Uri("ms-appx:///Images/US.jpg");
                BitmapImage image = new BitmapImage(uri);
                return image;
            }

            else if(imageName=="UK.jpg")
            {
                Uri uri1 = new Uri("ms-appx:///Images/UK.jpg");
                BitmapImage image = new BitmapImage(uri1);
                return image;
            }

            else
            {
                Uri uri1 = new Uri("ms-appx:///Images/Japan.jpg");
                BitmapImage image = new BitmapImage(uri1);
                return image;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
   }
}
