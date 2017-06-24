using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1.Service;
using App1.Droid.Service;
using Android.Media;

[assembly: Xamarin.Forms.Dependency(typeof(AudioService))]
namespace App1.Droid.Service
{
    class AudioService : IAudioService
    {
        public void PlayAudio(string filename)
        {
            var player = new MediaPlayer();
            var fd = Xamarin.Forms.Forms.Context.Assets.OpenFd(filename);
            player.Prepared += (s, e) =>
            {
                player.Start();
            };
            player.SetDataSource(fd.FileDescriptor);
            player.Prepare();
        }
    }
}