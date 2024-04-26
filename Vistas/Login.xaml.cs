namespace wcajisacaExamen.Vistas;

public partial class Login : ContentPage
{
    List<Users> usersList;

    public Login()
	{
		InitializeComponent();
        usersList = new List<Users>
            {
                new Users("estudiante2024", "uisrael2024"),
                new Users("examen1", "parcial1"),
                new Users("wilson", "2024"),
            };
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        bool isFound = false;

        foreach (Users user in usersList)
        {
            if (user.User == txtUsuario.Text && user.Password == txtContrasena.Text)
            {
                Navigation.PushAsync(new Vistas.Registro(user.User));
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            DisplayAlert("Alerta", "Alerta usuario y/o contraseña incorrectos", "Cerrar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.acerca());
    }
}