using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestIconColorXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        static readonly Color[] Colors = new Color[] { Color.Red, Color.Aqua, Color.Yellow, Color.Green };

        public MainPage()
        {
            InitializeComponent();

            //ChangeColor();
        }

        async void ChangeColor()
        {
            int i = 0;
            do
            {
                if (i > 3)
                {
                    i = 0;
                }
                IconView.Foreground = Colors[i++];
                await Task.Delay(TimeSpan.FromMilliseconds(700));
            } while (true);
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            //tapCount++;
            //var imageSender = (Image)sender;
            //// watch the monkey go from color to black&white!
            //if (tapCount % 2 == 0)
            //{
            //    imageSender.Source = "tapped.jpg";
            //}
            //else
            //{
            //    imageSender.Source = "tapped_bw.jpg";
            //}
        }

        void Handle_Toggled(object sender,EventArgs e)
        {
            
        }
    }
}
