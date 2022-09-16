using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XlsIO;
using System.IO;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;
using Color = Syncfusion.Drawing.Color;
using Gestor_Contactos_Dallian.Model;
using System.Xml.Linq;
using System.Diagnostics;
using System.Drawing;
using Xamarin.Essentials;
using Xamarin.Forms.PlatformConfiguration;

namespace Gestor_Contactos_Dallian
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProcurarPage : ContentPage
    {


        

        public ProcurarPage()
        {
            InitializeComponent();

            

        }

        async void ftNome(object sender, EventArgs e)
        {
            //REDIRECIONAR PARA OUTRA PAGINA
            await Navigation.PushModalAsync(new filtroNome());

        }

        async void ftPais(object sender, EventArgs e)
        {
            //REDIRECIONAR PARA OUTRA PAGINA
            await Navigation.PushModalAsync(new filtroPais());

        }

        private async void extrair(object sender, EventArgs e)
        {

            try
            {

                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BD_Dallian_GestorContactos.db3");
                var bytes = File.ReadAllBytes(path);
                var fileCopyName = string.Format("/sdcard/Download/Database_{0:dd-MM-yyyy_HH-mm-ss-tt}.db", DateTime.Now);
                File.WriteAllBytes(fileCopyName, bytes);

                var result = true;

                result = await DisplayAlert("Sucesso", "Base de dados guardada na pasta Download's! \nPara fazer a conversão para Excel por favor visite: \n\nhttps://www.rebasedata.com/convert-sqlite-to-excel-online \n\n Deseja ser redirecionado?", "Sim", "Não");

                if (result) {
                    string uri = "https://www.rebasedata.com/convert-sqlite-to-excel-online";
                    await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
                }
                

            }
            catch (Exception)
            {

                await DisplayAlert("Erro","Erro ao extrair a base de dados :(","OK");
            }


            


            

        }

        




    }
}