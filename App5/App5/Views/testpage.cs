using MR.Gestures;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App5.Mobile.Pages
{
    public class testpage : Xamarin.Forms.ContentPage
    {
        public testpage()
        {
            var stacklayout = new MR.Gestures.StackLayout();
            stacklayout.VerticalOptions = LayoutOptions.FillAndExpand;

            for (int i = 0; i < 12; i++)
            { 
                var button = new Xamarin.Forms.Label();
                button.HeightRequest = 50;
                button.Text = i.ToString();
                button.BackgroundColor = Color.Red;
              
                stacklayout.Children.Add(button);

            }

            stacklayout.Panning += Stacklayout_Panning;

            Content = stacklayout;

        }

        private void Stacklayout_Panning(object sender, PanEventArgs e)
        {
        }
    }
}
