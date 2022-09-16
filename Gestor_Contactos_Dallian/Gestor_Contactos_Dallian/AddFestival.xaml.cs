using Gestor_Contactos_Dallian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestor_Contactos_Dallian.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gestor_Contactos_Dallian
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFestival : ContentPage
    {
        public AddFestival()
        {
            InitializeComponent();
        }

        async private void adicionar(object sender, EventArgs e)
        {


            //SABER O INDEX SELECIONADO
            int selectedIndex = etPais.SelectedIndex;


            //VERIFICAR SE OS CAMPOS NAO ESTAO VAZIOS
            if (string.IsNullOrWhiteSpace(etName.Text) || selectedIndex<0
                || string.IsNullOrWhiteSpace(etMorada.Text) || string.IsNullOrWhiteSpace(etContacto.Text) || string.IsNullOrWhiteSpace(etResponsavel.Text))
            {
                await DisplayAlert("Erro", "Preencha todos os campos pff!", "OK");
            
            }else{

                


                //ADICIONAR FESTIVAL
                await App.MyDatabase.AdicionarFestival(new Model.Festivais
                {
                    Name = etName.Text,
                    Pais = etPais.Items[selectedIndex],
                    //Pais_Clean = etPais.
                    Morada = etMorada.Text,
                    Contacto = etContacto.Text,
                    Responsavel = etResponsavel.Text
                });

                //await DisplayAlert("Sucesso", $"{selectedIndex}", "OK");
                await DisplayAlert("Sucesso", "Festival adicionado com sucesso!", "OK");

                await Navigation.PopModalAsync();
            }

        }

        private void apagar(object sender, EventArgs e)
        {
            //etName., etPais etMorada etContacto etResponsavel
            etName.Text = null;
            etMorada.Text = null;
            etContacto.Text = null;
            etResponsavel.Text = null;
            etPais.SelectedItem = null;

        }

        async void fechar(object sender, EventArgs e)
        {
            //função para fechar o modal
            await Navigation.PopModalAsync();
        }
    }
}