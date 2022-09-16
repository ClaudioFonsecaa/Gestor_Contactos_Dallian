using Gestor_Contactos_Dallian.Model;
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
    public partial class ftNomeP : ContentPage
    {
        public ftNomeP()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                PromotorCollectionView.ItemsSource = await App.MyDatabase.VerPromotores();
            }
            catch
            {

            }
        }

        async private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            PromotorCollectionView.ItemsSource = await App.MyDatabase.ProcurarPromotores(e.NewTextValue);
        }

        async void fechar(object sender, EventArgs e)
        {
            //função para fechar o modal
            await Navigation.PopModalAsync();
        }

        async private void ver(object sender, EventArgs e)
        {

            var item = sender as SwipeItem;
            var promotor = item.CommandParameter as Promotores;
            string cat = promotor.GetType().Name;

            await Navigation.PushModalAsync(new verConteudo(promotor.Id, cat, promotor));//MANDAR O ID E A CATEGORIA


        }

        async private void apagar(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var campo = item.CommandParameter as Promotores;
            var result = await DisplayAlert("Atenção", $"Apagar {campo.Name} da lista?", "Sim", "Não");
            if (result)
            {
                await App.MyDatabase.ApagarPromotor(campo); //apagar o campo da tabela 
                PromotorCollectionView.ItemsSource = await App.MyDatabase.VerPromotores();//Atualizar lista com os dados da bd
            }
        }

    }
}