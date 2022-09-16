using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gestor_Contactos_Dallian
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class filtroPais : ContentPage
    {
        public filtroPais()
        {
            InitializeComponent();
        }

        async private void ftPaisFestival(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ftPaisF());
        }

        async private void ftPaisPromotora(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ftPaisP());
        }

        async private void ftPaisLocal(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ftPaisL());
        }

        async void fechar(object sender, EventArgs e)
        {
            //função para fechar o modal
            await Navigation.PopModalAsync();
        }

    }
}