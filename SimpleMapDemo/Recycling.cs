using System;

namespace SimpleMapDemo
{
    public class Recycling
    {

        private string phoneNumber;
        private int type;
        private double weight;
        private int status;
        //private Point location;
        private string locationX;
        private string locationY;

        private DateTime submitDate;
        private DateTime endtDate;
        private int driverId;




        public bool _phoneNumber(string phone)
        {
            try
            {
                if (phone.Length >= 10)
                {
                    if (phone.StartsWith("98")
                        || phone.StartsWith("09"))
                    {
                        phoneNumber = phone;
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
            catch (Exception e)
            {

                return false;
            }


        }


        public bool _type(int type)
        {
            try
            {
                //if (type <= 5 && type > 0&&type!=-1)
                //{
                //    this.type = type;
                //    return true;
                //}
                if (type != -1)
                {
                    this.type = type;
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


        public bool _weight(double weight)
        {
            try
            {
                if (weight > 0&&weight.ToString().Length>0)
                {
                    this.weight = weight;
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

        public bool _status(int status)
        {
            try
            {
                if (status < 5 && status > 0)
                {
                    this.status = status;
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


        public bool _submitDate(DateTime submitdate)
        {
            try
            {
                if (submitdate <= DateTime.Now && submitdate > (DateTime.Now - TimeSpan.FromDays(10)))
                {
                    submitDate = submitdate;
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


        public bool _endtDate(DateTime endtDate)
        {
            try
            {
                this.endtDate = endtDate;
                return true;
            }
            catch (Exception e)
            {

                return false;
            }

        }



        public bool _driverId(int driverId)
        {
            try
            {
                if (driverId > 0)
                {
                    this.driverId = driverId;
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


        //public bool _location(Point location)
        //{

        //    try
        //    {

        //        this.location = location;
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }


        //}




        public bool _locationX(string x)
        {

            try
            {

                locationX = x;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }


        public bool _locationY(string Y)
        {

            try
            {

                locationY = Y;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }



        public string _phoneNumber()
        {
            return phoneNumber;
        }

        public int _type()
        {
            return type;
        }

        public double _weight()
        {
            return weight;
        }

        public int _status()
        {
            return status;
        }

        //public Point _location()
        //{
        //    return location;
        //}
        public string _locationX()
        {
            return locationX;
        }
        public string _locationY()
        {
            return locationY;
        }

        public DateTime _submitDate()
        {
            return submitDate;
        }

        public DateTime _endtDate()
        {
            return endtDate;
        }
        public int _driverId()
        {
            return driverId;
        }












        public Recycling()
        {

        }

        //public Recycling(string _phoneNumber, int _type
        //    , int _weight, int _status, Point _location
        //    , DateTime _submitDate)
        //{
        //    phoneNumber = _phoneNumber;
        //    type = _type;
        //    weight = _weight;
        //    status = _status;
        //    location = _location;
        //    submitDate = _submitDate;
        //}

        public bool Insert(Recycling rc)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Cancell(Recycling rc)
        {
            try
            {

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


       




    }
}