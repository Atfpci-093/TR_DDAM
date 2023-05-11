using DemoPizza1.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoPizza1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                TablaRegistro oRegistro = new TablaRegistro()
                {
                    T_Nombre = T_Nombre.Text,
                    T_Apellido = T_Apellido.Text,
                    T_Correo = T_Correo.Text,
                    T_Contraseña = T_Contraseña.Text,
                    T_NomUsuario = T_NomUsuario.Text,
                };
                await App.SQLiteDB.SaveRegistro(oRegistro);
                T_Nombre.Text = "";
                T_Apellido.Text = "";
                T_Correo.Text = "";
                T_Contraseña.Text = "";
                T_NomUsuario.Text = "";

                var ListaUsuarios = await App.SQLiteDB.ConsultarUsuario();
                if (ListaUsuarios != null)
                {
                    await DisplayAlert("Registro", "Usted se a registrado correctamente", "OK");
                }
            }
            else
            {
                await DisplayAlert("Advertencia", "Ingresar todos los campos", "OK");
            }
        }

        public bool ValidarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(T_Nombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(T_Apellido.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(T_Correo.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(T_Contraseña.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(T_NomUsuario.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoPizza1.Views.Login());
        }
    }
}