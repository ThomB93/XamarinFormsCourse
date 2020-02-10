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
    public partial class GreetPage : ContentPage
    {
        List<string> quotes = new List<string>();
        public GreetPage()
        {
            InitializeComponent();

            //use c# code to add XAMS elements dynamically
            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Center"
            //};
            
            quotes.Add("Few are those who see with their own eyes and feel with their own hearts.");
            quotes.Add("Imagination is more important than knowledge. Knowledge is limited. Imagination encircles the world.");
            quotes.Add("Unthinking respect for authority is the greatest enemy of truth.");
            quotes.Add("Try not to become a man of success, but rather try to become a man of value.");
            quotes.Add("Great spirits have always encountered violent opposition from mediocre minds.");

            var random = new Random();
            int index = random.Next(quotes.Count);

            quote.Text = quotes[index];
            slider.Value = 16;

            if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
            } 
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(quotes.Count);
            quote.Text = quotes[index];
        }
    }
}