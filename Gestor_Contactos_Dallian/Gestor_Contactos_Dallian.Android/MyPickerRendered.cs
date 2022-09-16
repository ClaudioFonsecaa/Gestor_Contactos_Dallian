using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Gestor_Contactos_Dallian.Droid;
using Gestor_Contactos_Dallian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content.Res;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(MyPicker), typeof(MyPickerRendered))]

namespace Gestor_Contactos_Dallian.Droid
{
    internal class MyPickerRendered : PickerRenderer
    {
        public MyPickerRendered(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            Control.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Goldenrod);
        }


    }
}