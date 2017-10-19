using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToastMessage.InterfaceHelper;
using Xamarin.Forms;

namespace ToastMessage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IMessage>().LongAlert("Success");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DependencyService.Get<IMessage>().ShortAlert("Failed");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
           string color= await DisplayActionSheet("Choose background Color", "Cancel", "Destruct", "Navy", "Green", "Grey");
            if (color == "Navy")
            {
                BackgroundColor = Color.Navy;
            }
            if (color == "Grey")
            {
                BackgroundColor = Color.Gray;

            }
            if (color == "Green")
            {
                BackgroundColor = Color.Green;
            }


        }

        private async void startButton_Clicked(object sender, EventArgs e)
        {
           
            await image.RotateTo(760, 2000);
            image.Rotation = 0;
        }

        private  void cancelButton_Clicked(object sender, EventArgs e)
        {
             ViewExtensions.CancelAnimations(image);
        }
    }
}
