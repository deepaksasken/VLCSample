// RecyclerClickEvent.cs
// Created by Deepak Rao on 17-04-2019
// Copyright © 2018 Sasken. All rights reserved.
using System;
using Android.Views;

namespace VLCSample.Droid
{
    public class RecyclerClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}
