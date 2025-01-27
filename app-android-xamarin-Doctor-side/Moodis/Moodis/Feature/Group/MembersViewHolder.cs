﻿using System;
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

namespace Moodis.Feature.Group
{
    class MembersViewHolder : RecyclerView.ViewHolder
    {
        public TextView GroupMemberLabel { get; set; }
        public MembersViewHolder(View view) : base(view)
        {
            GroupMemberLabel = view.FindViewById<TextView>(Resource.Id.memberLabel);
        }
    }
}