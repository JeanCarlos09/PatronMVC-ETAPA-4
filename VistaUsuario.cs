using System;

// Vista: se encarga de la interacción con el usuario
public class VistaUsuario
{
    public Usuario RegistrarUsuario()
    {
        Console.WriteLine("----- Registro de Usuario -----");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su cédula: ");
        string cedula = Console.ReadLine();

        Console.Write("Ingrese su número de celular: ");
        string celular = Console.ReadLine();

        Console.Write("Ingrese su correo electrónico: ");
        string correo = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contrasena = Console.ReadLine();

        return new Usuario
        {
            Nombre = nombre,
            Edad = edad,
            Cedula = cedula,
            Celular = celular,
            Correo = correo,
            Contrasena = contrasena
        };
    }

    public string IniciarSesion()
    {
        Console.WriteLine("----- Inicio de Sesión -----");
        Console.Write("Ingrese su correo electrónico: ");
        string correo = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contrasena = Console.ReadLine();

        return correo;
    }

    public void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}
