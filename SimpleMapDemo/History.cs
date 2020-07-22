using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Support.V7.Widget;
using Android.Widget;

namespace SimpleMapDemo
{
    [Activity(Label = "History")]
    public class History : Activity
    {
        private RecyclerView mRecyclerView;
        private RecyclerView.LayoutManager mLayoutManager;
        private RadioAlbumAdapter mAdapter;
        private RadioAlbum mRadioAlbum;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.History);


            mRadioAlbum = new RadioAlbum();

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerHistory);

            mLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);

            mRecyclerView.SetLayoutManager(mLayoutManager);

            mAdapter = new RadioAlbumAdapter(mRadioAlbum);

            mAdapter.ItemClick += OnItemClick;

            mRecyclerView.SetAdapter(mAdapter);

        }

        private void OnItemClick(object sender, int position)
        {
            // Display a toast that briefly shows the enumeration of the selected photo:
            //int photoNum = position + 1;
            //Toast.MakeText(this, "محصول شماره " + photoNum, ToastLength.Short).Show();
            //EditText amount = FindViewById<EditText>(Resource.Id.amount);

            //if (MainActivity._player.IsPlaying)
            //{
            //    MainActivity._player.Stop();
            //    MainActivity._player.Reset();
            //    //_player.Pause();
            //    //_player.Stop();
            //}
            ////_player=new MediaPlayer();
            ////_player.SetDataSourceAsync(this, Android.Net.Uri.Parse(mRadioAlbum[position].link));


            //try
            //{
            //    MainActivity._player.SetDataSource(this, Android.Net.Uri.Parse(mRadioAlbum[position].link));
            //    MainActivity._player.Prepare();
            //    MainActivity._player.Start();
            //    Toast.MakeText(this, "در حال بارگذاری..", ToastLength.Short).Show();
            //}
            //catch
            //{
            //    Toast.MakeText(this, "خطای بارگذاری", ToastLength.Short).Show();
            //}


            //SetContentView(Resource.Layout.RadioShow);


            //var radio = FindViewById<MediaController>(Resource.Id.mediaController1);
            //Android.Widget.MediaController.IMediaPlayerControl sw=new VideoView();
            //radio.SetMediaPlayer();

        }
        public class RadioViewHolder : RecyclerView.ViewHolder
        {
            public ImageView Image { get; private set; }
            public TextView Caption { get; private set; }

            // Get references to the views defined in the CardView layout.
            public RadioViewHolder(View itemView, Action<int> listener)
                : base(itemView)
            {
                // Locate and cache view references:
                Image = itemView.FindViewById<ImageView>(Resource.Id.imageView);
                Caption = itemView.FindViewById<TextView>(Resource.Id.textView);

                // Detect user clicks on the item view and report which item
                // was clicked (by layout position) to the listener:
                itemView.Click += (sender, e) => listener(base.LayoutPosition);
            }
        }

        public class RadioAlbumAdapter : RecyclerView.Adapter
        {
            // Event handler for item clicks:
            public event EventHandler<int> ItemClick;

            // Underlying data set (a Radio album):
            public RadioAlbum mRadioAlbum;

            // Load the adapter with the data set (Radio album) at construction time:
            public RadioAlbumAdapter(RadioAlbum RadioAlbum)
            {
                mRadioAlbum = RadioAlbum;
            }

            // Create a new Radio CardView (invoked by the layout manager): 
            public override RecyclerView.ViewHolder
                OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                // Inflate the CardView for the Radio:
                View itemView = LayoutInflater.From(parent.Context).
                            Inflate(Resource.Layout.RadioCardView, parent, false);

                // Create a ViewHolder to find and hold these view references, and 
                // register OnClick with the view holder:
                RadioViewHolder vh = new RadioViewHolder(itemView, OnClick);
                return vh;
            }

            // Fill in the contents of the Radio card (invoked by the layout manager):
            public override void
                OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                RadioViewHolder vh = holder as RadioViewHolder;

                // Set the ImageView and TextView in this ViewHolder's CardView 
                // from this position in the Radio album:
                vh.Image.SetImageResource(mRadioAlbum[position].RadioID);
                vh.Caption.Text = mRadioAlbum[position].Caption;
            }

            // Return the number of Radios available in the Radio album:
            public override int ItemCount => mRadioAlbum.NumRadios;

            // Raise an event when the item-click takes place:
            private void OnClick(int position)
            {
                if (ItemClick != null)
                {
                    ItemClick(this, position);
                }
            }
        }
    }
}