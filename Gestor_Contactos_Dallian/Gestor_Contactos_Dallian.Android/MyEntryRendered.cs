using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

using Gestor_Contactos_Dallian;
using Gestor_Contactos_Dallian.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Content.Res;
using Android.Graphics;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRendered))]

namespace Gestor_Contactos_Dallian.Droid
{
    internal class MyEntryRendered : EntryRenderer
    {
        public MyEntryRendered(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            Control.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Goldenrod);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == Entry.TextProperty.PropertyName)
            {

                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Goldenrod);

                

                //if (Control.Text.Length > 6)  //Muda quando ultrapassar mais de 6 caracteres
                //{
                //    Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.White);
                //}
                //else
                //{
                //    Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Goldenrod);
                //}
            }
        }
    }
}