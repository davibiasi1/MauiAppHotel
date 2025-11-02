using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }
        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // volta para a tela anterior
        }
    }
}
