using Microsoft.Maui.Controls;

namespace AccuTrackDefault
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            frame1.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => HandleCardClicked(1)) });
            frame2.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => HandleCardClicked(2)) });
            frame3.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => HandleCardClicked(3)) });
            frame4.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => HandleCardClicked(4)) });
            frame5.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => HandleCardClicked(5)) });
            frame6.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => HandleCardClicked(6)) });
        }

        void HandleCardClicked(int cardNumber)
        {
            // Hacer algo cuando se hace clic en una tarjeta
            DisplayAlert("Card Clicked", $"Clicked on card {cardNumber}", "OK");
        }

    }

}
