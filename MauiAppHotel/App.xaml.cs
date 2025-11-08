
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDirariaAdulto = 110.0,
                ValorDirariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDirariaAdulto = 80.0,
                ValorDirariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suite Single",
                ValorDirariaAdulto = 50.0,
                ValorDirariaCrianca = 25.0
            },
            new Quarto()
            {
                Descricao = "Suite Crise",
                ValorDirariaAdulto = 25.0,
                ValorDirariaCrianca = 12.5
            }

        };


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContatacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;


            return window;
        }

    }
}
