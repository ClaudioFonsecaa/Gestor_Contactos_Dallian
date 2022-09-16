using Gestor_Contactos_Dallian.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static SQLite.SQLite3;

namespace Gestor_Contactos_Dallian
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class editarConteudo : ContentPage
    {

       
        int id;
        string cat;
        Model.Festivais festival;
        Model.Locais local;
        Model.Promotores promotor;
        public editarConteudo()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {


            try
            {
                base.OnAppearing();//Atualizar os dados do campo dependedo da categoria


                switch (cat)
                {
                    case "Festivais":

                        db_nomeET.Text = festival.Name;
                        db_moradaET.Text = festival.Morada;
                        db_contactoET.Text = festival.Contacto;
                        db_paisET.Title = festival.Pais; 
                        db_responsavelET.Text = festival.Responsavel;


                        break;
                    case "Locais":


                        db_nomeET.Text = local.Name;
                        db_moradaET.Text = local.Morada;
                        db_contactoET.Text = local.Contacto;
                        db_paisET.Title = local.Pais;
                        db_responsavelET.Text = local.Responsavel;





                        break;
                    case "Promotores":


                        db_nomeET.Text = promotor.Name;
                        db_moradaET.Text = promotor.Morada;
                        db_contactoET.Text = promotor.Contacto;
                        db_paisET.Title = promotor.Pais;
                        db_responsavelET.Text = promotor.Responsavel;


                        break;

                }


            }
            catch
            {

            }
        }



        public editarConteudo(int identificador, string categoria, object modelo) {

            InitializeComponent();

            id = identificador;
            cat = categoria;

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

        async void concluido(object sender, EventArgs e)
        {


            int selectedindex=db_paisET.SelectedIndex;


            //SE OS CAMPOS NESTIVEREM VAZIOS
            if (string.IsNullOrWhiteSpace(db_nomeET.Text) || string.IsNullOrWhiteSpace(db_moradaET.Text) || string.IsNullOrWhiteSpace(db_contactoET.Text) || string.IsNullOrWhiteSpace(db_responsavelET.Text))
            {


                await DisplayAlert("Erro", "Preencha todos os campos pff!", "OK");


            }else
            {

                //só se o index for escolhido é que altera
                if (selectedindex >= 0)
                {

                    switch (cat)
                    {
                        case "Festivais":
                           festival.Pais = db_paisET.Items[selectedindex];
                            break;
                        case "Locais":
                            local.Pais = db_paisET.Items[selectedindex];
                            break;
                        case "Promotores":
                            promotor.Pais = db_paisET.Items[selectedindex];
                            break;

                    }

                    
                }


                switch (cat)
                {
                    case "Festivais":

                        //atualizar o modelo festival com os dados das labels introduzidas
                        festival.Name = db_nomeET.Text;
                        festival.Morada = db_moradaET.Text;
                        festival.Contacto = db_contactoET.Text;
                        festival.Responsavel = db_responsavelET.Text;
                        await App.MyDatabase.atualizarFestival(festival);
                        await Navigation.PopModalAsync();


                        break;
                    case "Locais":

                        //atualizar o modelo festival com os dados das labels introduzidas
                        local.Name = db_nomeET.Text;
                        local.Morada = db_moradaET.Text;
                        local.Contacto = db_contactoET.Text;
                        local.Responsavel = db_responsavelET.Text;
                        await App.MyDatabase.atualizarLocal(local);
                        await Navigation.PopModalAsync();


                        break;
                    case "Promotores":

                        //atualizar o modelo festival com os dados das labels introduzidas
                        promotor.Name = db_nomeET.Text;
                        promotor.Morada = db_moradaET.Text;
                        promotor.Contacto = db_contactoET.Text;
                        promotor.Responsavel = db_responsavelET.Text;
                        await App.MyDatabase.atualizarPromotor(promotor);
                        await Navigation.PopModalAsync();

                        break;

                }


               



            }


             

        }

    }
}