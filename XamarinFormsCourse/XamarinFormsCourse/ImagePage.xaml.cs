using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsCourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            var imageSource = new UriImageSource{ Uri = new Uri("https://2uiipg1ex7ap1ro233smnm15-wpengine.netdna-ssl.com/wp-content/uploads/2016/06/flower-png.png")};
            imageSource.CachingEnabled = false;
            imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source = imageSource;
            image.Source = ImageSource.FromResource("XamarinFormsCourse.Images.image.jpg");

            btn.ImageSource = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(iOS: "clock.png", Android: "clock.png"));
        }
    }
}