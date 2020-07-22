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

namespace SimpleMapDemo
{
    [Activity(Label = "WaitForAccepts")]
    public class WaitForAccepts : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.WaitForAccept);

            Button cancellOrder = FindViewById<Button>(Resource.Id.btnCancellOrder);
            cancellOrder.LongClick += CancellOrder_LongClick;


            // Create your application here
        }

        private void CancellOrder_LongClick(object sender, View.LongClickEventArgs e)
        {
            Toast.MakeText(this,"سفارش شما لغو شد",ToastLength.Long).Show();
            RWS.WebService1 web = new RWS.WebService1();
            web.CancelPersonRecycling(MainActivity.person._phone());
            StartActivity(typeof(MapWithOverlaysActivity));

        }

       
    }
}