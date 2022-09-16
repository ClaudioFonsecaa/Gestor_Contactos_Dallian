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
    public partial class ftNomeL : ContentPage
    {
        public ftNomeL()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                LocalCollectionView.ItemsSource = await App.MyDatabase.VerLocais();
            }
            catch
            {

            }
        }

        async private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            LocalCollectionView.ItemsSource = await App.MyDatabase.ProcurarLocais(e.NewTextValue);
        }

        async void fechar(object sender, EventArgs e)
        {
            //função para fechar o modal
            await Navigation.PopModalAsync();
        }

        async private void ver(object sender, EventArgs e)
        {

            var item = sender as SwipeItem;
            var local = item.CommandParameter as Locais;
            string cat = local.GetType().Name;

            await Navigation.PushModalAsync(new verConteudo(local.Id, cat, local));//MANDAR O ID E A CATEGORIA

        }

        async private void apagar(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var campo = item.CommandParameter as Locais;
            var result = await DisplayAlert("Atenção", $"Apagar {campo.Name} da lista?", "Sim", "Não");
            if (result)
            {
                await App.MyDatabase.ApagarLocal(campo); //apagar o campo da tabela 
                LocalCollectionView.ItemsSource = await App.MyDatabase.VerLocais();//Atualizar lista com os dados da bd
            }
        }

    }
}