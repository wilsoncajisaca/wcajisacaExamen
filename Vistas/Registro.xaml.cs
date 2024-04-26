namespace wcajisacaExamen.Vistas;

public partial class Registro : ContentPage
{
    double costo = 1500;
    int interes = 4;
    int cuotas = 4;
    bool isCalculado = false;
	public Registro(string user)
	{
		InitializeComponent();
		lblUserConected.Text = user;
	}

    private void txtPMensual_Focused(object sender, FocusEventArgs e)
    {
    }

    private void btnPMensual_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(txtMInicial.Text, out double mInicial))
        {
            if (mInicial >= 0 && mInicial <= 1500)
            {
                double cuotaSinInt = (costo - mInicial) / cuotas;
                double interesCal = (cuotaSinInt * interes) / 100;
                double cuotaConInteres = cuotaSinInt + interesCal;
                txtPMensual.Text = cuotaConInteres.ToString();
                isCalculado = true;
            }
            else
            {
                DisplayAlert("Error", "Ingrese un valor entre 0 y 1500", "Cerrar");
            }
        }
        else
        {
            DisplayAlert("Alerta", "Por favor, ingrese un número válido.", "Cerrar");
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        if (isCalculado)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEdad.Text))
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }
            else 
            {
                Datos datosUser = this.datosUser();
                Navigation.PushAsync(new Vistas.Resumen(datosUser));
            }
        }
        else 
        {
            DisplayAlert("Alerta", "Por favor, precione primero calcular cuota", "Cerrar");
        }

    }

    private Datos datosUser() 
    {
        double mInicial = double.Parse(txtMInicial.Text);
        double mCuotaTotal = double.Parse(txtPMensual.Text) * cuotas;
        Datos datosUser = new Datos();
        datosUser.Nombre = txtNombre.Text;
        datosUser.Apellido = txtApellido.Text;
        datosUser.Edad = txtEdad.Text;
        datosUser.Fecha = dpFecha.Date.ToString("MM/dd/yyyy");
        datosUser.Ciudad = pkCuidad.Items[pkCuidad.SelectedIndex].ToString();
        datosUser.Pais = pkPaises.Items[pkPaises.SelectedIndex].ToString();
        datosUser.PagoMensual = txtPMensual.Text;
        datosUser.MontoInicial = txtMInicial.Text;
        datosUser.PagoTotal = mInicial + mCuotaTotal;
        return datosUser;
    }
}