using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
//using Android.Views;
using Android.Widget;
using Java.Lang;
using System.Collections.Generic;

namespace SimpleMapDemo
{

    [Activity(Label = "@string/activity_label_mapwithoverlays")]
    public class MapWithOverlaysActivity : AppCompatActivity, IOnMapReadyCallback
    {
        private static readonly LatLng InMaui = new LatLng(36.297580, 59.606015);
        private static readonly LatLng LeaveFromHereToMaui = new LatLng(58.768410, -94.164963);
        private static readonly LatLng[] LocationForCustomIconMarkers =
        {
            //new LatLng(40.741773, -74.004986),
            //new LatLng(41.051696, -73.545667),
            //new LatLng(41.311197, -72.902646)
        };
        private GoogleMap googleMap;
        private string gotMauiMarkerId;
        private MapFragment mapFragment;
        private Marker polarBearMarker;
        private GroundOverlay polarBearOverlay;

        //private readonly Toolbar myToolbar;
        private ListView MyListView;
        private List<string> List;
        private ManageDrawer manageDrawer;
        private DrawerLayout MyDrawer;

        private Marker orderMarker = null;


        public void OnMapReady(GoogleMap map)
        {
            googleMap = map;
            try
            {
                try
                {
                    googleMap.MyLocationEnabled = true;
                }
                catch (System.Exception er)
                {
                    Toast.MakeText(this, er.Message.ToString(),ToastLength.Long).Show();
                }



                // Move Camera
                try
                {
                    googleMap.AnimateCamera(CameraUpdateFactory.NewLatLngZoom(InMaui, 17));
                }
                catch (System.Exception e)
                {

                }

                try
                {
                    googleMap.MapClick += GoogleMap_MapClick;
                }
                catch (System.Exception e)
                {
                    Toast.MakeText(this, e.Message.ToString(), ToastLength.Short).Show();
                }
            }
            catch
            {

            }

            // Setup a handler for when the user clicks on a marker.
            //googleMap.MarkerClick += MapOnMarkerClick;
        }

        private void GoogleMap_MapClick(object sender, GoogleMap.MapClickEventArgs e)
        {
            if (orderMarker == null)
            {
            }
            else
            {
                orderMarker.Remove();
            }
            MarkerOptions markerOptions = new MarkerOptions();
            BitmapDescriptor icon = BitmapDescriptorFactory.FromResource(Resource.Drawable.marker);
            markerOptions
                .SetPosition(new LatLng(e.Point.Latitude, e.Point.Longitude))
                .SetIcon(icon);
            //.SetSnippet($"مکان سفارش")
            //.SetTitle($"جا");
            orderMarker = googleMap.AddMarker(markerOptions);
            Button order = FindViewById<Button>(Resource.Id.btnOrder);
            order.Visibility = ViewStates.Visible;
            order.Click += Order_Click;

        }

        private void Order_Click(object sender, System.EventArgs e)
        {
            //Toast.MakeText(this,
            //    $"مکان {orderMarker.Position.Latitude.ToString() + "و" + orderMarker.Position.Longitude.ToString()}" +
            //    $" ثبت شد"
            //    , ToastLength.Short).Show();


            try
            {
                if (MainActivity.order._locationX(orderMarker.Position.Longitude.ToString()) &&
                      MainActivity.order._locationY(orderMarker.Position.Latitude.ToString()))
                {
                    StartActivity(typeof(SubmitOrder));

                }
                else
                {
                    StartActivity(typeof(MapWithOverlaysActivity));
                }
            }
            catch (System.Exception er)
            {

                StartActivity(typeof(MapWithOverlaysActivity));
            }



        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MapWithOverlayLayout);



            #region CheckForServices
            try
            {
                RWS.WebService1 web = new RWS.WebService1();
                var phoneNumber = MainActivity.person._phone();
                var hasService = web.CheckRecycling(phoneNumber);
                if (hasService)
                {
                    StartActivity(typeof(WaitForAccepts));
                    // Has Service

                }
                else
                {
                    // Not Have Service

                }
            }
            catch 
            {

                StartActivity(typeof(MapWithOverlaysActivity));
            }
            #endregion








            mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);

            MyListView = FindViewById<ListView>(Resource.Id.MyListView);
            List = new List<string>()
            {

                "اطلاعات کاربری",
                "تاریخچه",
                "آدرس های منتخب",
                "پیام ها",
                "پشتیبانی",
                "تنظیمات",
                "تماس با ما",
                "درباره ما",
                "خروج",


            };
            MyListView.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, List);
            MyListView.ItemClick += MyListView_ItemClick;
            MyDrawer = FindViewById<DrawerLayout>(Resource.Id.MyDrawer);
            MyListView.Tag = 0;
            manageDrawer = new ManageDrawer(this, MyDrawer, Resource.String.openDrawer, Resource.String.closeDrawe);


            MyDrawer.SetDrawerListener(manageDrawer);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(true);
            manageDrawer.SyncState();
            MyDrawer.DrawerClosed += MyDrawer_DrawerClosed;
            MyDrawer.DrawerOpened += MyDrawer_DrawerOpened;





        }



        private void MyDrawer_DrawerOpened(object sender, DrawerLayout.DrawerOpenedEventArgs e)
        {
            mapFragment.View.Visibility = ViewStates.Invisible;

        }

        private void MyDrawer_DrawerClosed(object sender, DrawerLayout.DrawerClosedEventArgs e)
        {
            mapFragment.View.Visibility = ViewStates.Visible;


        }

        private void MyListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, List[e.Position], ToastLength.Short).Show();

            switch (e.Position)
            {


                case 0:
                    {
                        /// اطلاعات کاربری
                        StartActivity(typeof(UserProfile));

                        break;
                    }
                case 1:
                    {
                        /// تاریخچه
                        StartActivity(typeof(History));

                        break;
                    }
                case 2:
                    {
                        ///  آدرس های منتخب
                        //StartActivity(typeof(SubmitOrder));

                        break;
                    }
                case 3:
                    {
                        /// پیام ها
                        //StartActivity(typeof(SubmitOrder));

                        break;
                    }
                case 4:
                    {
                        ///  پشتیبانی
                        StartActivity(typeof(Support));

                        break;
                    }
                case 5:
                    {
                        ///   تنظیمات
                        //StartActivity(typeof(SubmitOrder));

                        break;
                    }
                case 6:
                    {
                        ///   تماس با ما
                        //StartActivity(typeof(SubmitOrder));

                        break;
                    }
                case 7:
                    {
                        ///    درباره ما
                        //StartActivity(typeof(SubmitOrder));

                        break;
                    }
                case 8:
                    {
                        ///   خروج

                        StartActivity(typeof(MainActivity));
                        //JavaSystem.Exit(0);
                        break;
                    }

            }



        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    {


                        MyDrawer.CloseDrawer(MyListView);
                        //if(!MyDrawer.IsDrawerOpen(MyListView))
                        //{ 
                        //    mapFragment.View.Visibility=ViewStates.Invisible;
                        //}
                        //else
                        //{
                        //    mapFragment.View.Visibility = ViewStates.Visible;
                        //}
                        manageDrawer.OnOptionsItemSelected(item);
                        break;
                    }
            }
            return base.OnOptionsItemSelected(item);
        }

        protected override void OnPause()
        {
            // Pause the GPS - we won't have to worry about showing the 
            // location.
            try
            {
                googleMap.MyLocationEnabled = true;

                googleMap.MarkerClick -= MapOnMarkerClick;
                googleMap.InfoWindowClick -= HandleInfoWindowClick;
            }
            catch (System.Exception)
            {

            }

            base.OnPause();
        }

        private void AddInitialPolarBarToMap()
        {
            MarkerOptions markerOptions = new MarkerOptions()
                                .SetSnippet("Click me to go on vacation.")
                                .SetPosition(LeaveFromHereToMaui)
                                .SetTitle("Goto Maui");
            polarBearMarker = googleMap.AddMarker(markerOptions);
            polarBearMarker.ShowInfoWindow();

            gotMauiMarkerId = polarBearMarker.Id;

            PositionPolarBearGroundOverlay(LeaveFromHereToMaui);
        }

        /// <summary>
        ///     Add three markers to the map.
        /// </summary>
        //private void AddMonkeyMarkersToMap()
        //{
        //    for (int i = 0; i < LocationForCustomIconMarkers.Length; i++)
        //    {
        //        BitmapDescriptor icon = BitmapDescriptorFactory.FromResource(Resource.Drawable.monkey);
        //        MarkerOptions markerOptions = new MarkerOptions()
        //                            .SetPosition(LocationForCustomIconMarkers[i])
        //                            .SetIcon(icon)
        //                            .SetSnippet($"This is marker #{i}.")
        //                            .SetTitle($"Marker {i}");
        //        googleMap.AddMarker(markerOptions);
        //    }
        //}

        private void HandleInfoWindowClick(object sender, GoogleMap.InfoWindowClickEventArgs e)
        {
            CircleOptions circleOptions = new CircleOptions();
            circleOptions.InvokeCenter(InMaui);
            circleOptions.InvokeRadius(100.0);
        }

        private void MapOnMarkerClick(object sender, GoogleMap.MarkerClickEventArgs markerClickEventArgs)
        {
            markerClickEventArgs.Handled = true;

            Marker marker = markerClickEventArgs.Marker;
            if (marker.Id.Equals(gotMauiMarkerId))
            {
                PositionPolarBearGroundOverlay(InMaui);
                googleMap.AnimateCamera(CameraUpdateFactory.NewLatLngZoom(InMaui, 13));
                gotMauiMarkerId = null;
                polarBearMarker.Remove();
                polarBearMarker = null;
            }
            else
            {
                Toast.MakeText(this, $"You clicked on Marker ID {marker.Id}", ToastLength.Short).Show();
            }
        }

        private void PositionPolarBearGroundOverlay(LatLng position)
        {
            if (polarBearOverlay == null)
            {
                BitmapDescriptor polarBear = BitmapDescriptorFactory.FromResource(Resource.Drawable.polarbear);
                GroundOverlayOptions groundOverlayOptions = new GroundOverlayOptions()
                                           .InvokeImage(polarBear)
                                           .Anchor(0, 1)
                                           .Position(position, 150, 200);
                polarBearOverlay = googleMap.AddGroundOverlay(groundOverlayOptions);
            }
            else
            {
                polarBearOverlay.Position = InMaui;
            }
        }


    }
}
