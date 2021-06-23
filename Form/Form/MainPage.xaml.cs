using Form.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Form
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void button_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(nombre.Text) && !String.IsNullOrWhiteSpace(apellido.Text) && !String.IsNullOrWhiteSpace(edad.Text) && !String.IsNullOrWhiteSpace(correo.Text))
            {
                var persona = new Persona
                {
                    Name = nombre.Text,
                    LastName = apellido.Text,
                    Age = Convert.ToInt32(edad.Text),
                    Email = correo.Text

                };

                var pag = new Segunda();
                pag.BindingContext = persona;
                await Navigation.PushAsync(pag);

            }
            else
            {
                await DisplayAlert("Advertencia", "Llenar todos los campos", "Cerrar");
            }
        }
    }
}
