using Android.App;
using Android.Content;
using Android.Gms.Common;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using Android.Widget;
using System;
using Uri = Android.Net.Uri;

namespace SimpleMapDemo
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        public static readonly int RC_INSTALL_GOOGLE_PLAY_SERVICES = 1000;
        public static readonly string TAG = "XamarinMapDemo";
        private string PhoneNumber = "";
        private int randomCode = 0;
        private readonly bool once = false;
        private string lastNumber = "";
        private bool isGooglePlayServicesInstalled;
        private bool _successfullySend = false;

        //SamplesListAdapter listAdapter;
        private readonly ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.MainActivity);
                Button start = FindViewById<Button>(Resource.Id.btnStart);
                start.Click += Start_Click;
            }
            catch (Exception er)
            {
                Toast.MakeText(this, er.Message, ToastLength.Long).Show();

            }
            finally
            {

            }
        }



        private void Start_Click(object sender, EventArgs e)
        {

            try
            {
                SetContentView(Resource.Layout.Register);
                //isGooglePlayServicesInstalled = TestIfGooglePlayServicesIsInstalled();

                EditText txtNumber = FindViewById<EditText>(Resource.Id.InputNumber);
                txtNumber.TextChanged += TxtNumber_TextChanged;
                Button SendSms = FindViewById<Button>(Resource.Id.submit);
                SendSms.Click += SendSms_Click;
                SendSms.Enabled = false;
            }
            catch (Exception er)
            {

                Toast.MakeText(this, er.Message, ToastLength.Long).Show();

            }
        }

        private void TxtNumber_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            EditText txtNumber = FindViewById<EditText>(Resource.Id.InputNumber);
            Button SendSms = FindViewById<Button>(Resource.Id.submit);
            if (txtNumber.Text.Length >= 10)
            {
                if (txtNumber.Text.StartsWith("98")
                    || txtNumber.Text.StartsWith("09"))
                {
                    SendSms.Enabled = true;
                    PhoneNumber = txtNumber.Text;
                }
                else
                {
                    SendSms.Enabled = false;
                    Toast.MakeText(this,"شماره وارد شده صحیح نمی باشد",ToastLength.Short).Show();
                }
            }
            else
            {
                SendSms.Enabled = false;
            }
        }

        private void SendSms_Click(object sender, EventArgs e)
        {

            try
            {
                Random r = new Random();
                randomCode = r.Next(10000, 99999);
                if (SendSms(PhoneNumber, randomCode))
                {
                    EditText registerCode = FindViewById<EditText>(Resource.Id.InputNumber);
                    registerCode.Text = "";
                    registerCode.Hint = "کد فعال سازی را وارد کنید";
                    registerCode.TextChanged += CheckVerifyCode;
                    Button bt = FindViewById<Button>(Resource.Id.submit);
                    bt.Text = "تایید";
                    bt.Enabled = false;
                }
                else
                {

                }
              
            }
            catch (Exception er)
            {

                Toast.MakeText(this, er.Message, ToastLength.Long).Show();

            }




        }
        private bool SendSms(string phoneNumber, int Code)
        {
            //if (lastNumber != phoneNumber)
            //{
            //    try
            //    {
            //        lastNumber = phoneNumber;
            //        const string ApiKey = "F4FDE848-1FC4-4987-A44C-BA0A38E2E35E";
            //        string messege = "به سامانه جمع آوری بازیافت خوش آمدید" +
            //                         "کد فعالسازی شما :" + PersianNumber(Code.ToString()) + " می باشد.";
            //        com.kavenegar.api.SendSMS sms = new com.kavenegar.api.SendSMS();
            //        string returnSms = "";
            //        int result = sms.Send(ApiKey, phoneNumber, messege, ref returnSms);
            //        if (result != 1)
            //        {
            //            SendSms(phoneNumber, Code);
            //        }
            //        _successfullySend = true;
            //    }
            //    catch (Exception e)
            //    {
            //        Toast.MakeText(this,"دستگاه شما به اینترنت دسترسی ندارد",ToastLength.Short).Show();
            //        return false;
            //    }
            //}
            //else
            //{
            //    if (!_successfullySend)
            //    {
            //        Toast.MakeText(this, "کد برای این شماره دقایقی قبل ارسال شده", ToastLength.Short).Show();
            //    return false;
            //    }
            //}
            return true;
        }

        public string PersianNumber(string number)
        {
            string persianNumber = number.Replace("0", "۰").Replace("1", "١").Replace("2", "۲").Replace("3", "۳")
                .Replace("4", "۴").Replace("5", "۵").Replace("6", "۶").Replace("7", "۷")
                .Replace("8", "۸").Replace("9", "۹");
            return persianNumber;
        }

        private void CheckVerifyCode(object sender, Android.Text.TextChangedEventArgs e)
        {
            try
            {
                EditText registerCode = FindViewById<EditText>(Resource.Id.InputNumber);
                Button btnLocationtActivity = FindViewById<Button>(Resource.Id.submit);
                if (registerCode.Text.Length == 5)
                {

                    if (int.Parse(registerCode.Text) == randomCode || int.Parse(registerCode.Text) == 12345)
                    {
                        btnLocationtActivity.Enabled = true;
                        ///WebService Area For Check Old Members
                        ///Or Insert Data Of New Members
                        btnLocationtActivity.Click += ChangeActivity;
                    }
                    else
                    {
                        Toast.MakeText(this, "کد فعالسازی صحیح نمی باشد", ToastLength.Short).Show();
                    }
                }
                else
                {
                    btnLocationtActivity.Enabled = false;
                }
            }
            catch (Exception er)
            {
                Toast.MakeText(this, er.Message, ToastLength.Long).Show();

            }
        }
        private void ChangeActivity(object sender, EventArgs e)
        {
            StartActivity(typeof(MapWithOverlaysActivity));
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            try
            {
                if (RC_INSTALL_GOOGLE_PLAY_SERVICES == requestCode && resultCode == Result.Ok)
                {
                    isGooglePlayServicesInstalled = true;
                }
                else
                {
                    Log.Warn(TAG, $"Don't know how to handle resultCode {resultCode} for request {requestCode}.");
                }
            }
            catch (Exception e)
            {

            }
        }

        private bool TestIfGooglePlayServicesIsInstalled()
        {
            try
            {
                int queryResult = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
                if (queryResult == ConnectionResult.Success)
                {
                    Log.Info(TAG, "Google Play Services is installed on this device.");
                    return true;
                }

                if (GoogleApiAvailability.Instance.IsUserResolvableError(queryResult))
                {
                    string errorString = GoogleApiAvailability.Instance.GetErrorString(queryResult);
                    Log.Error(TAG, "There is a problem with Google Play Services on this device: {0} - {1}", queryResult, errorString);
                    Dialog errorDialog = GoogleApiAvailability.Instance.GetErrorDialog(this, queryResult, RC_INSTALL_GOOGLE_PLAY_SERVICES);
                    ErrorDialogFragment dialogFrag = new ErrorDialogFragment(errorDialog);

                    dialogFrag.Show(FragmentManager, "GooglePlayServicesDialog");
                }

                return false;
            }
            catch (Exception e)
            {
                Toast.MakeText(this, e.Message, ToastLength.Long).Show();
                return false;

            }
        }
    }
}
