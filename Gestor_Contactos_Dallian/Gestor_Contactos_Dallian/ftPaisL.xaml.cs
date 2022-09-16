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
    public partial class ftPaisL : ContentPage
    {
        public ftPaisL()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                LocalPaisCollectionView.ItemsSource = await App.MyDatabase.VerLocais();
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

                LocalPaisCollectionView.ItemsSource = await App.MyDatabase.ProcurarPaisLocais(pais);//atualizar a informação
            }
            else
            {

                LocalPaisCollectionView.ItemsSource = await App.MyDatabase.VerLocais();
            }


        }

        async private void ImageButton_Clicked(object sender, EventArgs e)
        {
            pesquisa_pais.SelectedItem = null;
            LocalPaisCollectionView.ItemsSource = await App.MyDatabase.VerLocais();

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
                await App.MyDatabase.ApagarLocal(campo); //apagar o campo da tabela dos festivais
                LocalPaisCollectionView.ItemsSource = await App.MyDatabase.VerLocais();//Atualizar lista com os dados da bd
            }
        }


    }
}