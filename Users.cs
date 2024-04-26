namespace wcajisacaExamen
{
    public class Users
    {
        public string User { get; set; }
        public string Password { get; set; }
        public Users(string usuario, string contrasena)
        {
            User = usuario;
            Password = contrasena;
        }
    }
}
