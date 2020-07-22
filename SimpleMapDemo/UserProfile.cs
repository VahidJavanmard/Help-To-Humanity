using Android.App;
using Android.OS;
using Android.Widget;
using System;

namespace SimpleMapDemo
{
    [Activity(Label = "UserProfile")]
    public class UserProfile : Activity
    {
        private EditText edAddress;
        private EditText edFirstName;
        private EditText edLastName;
        private EditText edPhoneNumber;
        private EditText edNationalCode;
        private EditText edEmail;
        private EditText edReferal;
        private Button changeInfo;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private bool male;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.UserProfile);
                edAddress = FindViewById<EditText>(Resource.Id.edAddress);
                edFirstName = FindViewById<EditText>(Resource.Id.edFirstName);
                edLastName = FindViewById<EditText>(Resource.Id.edLastName);
                edPhoneNumber = FindViewById<EditText>(Resource.Id.edPhone);
                edPhoneNumber.Text = MainActivity.PhoneNumber;
                edNationalCode = FindViewById<EditText>(Resource.Id.edNationalCode);
                edEmail = FindViewById<EditText>(Resource.Id.edEmail);
                edReferal = FindViewById<EditText>(Resource.Id.edReferal);
                changeInfo = FindViewById<Button>(Resource.Id.btnChangeInfo);
                rdMale = FindViewById<RadioButton>(Resource.Id.rdMale);
                rdFemale = FindViewById<RadioButton>(Resource.Id.rdFemale);
                changeInfo.Click += ChangeInfo_Click;
                FillInfo();
            }
            catch (Exception err)
            {
                SetContentView(Resource.Layout.UserProfile);
                toast(err.Message);
            }




        }

        public void FillInfo()
        {
            try
            {
                MainActivity.person.GetInfo(MainActivity.person);
                edAddress.Text = MainActivity.person._address();
                edFirstName.Text = MainActivity.person._firstName();
                edLastName.Text = MainActivity.person._lastName();
                edPhoneNumber.Text = MainActivity.person._phone();
                edNationalCode.Text = MainActivity.person._nationalCode();
                edEmail.Text = MainActivity.person._email();
                edReferal.Text = MainActivity.person._referralCode();
                if (MainActivity.person._gender())
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }

            }
            catch (Exception er)
            {

                SetContentView(Resource.Layout.UserProfile);
            }
        }


        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdMale.Checked)
                {
                    male = true;
                }
                else
                {
                    male = false;
                }
                Member member = new Member();
                if (member._address(edAddress.Text))
                {
                    if (member._email(edEmail.Text))
                    {
                        if (member._firstName(edFirstName.Text))
                        {
                            if (member._lastName(edLastName.Text))
                            {
                                if (member._nationalCode(edNationalCode.Text))
                                {
                                    if (member._referralCode(edReferal.Text))
                                    {



                                        try
                                        {
                                            var web = new RWS.WebService1();
                                            if (web.ChangeInfoShort(edAddress.Text, edEmail.Text, male, edFirstName.Text, edLastName.Text,
                                                edNationalCode.Text,
                                                edPhoneNumber.Text, edReferal.Text))
                                            {
                                                toast("اطلاعات با موفقیت بروز  شد");
                                                Toast.MakeText(this, "اطلاعات با موفقیت بروز  شد", ToastLength.Long).Show();
                                            }
                                            else
                                            {
                                                Toast.MakeText(this, "اطلاعات   بروز  نشد", ToastLength.Long).Show();

                                            }
                                        }
                                        catch (Exception er)
                                        {

                                            Toast.MakeText(this, "عدم ارتباط با وب سرویس", ToastLength.Long).Show();
                                        }
                                    }
                                    else
                                    {
                                        toast("کد معرف صحیح نمی باشد");
                                    }

                                }
                                else
                                {
                                    toast("کد ملی   صحیح نمی باشد");

                                }
                            }
                            else
                            {
                                toast("نام خانوادگی  صحیح نمی باشد");

                            }

                        }
                        else
                        {
                            toast("نام  صحیح نمی باشد");

                        }
                    }
                    else
                    {
                        toast("ایمیل صحیح نمی باشد");

                    }

                }
                else
                {
                    toast("آدرس صحیح نمی باشد");

                }

            }
            catch (Exception er)
            {

                toast(er.Message);
            }


        }

        private void toast(string messege)
        {
            Toast.MakeText(this, messege, ToastLength.Long).Show();
        }
    }
}