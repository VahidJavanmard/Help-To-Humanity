using System;
using System.Collections.Generic;

namespace SimpleMapDemo
{
    public class Member
    {

        private string phone;
        private DateTime birthday;
        private DateTime registerDate;
        private string nationalCode;
        private string firstName;
        private string lastName;
        private string email;
        private string address;
        private string referralCode;
        private bool gender;


        public bool _phone(string phone)
        {
            if (phone.Length >= 10)
            {
                if (phone.StartsWith("98")
                    || phone.StartsWith("09"))
                {
                    this.phone = phone;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool _birthday(DateTime birthday)
        {
            try
            {
                if (birthday < DateTime.Now)
                {
                    this.birthday = birthday;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool _registerDate(DateTime registerDate)
        {
            try
            {
                if (registerDate <= DateTime.Now && registerDate > (DateTime.Now - TimeSpan.FromDays(10)))
                {
                    this.registerDate = registerDate;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool _nationalCode(string nationalCode)
        {
            try
            {
                if (nationalCode.Length == 10)
                {
                    this.nationalCode = nationalCode;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool _firstName(string firstName)
        {
            try
            {
                if (firstName.Length > 2)
                {
                    this.firstName = firstName;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool _lastName(string lastName)
        {
            try
            {
                if (lastName.Length > 2)
                {
                    this.lastName = lastName;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }




        public bool _address(string address)
        {
            try
            {
                if (address.Length > 5)
                {
                    this.address = address;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool _email(string email)
        {
            try
            {
                if (email.Length > 10 && email.Contains("@"))
                {
                    this.email = email;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool _referralCode(string referralCode)
        {
            try
            {
                switch (referralCode.Length)
                {
                    case 0:
                        {
                            return true;
                            break;
                        }
                    case 11:
                        {
                            if (referralCode.StartsWith("98")
                                    || referralCode.StartsWith("09") && referralCode != MainActivity.PhoneNumber)
                            {
                                this.referralCode = referralCode;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    default:
                        {

                            return false;
                            break;

                        }

                }



                //if (referralCode.Length >= 10||referralCode.Length==0)
                //{

                //    if (phone.StartsWith("98")
                //        || phone.StartsWith("09"))
                //    {
                //        this.phone = phone;
                //        return true;
                //    }


                //    this.referralCode = referralCode;
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }
            catch (Exception e)
            {
                return false;
            }
        }




        public bool _gender(bool gender)
        {
            try
            {
                this.gender = gender;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public string _phone()
        {
            return phone;
        }

        public DateTime _birthday()
        {
            return birthday;
        }

        public DateTime _registerDate()
        {
            return registerDate;
        }

        public string _nationalCode()
        {
            return nationalCode;
        }

        public string _firstName()
        {
            return firstName;
        }

        public string _lastName()
        {
            return lastName;
        }

        public string _email()
        {
            return email;
        }

        public string _address()
        {
            return address;
        }

        public string _referralCode()
        {
            return referralCode;
        }

        public bool _gender()
        {
            return gender;
        }














        public Member()
        {

        }

        public Member(string _phone)
        {
            phone = _phone;
        }

        public Member(string _phone, DateTime _birthday
            , string _nationalCode, string _firstName
            , string _lastName, string _email
            , string _address, bool _gender
            , string _referralCode)
        {

            phone = _phone;
            birthday = _birthday;
            registerDate = DateTime.Now;
            nationalCode = _nationalCode;
            firstName = _firstName;
            lastName = _lastName;
            email = _email;
            address = _address;
            gender = _gender;
            referralCode = _referralCode;

        }




        public bool EditInfo(string _phone, DateTime _birthday
            , string _nationalCode, string _firstName
            , string _lastName, string _email
            , string _address, bool _gender
            , string _referralCode)
        {

            try
            {

                return true;
            }
            catch (Exception e)
            {

                return false;
            }


        }


        public bool CheckMember(string PhoneNumber)
        {

            //try
            //{
            RWS.WebService1 web = new RWS.WebService1();

            ///WebService Area For Check Old Members
            ///Or Insert Data Of New Members

            if (!web.CheckMember(PhoneNumber))
            {
                return false;
            }
            else
            {
                return true;
            }
            //ChangeActivity();

            //}
            //catch (Exception err)
            //{
            //    return true;

            //}
        }

        public bool AddMemberShort(Member people)
        {
            try
            {
                RWS.WebService1 web = new RWS.WebService1();
                if (web.AddMemberShort(people._phone(), DateTime.Now))
                {


                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                return false;
            }


        }

        public bool GetInfo(Member people)
        {
            try
            {
                RWS.WebService1 web = new RWS.WebService1();
                var result = web.GetInfo(MainActivity.PhoneNumber);
                people.address = result[0];
                people.email = result[1];
                people.firstName = result[2];
                people.lastName = result[3];
                people.nationalCode = result[4];
                people.phone = result[5];
                people.referralCode = result[6];
                people.gender = bool.Parse(result[7]);
                return true;
            }
            catch (Exception)
            {

                return false;
            }





        }



        public bool UpdateLoginDateTime(string phoneNumber)
        {

            try
            {
                RWS.WebService1 web = new RWS.WebService1();
                if (web.UpdateLoginDateTime(phoneNumber))
                {
                    return true;

                }
                else
                {
                return false;

                }
             
            }
            catch (Exception)
            {

                return false;
            }


        }


        //public bool Insert()
        //{

        //}






    }
}