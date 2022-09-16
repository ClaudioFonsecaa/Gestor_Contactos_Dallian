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
    public partial class ftNomeF : ContentPage
    {
        public ftNomeF()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                FestivalCollectionView.ItemsSource = await App.MyDatabase.VerFestivais();
                
            }
            catch
            {

            }
        }

        async private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            FestivalCollectionView.ItemsSource = await App.MyDatabase.ProcurarFestivais(e.NewTextValue);
        }

        async void fechar(object sender, EventArgs e)
        {
            //função para fechar o modal
            await Navigation.PopModalAsync();
        }

        async private void ver(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var festival = item.CommandParameter as Festivais;
            string cat = festival.GetType().Name;

            await Navigation.PushModalAsync(new verConteudo(festival.Id, cat, festival));//MANDAR O ID E A CATEGORIA
        }

        async private void apagar(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var campo = item.CommandParameter as Festivais;
            var result = await DisplayAlert("Atenção", $"Apagar {campo.Name} da lista?", "Sim", "Não");
            if (result)
            {
                await App.MyDatabase.ApagarFestival(campo); //apagar o campo da tabela dos festivais
                FestivalCollectionView.ItemsSource = await App.MyDatabase.VerFestivais();//Atualizar lista com os dados da bd
            }
        }
    }
}