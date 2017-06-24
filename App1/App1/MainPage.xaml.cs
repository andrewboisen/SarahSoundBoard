﻿using App1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonPlay_Clicked(object sender, EventArgs e)
        {
            var audioService = DependencyService.Get<IAudioService>();
            audioService.PlayAudio("dixie-horn_daniel-simion.mp3");
        }
    }
}
