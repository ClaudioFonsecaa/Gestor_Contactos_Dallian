using Gestor_Contactos_Dallian.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static SQLite.SQLite3;

namespace Gestor_Contactos_Dallian
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class verConteudo : ContentPage
    {

        //variaveis gerais
        string categoria;
        int id;

        Model.Festivais festival;
        Model.Locais local;
        Model.Promotores promotor;


        public verConteudo()
        {
            InitializeComponent();    

        }

        
        protected override async void OnAppearing()
        {

            BindingContext = this;

            try
            {
                base.OnAppearing();//Atualizar os dados da base de dados com o ID
                

                switch (categoria)
                {
                    case "Festivais":

                        
                        DataView.ItemsSource = await App.MyDatabase.ProcurarIDFestivais(id);//Dados atualizados
                        


                        break;
                    case "Locais":



                        DataView.ItemsSource = await App.MyDatabase.ProcurarIDLocais(id);//Dados atualizados



                        break;
                    case "Promotores":


                        DataView.ItemsSource = await App.MyDatabase.ProcurarIDPromotores(id);//Dados atualizados


                        break;

                }


            }
            catch
            {

            }
        }

        public verConteudo(int identificador, string cat, object modelo)//RECEBER O ID E A CATEGORIA
        {
            InitializeComponent();

            id = identificador;
            categoria = cat;

            switch (categoria)
            {
                case "Festivais":
                    festival = modelo as Festivais;
                    break;
                case "Locais":
                    local = modelo as Locais;
                    break;
                case "Promotores":
                    promotor = modelo as Promotores;
                    break;

            } 
        }

        async void fechar(object sender, EventArgs e)
        {
            //função para fechar o modal
            await Navigation.PopModalAsync();
        }

        async private void apagar(object sender, EventArgs e)
        {

            var result = true;

            switch (categoria)
            {
                case "Festivais":
                    

                    result = await DisplayAlert("Atenção", $"Apagar {festival.Name} da lista?", "Sim", "Não");
                    if (result)
                    {
                        await App.MyDatabase.ApagarFestival(festival); //apagar o campo da tabela dos festivais
                        //fechar modal
                        await Navigation.PopModalAsync();
                    }

                    break;
                case "Locais":


                    result = await DisplayAlert("Atenção", $"Apagar {local.Name} da lista?", "Sim", "Não");
                    if (result)
                    {
                        await App.MyDatabase.ApagarLocal(local); //apagar o campo da tabela dos festivais
                        //fechar modal
                        await Navigation.PopModalAsync();
                    }


                    break;
                case "Promotores":


                    result = await DisplayAlert("Atenção", $"Apagar {promotor.Name} da lista?", "Sim", "Não");
                    if (result)
                    {
                        await App.MyDatabase.ApagarPromotor(promotor); //apagar o campo da tabela dos festivais
                        //fechar modal
                        await Navigation.PopModalAsync();
                    }

                    break;

            }

        }

        async private void editar(object sender, EventArgs e)
        {


            switch (categoria)
            {
                case "Festivais":

                    await Navigation.PushModalAsync(new editarConteudo(id, categoria, festival));

                    break;
                case "Locais":


                    await Navigation.PushModalAsync(new editarConteudo(id, categoria, local));

                    break;
                case "Promotores":

                    await Navigation.PushModalAsync(new editarConteudo(id, categoria, promotor));

                    break;

            }


            

        }

        private void redirecionar_contacto(object sender, EventArgs e)
        {

            
                switch (categoria)
                {
                    case "Festivais":

                        PhoneDialer.Open(festival.Contacto);

                        break;
                    case "Locais":


                        PhoneDialer.Open(local.Contacto);

                        break;
                    case "Promotores":

                        PhoneDialer.Open(promotor.Contacto);

                        break;

                }

   
            
        }

        private async void redirecionar_mapa(object sender, EventArgs e)
        {
           
               

            switch (categoria)
            {
                case "Festivais":

                    // open the maps app directly
                    await Launcher.OpenAsync($"geo:0,0?q={festival.Morada}");

                    break;
                case "Locais":


                    // open the maps app directly
                    await Launcher.OpenAsync($"geo:0,0?q={local.Morada}");

                    break;
                case "Promotores":

                    // open the maps app directly
                    await Launcher.OpenAsync($"geo:0,0?q={promotor.Morada}");

                    break;

            }

        }
    }
}