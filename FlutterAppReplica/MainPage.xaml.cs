using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlutterAppReplica
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            Animate();
            
        }
        public async void Animate()
        {
            
            FirstLight.FadeTo(0, 0);
            SecondLight.FadeTo(0, 0);
            LoginLabel.FadeTo(0, 0);
            MainButton.FadeTo(0, 0);
            MainLabel.FadeTo(0, 0);
            MAinFrame.FadeTo(0.0);
            FirstLight.TranslationY = -180;
            SecondLight.TranslationY = -160;
            Clock.TranslationY = -80;
            MainLabel.TranslationY = -30;
            MainButton.TranslationY = -30;
            MAinFrame.TranslationY = -30;
            await Clock.FadeTo(0, 0);
            Task.Delay(1000);
            
            FirstLight.FadeTo(1, 500);
            await FirstLight.TranslateTo(0, 0, 300);
            LoginLabel.FadeTo(1, 900);
            SecondLight.FadeTo(1, 500);
            await SecondLight.TranslateTo(0, 0, 300);
            
            Clock.FadeTo(1, 500);
            await Clock.TranslateTo(0, 0, 300);
            MAinFrame.FadeTo(1, 500);
            await MAinFrame.TranslateTo(0, 0, 300);
            MainButton.FadeTo(1, 500);
            await MainButton.TranslateTo(0,0, 300);
            MainLabel.FadeTo(1, 500);
            await MainLabel.TranslateTo(0,0, 300);
            
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Animate();
        }
    }
}
