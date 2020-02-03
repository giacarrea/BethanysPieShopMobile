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
using BethanysPieShopMobile.Core.Model;

namespace BethanysPieShopMobile.Fragments
{
    public class PieCategoryFragment: Android.Support.V4.App.Fragment
    {
        private readonly Category _category;

        public PieCategoryFragment(Category category)
        {
            _category = category;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.pie_menu_fragment, container, false);

            var categoryTextView = view.FindViewById<TextView>(Resource.Id.categoryTextView);
            categoryTextView.Text = _category.CategoryName;

            var pieRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.pieMenuRecyclerView);
            var pieLayoutManager = new LinearLayoutManager(this.Context);
            pieRecyclerView.SetLayoutManager(pieLayoutManager);

            var pieAdapter = new PieAdapter(_category);
            pieAdapter.ItemClick += PieAdapter_ItemClick;
            pieRecyclerView.SetAdapter(pieAdapter);

            return view;
        }

        private void PieAdapter_ItemClick(object sender, int e)
        {
            var intent = new Intent();
            intent.SetClass(this.Context, typeof(PieDetailActivity));
            intent.PutExtra("selectedPieId", e);
            StartActivity(intent);
        }
    }
}