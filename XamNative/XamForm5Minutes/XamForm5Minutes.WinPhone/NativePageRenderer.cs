using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(XamForm5Minutes.NativePage), 
    typeof(XamForm5Minutes.WinPhone.NativePageRenderer))]

namespace XamForm5Minutes.WinPhone
{
    class NativePageRenderer:PageRenderer
    {
        public NativePageRenderer()
        {
            this.Children.Add(new NativePage());
        }
    }
}
