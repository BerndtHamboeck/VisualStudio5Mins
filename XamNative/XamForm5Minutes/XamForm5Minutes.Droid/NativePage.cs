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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

[assembly:ExportRenderer(typeof(XamForm5Minutes.NativePage), typeof(XamForm5Minutes.Droid.NativePage))]

namespace XamForm5Minutes.Droid
{
    public class NativePage : PageRenderer
    {
        private Android.Views.View _view;

        public NativePage()
        {
            var activity = this.Context as Activity;

            _view = activity.LayoutInflater.Inflate(Resource.Layout.NativeLayout, this, false);

            var label = _view.FindViewById<TextView>(Resource.Id.textView1);
            var text = label.Text;

            AddView(_view);

        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            var msw = MeasureSpec.MakeMeasureSpec(r - l, MeasureSpecMode.Exactly);
            var msh = MeasureSpec.MakeMeasureSpec(b - t, MeasureSpecMode.Exactly);
            _view.Measure(msw, msh);
            _view.Layout(0, 0, r - l, b - t);
        }


    }
}