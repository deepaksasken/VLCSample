// AboutViewController.cs
// Created by Deepak Rao on 17-04-2019
// Copyright © 2018 Sasken. All rights reserved.
using System;
using LibVLCSharp.Platforms.iOS;
using LibVLCSharp.Shared;
using UIKit;


namespace VLCSample.iOS
{
    public partial class AboutViewController : UIViewController
    {
        VideoView _videoView;
        LibVLC _libVLC;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer;

        public AboutViewModel ViewModel { get; set; }
        public AboutViewController(IntPtr handle) : base(handle)
        {
            ViewModel = new AboutViewModel();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = ViewModel.Title;

            AppNameLabel.Text = "VLCSample";
            VersionLabel.Text = "1.0";
            AboutTextView.Text = "This app is written in C# and native APIs using the Xamarin Platform. It shares code with its iOS, Android, & Windows versions.";

           
            _libVLC = new LibVLC();
            _mediaPlayer = new LibVLCSharp.Shared.MediaPlayer(_libVLC);

            _videoView = new VideoView { MediaPlayer = _mediaPlayer };

            View = _videoView;

            _videoView.MediaPlayer.Play(new Media(_libVLC, "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4", FromType.FromLocation));
        }

        partial void ReadMoreButton_TouchUpInside(UIButton sender) => ViewModel.OpenWebCommand.Execute(null);
    }
}
