using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ContatacaoHospedagem : ContentPage
    {
        public ContatacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }

        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            // Aqui você pode validar dados e navegar para a próxima etapa (ex.: Resumo/Confirmação)
            // Exemplo simples:
            if (pck_quarto.SelectedIndex < 0)
            {
                await DisplayAlert("Ops", "Selecione uma acomodação.", "OK");
                return;
            }
            if (dtpck_checkout.Date <= dtpck_checkin.Date)
            {
                await DisplayAlert("Ops", "O check-out deve ser após o check-in.", "OK");
                return;
            }

            await DisplayAlert("Tudo certo!", "Dados validados. Próxima etapa…", "OK");
            // Ex.: await Shell.Current.GoToAsync("resumo");
        }
    }
}
