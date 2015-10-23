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

[assembly:Xamarin.Forms.Dependency(typeof(XamForm5Minutes.Droid.NativeSample))]

namespace XamForm5Minutes.Droid
{
    class NativeSample : INativeSample
    {
        public string GetInfo()
        {
            return "Native from Android";
        }
    }
}