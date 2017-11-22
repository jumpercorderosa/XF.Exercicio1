using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercicio1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigPage : ContentPage
    {
        //Entry dados;
        //dados.BindingContext = txtEmail;

        //string email;
        //bool flag_email;

        public ConfigPage()
        {
            InitializeComponent();
        }

        private void scEmail_Switched(object sender, EventArgs e)
        {
            if (scEmail.On)
            {
                txtEmail.IsEnabled = true;
                //flag_email = true;
            }
            else
            {
                txtEmail.IsEnabled = false;
                //flag_email = email;
            }
        }

        private void txtEmail_Completed(object sender, EventArgs e)
        {
            //email = txtEmail.Text;
        }
    }
}