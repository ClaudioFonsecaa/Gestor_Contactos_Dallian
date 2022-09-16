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
    public partial class ftPaisP : ContentPage
    {
        public ftPaisP()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                PromotorPaisCollectionView.ItemsSource = await App.MyDatabase.VerPromotores();
            }
            catch
            {

            }
        }

        async private void pesquisa_pais_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = pesquisa_pais.SelectedIndex;

            if (selectedIndex > -1)
            {
                string pais = pesquisa_pais.Items[selectedIndex];//obter o pais selecionado

                PromotorPaisCollectionView.ItemsSource = await App.MyDatabase.ProcurarPaisPromotores(pais);//atualizar a informação
            }
            else
            {

                PromotorPaisCollectionView.ItemsSource = await App.MyDatabase.VerPromotores();
            }


        }

        async private void ImageButton_Clicked(object sender, EventArgs e)
        {
            pesquisa_pais.SelectedItem = null;
            PromotorPaisCollectionView.ItemsSource = await App.MyDatabase.VerPromotores();

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
                await App.MyDatabase.ApagarPromotor(campo); //apagar o campo da tabela dos festivais
                PromotorPaisCollectionView.ItemsSource = await App.MyDatabase.VerPromotores();//Atualizar lista com os dados da bd
            }
        }


    }
}