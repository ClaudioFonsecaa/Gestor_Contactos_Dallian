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
    public partial class AdicionarPage : ContentPage
    {
        public AdicionarPage()
        {
            InitializeComponent();
        }

        
        async void btFestivalClicked(object sender, EventArgs e)
        {
            //REDIRECIONAR PARA OUTRA PAGINA
            await Navigation.PushModalAsync(new AddFestival());

        }
        async void btPromotoraClicked(object sender, EventArgs e)
        {
            //REDIRECIONAR PARA OUTRA PAGINA
            await Navigation.PushModalAsync(new AddPromotora());

        }
        async void btLocalClicked(object sender, EventArgs e)
        {
            //REDIRECIONAR PARA OUTRA PAGINA
            await Navigation.PushModalAsync(new AddLocal());
        }


    }
}