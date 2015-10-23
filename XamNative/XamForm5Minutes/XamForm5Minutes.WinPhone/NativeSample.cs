using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly:Xamarin.Forms.Dependency(typeof(XamForm5Minutes.WinPhone.NativeSample))]
namespace XamForm5Minutes.WinPhone
{
    class NativeSample : INativeSample
    {
        public string GetInfo()
        {
            return "Native from WP";
        }
    }
}
