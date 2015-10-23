using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamForm5Minutes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            aboutButton.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new NativePage());
            };


            var text = DependencyService.Get<INativeSample>().GetInfo();
            titleLabel.Text = text;

        }
    }
}
