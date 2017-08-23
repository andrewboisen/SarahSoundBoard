using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SoundBoard.Service;
using SoundBoard.iOS.Service;

[assembly: Xamarin.Forms.Dependency(typeof(AudioService))]

namespace SoundBoard.iOS.Service
{
    class AudioService : IAudioService
    {
        public void PlayAudio(string filename)
        {
            
        }
    }
}