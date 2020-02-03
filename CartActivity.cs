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
    [Activity(Label = "CartActivity")]
    public class CartActivity : Activity
    {
        private RecyclerView _cartRecyclerView;
        private RecyclerView.LayoutManager _cartLayoutManager;
        private ShoppingCartAdapter _shoppingCartAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cart);


            // Create your application here
            _cartRecyclerView = FindViewById<RecyclerView>(Resource.Id.cartRecyclerView);
            _cartLayoutManager = new LinearLayoutManager(this);
            _cartRecyclerView.SetLayoutManager(_cartLayoutManager);
            _shoppingCartAdapter = new ShoppingCartAdapter();
            _cartRecyclerView.SetAdapter(_shoppingCartAdapter);

        }
    }
}