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

namespace BethanysPieShopMobile.ViewHolders
{
    public class PieViewHolder : RecyclerView.ViewHolder
    {
        public ImageView PieImageView { get; set; }
        public TextView PieNameTextView { get; set; }

        public PieViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            PieImageView = itemView.FindViewById<ImageView>(Resource.Id.pieImageView);
            PieNameTextView = itemView.FindViewById<TextView>(Resource.Id.pieNameTextView);

            itemView.Click += (sender, e) => listener(base.LayoutPosition);

        }
    }
}