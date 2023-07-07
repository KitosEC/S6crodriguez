using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using S6crodriguez.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly:Xamarin.Forms.Dependency(typeof(mensajeAndroid))]
namespace S6crodriguez.Droid
{
    internal class mensajeAndroid : mensaje
    {
        public void longAlert(string Mensaje)
        {
            Toast.MakeText(Application.Context, Mensaje, ToastLength.Long).Show();
        }

        public void shortAlert(string Mensaje)
        {
            Toast.MakeText(Application.Context, Mensaje, ToastLength.Short).Show();
        }
    
    }
}