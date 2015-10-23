using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamForm5Minutes
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        //MainPage = new NavigationPage(new MainPage());
        public float Number1 { get; set; }
        public float Number2 { get; set; }

        private float result;

        public event PropertyChangedEventHandler PropertyChanged;

        public float Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }

        public ICommand CalculateCommand { protected set; get; }

        public MainPageViewModel()
        {
            this.CalculateCommand = new Command(() =>
            {
                // Add the key to the input string.
                this.Result = Number2 * 100 / Number1;
            });
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
