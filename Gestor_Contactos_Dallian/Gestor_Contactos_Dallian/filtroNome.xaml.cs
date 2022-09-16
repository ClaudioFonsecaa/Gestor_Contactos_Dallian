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
    public partial class filtroNome : ContentPage
    {
        public filtroNome()
        {
            InitializeComponent();
        }

        async private void ftNomeFestival(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ftNomeF());
        }

        async private void ftNomePromotora(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ftNomeP());
        }

        async private void ftNomeLocal(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ftNomeL());
        }

        async void fechar(object sender, EventArgs e)
        {
            //função para fechar o modal
            await Navigation.PopModalAsync();
        }

    }
}