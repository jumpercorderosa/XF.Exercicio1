using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Exercicio1.Models;

namespace Exercicio1
{
    public partial class MainPage : ContentPage
    {
        Dados dadosModel;

        public MainPage()
        {
            InitializeComponent();

            if (dadosModel == null) {
                dadosModel = new Dados();
            }
        }

        private void btnConfig_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage { BindingContext = dadosModel });
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (dadosModel.FlagEmail)
            {
                DisplayAlert("Mensagem", "E-mail enviado para {dadosModel.Email}", "Ok");
            }
            else {
                DisplayAlert("Mensagem", "Email não autorizado", "Ok");
            }
        }


    }
}
