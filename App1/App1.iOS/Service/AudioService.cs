using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using App1.Service;
using App1.iOS.Service;

[assembly: Xamarin.Forms.Dependency(typeof(AudioService))]

namespace App1.iOS.Service
{
    class AudioService : IAudioService
    {
        public void PlayAudio(string filename)
        {
            
        }
    }
}