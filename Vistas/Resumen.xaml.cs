using Microsoft.Win32;

namespace wcajisacaExamen.Vistas;

public partial class Resumen : ContentPage
{
	public Resumen(Datos datosUser)
	{
		InitializeComponent();
        txtNombre.Text = datosUser.Nombre;
        txtApellido.Text = datosUser.Apellido;
        txtEdad.Text = datosUser.Edad;
        txtFecha.Text = datosUser.Fecha;
        txtCiudad.Text = datosUser.Ciudad;
        txtPais.Text = datosUser.Pais;
        txtMInicial.Text = datosUser.MontoInicial;
        txtPMensual.Text = datosUser.PagoMensual;
        txtPTotal.Text = datosUser.PagoTotal.ToString();
    }

    private void btnCerrarS_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}