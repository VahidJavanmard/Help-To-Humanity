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
    [Activity(Label = "Support")]
    public class Support : Activity
    {
        private EditText problemText;
        private Button sendTicket;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Support);


            sendTicket = FindViewById<Button>(Resource.Id.btnSendTicket);
            sendTicket.Enabled = false;

            problemText = FindViewById<EditText>(Resource.Id.edSupportMessege);
            problemText.TextChanged += ProblemText_TextChanged;


            sendTicket.Click += SendTicket_Click;

            // Create your application here
        }

        private void ProblemText_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (problemText.Text.Length > 5)
            {
                sendTicket.Enabled = true;
            }
            else
            {
                sendTicket.Enabled = false;
            }
        }

        private void SendTicket_Click(object sender, EventArgs e)
        {
            try
            {
                var web = new RWS.WebService1();
                if (web.SendTicket(MainActivity.PhoneNumber, problemText.Text))
                {
                    Toast.MakeText(this, "تیکت شما با موفقیت ارسال شد", ToastLength.Long).Show();

                }
                else
                {
                    Toast.MakeText(this, "تیکت شماارسال نشد", ToastLength.Long).Show();
                }
            }
            catch (Exception er)
            {

                Toast.MakeText(this, "عدم ارتباط با وب سرویس", ToastLength.Long).Show();

            }







        }
    }
}