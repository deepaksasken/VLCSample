// TabBarController.cs
// Created by Deepak Rao on 17-04-2019
// Copyright © 2018 Sasken. All rights reserved.
using System;
using UIKit;

namespace VLCSample.iOS
{
    public partial class TabBarController : UITabBarController
    {
        public TabBarController(IntPtr handle) : base(handle)
        {
            TabBar.Items[0].Title = "Browse";
            TabBar.Items[1].Title = "About";
        }
    }
}
