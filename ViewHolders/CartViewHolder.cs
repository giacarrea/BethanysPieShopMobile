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

namespace BethanysPieShopMobile.ViewHolders
{
    public class CartViewHolder : RecyclerView.ViewHolder
    {

        public ImageView PieImageView { get; set; }
        public TextView PieNameTextView { get; set; }
        public TextView PieAmountTextView { get; set; }

        public CartViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            PieImageView = itemView.FindViewById<ImageView>(Resource.Id.pieImageView);
            PieNameTextView = itemView.FindViewById<TextView>(Resource.Id.pieNameTextView);
            PieAmountTextView = itemView.FindViewById<TextView>(Resource.Id.pieAmountTextView);

            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}