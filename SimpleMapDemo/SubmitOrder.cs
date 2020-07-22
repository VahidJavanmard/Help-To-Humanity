using Android.App;
using Android.OS;
using Android.Widget;
using System;

namespace SimpleMapDemo
{
    [Activity(Label = "SubmitOrder")]
    public class SubmitOrder : Activity
    {
        private bool _type1 = true;
        private bool _type2 = false;
        private bool _type3 = false;
        private bool _type4 = false;
        private bool _type5 = false;
        private RadioButton rbType1;
        private RadioButton rbType2;
        private RadioButton rbType3;
        private RadioButton rbType4;
        private RadioButton rbType5;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SubmitOrder);

            Button submitOrder = FindViewById<Button>(Resource.Id.btnSubmitOrder);
            submitOrder.Click += SubmitOrder_Click;

            rbType1 = FindViewById<RadioButton>(Resource.Id.rbType1);
            rbType2 = FindViewById<RadioButton>(Resource.Id.rbType2);
            rbType3 = FindViewById<RadioButton>(Resource.Id.rbType3);
            rbType4 = FindViewById<RadioButton>(Resource.Id.rbType4);
            rbType5 = FindViewById<RadioButton>(Resource.Id.rbType5);
            rbType1.Click += RbType1_Click;
            rbType2.Click += RbType2_Click;
            rbType3.Click += RbType3_Click;
            rbType4.Click += RbType4_Click;
            rbType5.Click += RbType5_Click;
            // Create your application here
        }

        private void RbType5_Click(object sender, EventArgs e)
        {
            if (_type5)
            {
                rbType5.Checked = false;
                _type5 = false;
            }
            else
            {
                rbType5.Checked = true;
                _type5 = true;
            }
        }

        private void RbType4_Click(object sender, EventArgs e)
        {
            if (_type4)
            {
                rbType4.Checked = false;
                _type4 = false;

            }
            else
            {
                rbType4.Checked = true;
                _type4 = true;

            }
        }

        private void RbType3_Click(object sender, EventArgs e)
        {
            if (_type3)
            {
                rbType3.Checked = false;
                _type3 = false;

            }
            else
            {
                rbType3.Checked = true;
                _type3 = true;

            }
        }

        private void RbType2_Click(object sender, EventArgs e)
        {
            if (_type2)
            {
                rbType2.Checked = false;
                _type2 = false;

            }
            else
            {
                rbType2.Checked = true;
                _type2 = true;

            }
        }

        private void RbType1_Click(object sender, EventArgs e)
        {
            if (_type1)
            {
                rbType1.Checked = false;
                _type1 = false;
            }
            else
            {
                rbType1.Checked = true;
                _type1 = true;
            }
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            /// Find Elements From View

            try
            {
                /// گرفتن المنت های ویو
                EditText weight = FindViewById<EditText>(Resource.Id.edgWeight);



                //if (_type1)
                //{
                //    /// کاغذ
                //    _type1 = true;
                //}
                //if (rbType2.Checked)
                //{
                //    /// شیشه
                //    _type2 = true;
                //}
                //if (rbType3.Checked)
                //{
                //    /// فلزات
                //    _type3 = true;
                //}
                //if (rbType4.Checked)
                //{
                //    /// پلاستیک
                //    _type4 = true;
                //}
                //if (rbType5.Checked)
                //{
                //    /// قطعات رایانه
                //    _type5 = true;
                //}


                try
                {
                    /// ذخیره اطلاعات  نوع داده بازیافت


                    if (MainActivity.order._submitDate(DateTime.Now))
                    {
                        /// وضعیت سفارش به صورت انجام نشده ذخیره میشود
                        MainActivity.order._status(1);
                        //MainActivity.order._type(type);

                        /// وزن را که از کاربر گرفتیم بررسی میکنیم
                        if (MainActivity.order._weight(double.Parse(weight.Text)))
                        {

                            try
                            {
                                /// ذخیره کردن اطلاعات مربوط به سفارش
                                RWS.WebService1 web = new RWS.WebService1();
                                int type = web.SetRecyclingType(_type1, _type2, _type3, _type4, _type5);


                                if (MainActivity.order._type(type))
                                {
                                    string Code = web.AddRecycling(MainActivity.order._phoneNumber(),
                                        MainActivity.order._locationX(),
                                        MainActivity.order._locationY(), MainActivity.order._status()
                                        , MainActivity.order._submitDate(), MainActivity.order._type(),
                                        MainActivity.order._weight()
                                    );

                                    if (Code != "")
                                    {
                                        Toast.MakeText(this, $"سفارش شما با کد {Code.ToString()} موفقیت ثبت شد",
                                            ToastLength.Long).Show();
                                        Finish();
                                        StartActivity(typeof(MapWithOverlaysActivity));

                                    }
                                    else
                                    {
                                        Toast.MakeText(this, "سفارش شما ثبت  نشد/", ToastLength.Short).Show();
                                    }
                                }
                                else
                                {
                                    Toast.MakeText(this, "سفارش شما ثبت  نشد", ToastLength.Long).Show();
                                }



                                //if (web.AddRecycling(MainActivity.order._phoneNumber(), MainActivity.order._locationX(),
                                //                     MainActivity.order._locationY(), MainActivity.order._status()
                                //                     , MainActivity.order._submitDate(), MainActivity.order._type(), MainActivity.order._weight(),
                                //                     MainActivity.order._endtDate()))
                                //{
                                //    Toast.MakeText(this, "سفارش شما با موفقیت ثبت شد", ToastLength.Long).Show();

                                //}
                                //else
                                //{
                                //    Toast.MakeText(this, "سفارش شما ثبت  نشد", ToastLength.Long).Show();
                                //}

                            }
                            catch (Exception error)
                            {

                                Toast.MakeText(this, "عدم ارتباط با وب سرویس", ToastLength.Long).Show();

                            }

                        }
                        else
                        {
                            Toast.MakeText(this, "وزن وارد شده توسط شما قابل قبول نیست", ToastLength.Long).Show();
                        }

                    }
                    else
                    {
                        Toast.MakeText(this, "تاریخ موبایل شما صحیح نمی باشد", ToastLength.Long).Show();
                    }
                }
                catch (Exception er)
                {

                    Toast.MakeText(this, "مقدار وزن صحیح نمی باشد", ToastLength.Long).Show();
                }

            }
            catch (Exception error)
            {
                /// در صورت مشکل در لود المنت ها دوباره صفحه ریلود میشود
                Toast.MakeText(this, error.Message, ToastLength.Long).Show();
                StartActivity(typeof(SubmitOrder));

            }


        }
    }
}