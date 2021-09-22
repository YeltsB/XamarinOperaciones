using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Operaciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        
        public MenuPage()
        {
            InitializeComponent();
        }

        async void btnSuma_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNum1.Text) & !string.IsNullOrEmpty(txtNum2.Text))
            {
                var resultado = new ResultadoOperacionesPage();
                resultado.BindingContext = EnviarDatos("suma");
                await Navigation.PushAsync(resultado);
                Clean();
            }
            else
            {
                 await DisplayAlert("Notificación","No puede dejar campos vacíos","OK");
            }
       
        }

        async void btnResta_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNum1.Text) & !string.IsNullOrEmpty(txtNum2.Text))
            {
                var resultado = new ResultadoOperacionesPage();
                resultado.BindingContext = EnviarDatos("resta");
                await Navigation.PushAsync(resultado);
                Clean();

            }
            else
            {
                await DisplayAlert("Notificación", "No puede dejar campos vacíos", "OK");

            }

        }

        async void btnDivision_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNum1.Text) & !string.IsNullOrEmpty(txtNum2.Text))
            {
                var resultado = new ResultadoOperacionesPage();
                resultado.BindingContext = EnviarDatos("division");
                await Navigation.PushAsync(resultado);
                Clean();

            }
            else
            {
                await DisplayAlert("Notificación", "No puede dejar campos vacíos", "OK");

            }

        }

        async void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNum1.Text) & !string.IsNullOrEmpty(txtNum2.Text))
            {
                var resultado = new ResultadoOperacionesPage();
                resultado.BindingContext = EnviarDatos("multiplicacion");
                await Navigation.PushAsync(resultado);
                Clean();

            }
            else
            {
                await DisplayAlert("Notificación", "No puede dejar campos vacíos", "OK");

            }

        }


        public object EnviarDatos(string tipo)
        {

            Operador op = new Operador();
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
                
            switch (tipo)
            {
                case "suma":

                    op.Tipo = "suma";
                    op.Resultado = (num1 + num2).ToString();

                    break;
                case "resta":

                    op.Tipo = "resta";
                    op.Resultado = (num1 - num2).ToString();

                    break;
                case "multiplicacion":

                    op.Tipo = "multiplicación";
                    op.Resultado = (num1 * num2).ToString();

                    break;
                case "division":

                    op.Tipo = "división";
                    op.Resultado = (num1 / num2).ToString();

                    break;
                default:
                    break;
            }

            return op;
        }

        public void Clean()
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
        }

    }
}