using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Adapters;

namespace BethanysPieShopMobile
{
    [Activity(Label = "PieMenuActivity")]
    public class PieMenuActivity : Activity
    {
        private RecyclerView _pieRecyclerView;
        private RecyclerView.LayoutManager _pieLayoutManager;
        private PieAdapter _pieAdapter;

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_menu);
            _pieRecyclerView = FindViewById<RecyclerView>(Resource.Id.pieMenuRecyclerView);

            _pieLayoutManager = new LinearLayoutManager(this);
            //_pieLayoutManager = new GridLayoutManager(this, 2, GridLayoutManager.Horizontal, false);
            _pieRecyclerView.SetLayoutManager(_pieLayoutManager);

            _pieAdapter = new PieAdapter();
            await _pieAdapter.LoadData();
            _pieAdapter.ItemClick += PieAdapter_ItemClick;

            _pieRecyclerView.SetAdapter(_pieAdapter);

            // Create your application here
        }

        private void PieAdapter_ItemClick(object sender, int e)
        {
            var intent = new Intent();
            intent.SetClass(this, typeof(PieDetailActivity));
            intent.PutExtra("selectedPieId", e);
            StartActivity(intent);
        }
    }
}