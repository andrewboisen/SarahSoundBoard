using SoundBoard.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SoundBoard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonBeepBeep_Clicked(object sender, EventArgs e)
        {
            var audioService = DependencyService.Get<IAudioService>();
            audioService.PlayAudio("beepbeep.mp3");
        }

        private void ButtonBigBurn_Clicked(object sender, EventArgs e)
        {
            var audioService = DependencyService.Get<IAudioService>();
            audioService.PlayAudio("bigburn.mp3");
        }

        private void ButtonDuhDah_Clicked(object sender, EventArgs e)
        {
            var audioService = DependencyService.Get<IAudioService>();
            audioService.PlayAudio("duhdah.mp3");
        }

        private void ButtonMeMe_Clicked(object sender, EventArgs e)
        {
            var audioService = DependencyService.Get<IAudioService>();
            audioService.PlayAudio("meme.mp3");
        }

        private void ButtonOhlalaa_Clicked(object sender, EventArgs e)
        {
            var audioService = DependencyService.Get<IAudioService>();
            audioService.PlayAudio("ohlalaa.mp3");
        }

        private void ButtonQuack_Clicked(object sender, EventArgs e)
        {
            var audioService = DependencyService.Get<IAudioService>();
            audioService.PlayAudio("quack.mp3");
        }
    }
}
