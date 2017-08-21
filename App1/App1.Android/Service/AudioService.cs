using Android.Media;
using App1.Droid.Service;
using App1.Service;

[assembly: Xamarin.Forms.Dependency(typeof(AudioService))]

namespace App1.Droid.Service
{
    internal class AudioService : IAudioService
    {

        public void PlayAudio(string filename)
        {
            var player = new MediaPlayer();
            var fileDescriptor = Xamarin.Forms.Forms.Context.Assets.OpenFd(filename);

            player.Prepared += (s, e) =>
            {
                player.Start();
            };

            player.Completion += (s, e) =>
            {
                player.Release();
            };

            player.SetDataSource(fileDescriptor.FileDescriptor, fileDescriptor.StartOffset, fileDescriptor.Length);
            player.Prepare();
        }
    }
}