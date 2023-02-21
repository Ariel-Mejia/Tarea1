using Tarea1.Models;
using Tarea1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Tarea1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            var Numero1 = double.Parse(numero1.Text);
            var Numero2 = double.Parse(numero2.Text);
            var Btnsuma = Numero1 + Numero2;
            var funciones = new Models.FuncionesMate
            {
                numero1 = Btnsuma.ToString(),

            };
            var pagina = new Views.PageTwo();
            pagina.BindingContext = funciones;
            await Navigation.PushAsync(pagina);
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            var Numero1 = double.Parse(numero1.Text);
            var Numero2 = double.Parse(numero2.Text);
            var Btnresta = Numero1 - Numero2;
            var funciones = new Models.FuncionesMate
            {
                numero1 = Btnresta.ToString(),

            };
            var pagina = new Views.PageTwo();
            pagina.BindingContext = funciones;
            await Navigation.PushAsync(pagina);
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            var Numero1 = double.Parse(numero1.Text);
            var Numero2 = double.Parse(numero2.Text);
            var Btndivision = Numero1 / Numero2;
            var funciones = new Models.FuncionesMate
            {
                numero1 = Btndivision.ToString(),

            };
            var pagina = new Views.PageTwo();
            pagina.BindingContext = funciones;
            await Navigation.PushAsync(pagina);
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            var Numero1 = double.Parse(numero1.Text);
            var Numero2 = double.Parse(numero2.Text);
            var Btnmultiplicacion = Numero1 * Numero2;
            var funciones = new Models.FuncionesMate
            {
                numero1 = Btnmultiplicacion.ToString(),

            };
            var pagina = new Views.PageTwo();
            pagina.BindingContext = funciones;
            await Navigation.PushAsync(pagina);
        }
    }
}