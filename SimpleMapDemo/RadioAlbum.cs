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

    public class Radio
    {
        // Radio ID for this Radio:
        public int mRadioID;

        // Caption text for this Radio:
        public string mCaption;

        public string link;

        // Return the ID of the Radio:
        public int RadioID
        {
            get { return mRadioID; }
        }

        // Return the Caption of the Radio:
        public string Caption
        {
            get { return mCaption; }
        }

        public string Link
        {
            get { return link; }
        }
    }

    // Radio album: holds image resource IDs and caption:
    public class RadioAlbum
    {
        // Built-in Radio collection - this could be replaced with
        // a Radio database:

        static Radio[] mBuiltInRadios = {


            new Radio { mRadioID = Resource.Drawable.monkey,
                mCaption = "رادیو PRC"
                ,link ="http://37.59.47.192:8200/;stream/1"

            },

            //new Radio { mRadioID = Resource.Drawable.radio_ComedyShemroon,
            //    mCaption = "رادیو شمرون"
            //    ,link ="http://192.99.17.12:5919/;stream/1"

            //},


            //new Radio { mRadioID = Resource.Drawable.radio_lpr,
            //    mCaption = "رادیو LPR "
            //    ,link ="http://198.178.123.11:7574/;stream/1"

            //},

            //new Radio { mRadioID = Resource.Drawable.radio_mojdeh,
            //    mCaption = "رادیو Mojdeh "
            //    ,link ="http://72.13.81.34:5154/;stream/1"

            //},

            //new Radio { mRadioID = Resource.Drawable.radio_shemron,
            //    mCaption = "رادیو SHEMROON MUSIC "
            //    ,link ="https://www.internet-radio.com/servers/tools/playlistgenerator/?u=http://192.99.17.12:5919/listen.pls?sid=1&t=.m3u"

            //},

            //new Radio { mRadioID = Resource.Drawable.radio_darvish,
            //    mCaption = "رادیو Darvish "
            //    ,link ="http://95.154.202.117:8843/;stream/1"

            //},

            //new Radio { mRadioID = Resource.Drawable.radio_monasebati,
            //            mCaption = "رادیو امداد"
            //            ,link ="http://s3.cdn1.iranseda.ir:1935/liveedge/radio-monasebati/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_eghtesad,
            //            mCaption = "رادیو اقتصاد"
            //            ,link ="http://s3.cdn1.iranseda.ir:1935/liveedge/radio-eghtesad/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_avaa,
            //    mCaption = "رادیو آوا"
            //    ,link ="http://s0.cdn1.iranseda.ir:1935/liveedge/radio-avaa/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_iran,
            //    mCaption = "رادیو ایران"
            //    ,link ="http://s1.cdn1.iranseda.ir:1935/liveedge/radio-iran/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_payam,
            //    mCaption = "رادیو پیام"
            //    ,link ="http://s3.cdn1.iranseda.ir:1935/liveedge/radio-payam/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_talavat,
            //    mCaption = "رادیو تلاوت"
            //    ,link ="http://s0.cdn1.iranseda.ir:1935/liveedge/radio-talavat/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_tehran,
            //    mCaption = "رادیو تهران"
            //    ,link ="http://s1.cdn1.iranseda.ir:1935/liveedge/radio-tehran/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_javan,
            //    mCaption = "رادیو جوان ایران"
            //    ,link ="http://public.iranseda.ir/public/picturebymmc-tam/?chn=radio-javan&s=c&m=034001"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_saba,
            //    mCaption = "رادیو صبا"
            //    ,link ="http://s1.cdn1.iranseda.ir:1935/liveedge/radio-salamat/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_farhang,
            //    mCaption = "رادیو فرهنگ"
            //    ,link ="http://s0.cdn1.iranseda.ir:1935/liveedge/radio-farhang/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_quran,
            //    mCaption = "رادیو قرآن"
            //    ,link ="http://s3.cdn1.iranseda.ir:1935/liveedge/radio-quran/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_goftego,
            //    mCaption = "رادیو گفتگو"
            //    ,link ="http://s0.cdn1.iranseda.ir:1935/liveedge/radio-goftego/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_ketab,
            //    mCaption = "رادیو کتاب"
            //    ,link ="http://s0.cdn1.iranseda.ir:1935/liveedge/radio-ketab/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_maaref,
            //    mCaption = "رادیو معارف"
            //    ,link ="http://s3.cdn1.iranseda.ir:1935/liveedge/radio-maaref/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_namayesh,
            //    mCaption = "رادیو نمایش"
            //    ,link ="http://s2.cdn1.iranseda.ir:1935/liveedge/radio-namayesh/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_varzesh,
            //    mCaption = "رادیو ورزش"
            //    ,link ="http://s1.cdn1.iranseda.ir:1935/liveedge/radio-varzesh/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_arabic,
            //    mCaption = "رادیو عربی"
            //    ,link ="http://s0.cdn1.iranseda.ir:1935/liveedge/radio-arabic/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_english,
            //    mCaption = "رادیو انگلیسی"
            //    ,link ="http://s1.cdn1.iranseda.ir:1935/liveedge/radio-english/playlist.m3u8"
            //},
            //new Radio { mRadioID = Resource.Drawable.radio_ziarat,
            //    mCaption = "رادیو زیارت"
            //    ,link ="http://s0.cdn1.iranseda.ir:1935/liveedge/radio-ziarat/playlist.m3u8"
            //},
         
           
            };

        // Array of Radios that make up the album:
        private Radio[] mRadios;

        // Random number generator for shuffling the Radios:
        Random mRandom;

        // Create an instance copy of the built-in Radio list and
        // create the random number generator:
        public RadioAlbum()
        {
            mRadios = mBuiltInRadios;
            mRandom = new Random();
        }

        // Return the number of Radios in the Radio album:
        public int NumRadios
        {
            get { return mRadios.Length; }
        }

        // Indexer (read only) for accessing a Radio:
        public Radio this[int i]
        {
            get { return mRadios[i]; }
        }

        // Pick a random Radio and swap it with the top:
        public int RandomSwap()
        {
            // Save the Radio at the top:
            Radio tmpRadio = mRadios[0];

            // Generate a next random index between 1 and 
            // Length (noninclusive):
            int rnd = mRandom.Next(1, mRadios.Length);

            // Exchange top Radio with randomly-chosen Radio:
            mRadios[0] = mRadios[rnd];
            mRadios[rnd] = tmpRadio;

            // Return the index of which Radio was swapped with the top:
            return rnd;
        }

        // Shuffle the order of the Radios:
        public void Shuffle()
        {
            // Use the Fisher-Yates shuffle algorithm:
            for (int idx = 0; idx < mRadios.Length; ++idx)
            {
                // Save the Radio at idx:
                Radio tmpRadio = mRadios[idx];

                // Generate a next random index between idx (inclusive) and 
                // Length (noninclusive):
                int rnd = mRandom.Next(idx, mRadios.Length);

                // Exchange Radio at idx with randomly-chosen (later) Radio:
                mRadios[idx] = mRadios[rnd];
                mRadios[rnd] = tmpRadio;
            }
        }
    }
}