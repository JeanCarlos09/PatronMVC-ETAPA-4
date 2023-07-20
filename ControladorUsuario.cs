using System;
// Controlador: coordina la interacción entre el modelo y la vista
public class ControladorUsuario
{
    private Usuario usuarioActual;
    private VistaUsuario vista;

    public ControladorUsuario()
    {
        vista = new VistaUsuario();
    }

    public void RegistrarUsuario()
    {
        usuarioActual = vista.RegistrarUsuario();
        vista.MostrarMensaje("Usuario registrado con éxito.");
    }

    public void IniciarSesion()
    {
        string correo = vista.IniciarSesion();

        // Validar las credenciales de inicio de sesión
        if (usuarioActual != null && usuarioActual.Correo == correo)
        {
            vista.MostrarMensaje("Sesión iniciada con éxito.");
        }
        else
        {
            vista.MostrarMensaje("Credenciales de inicio de sesión inválidas.");
        }
    }

    public void CerrarSesion()
    {
        usuarioActual = null;
        vista.MostrarMensaje("Sesión cerrada.");
    }

    public void EnviarPaquete()
    {
        if (usuarioActual != null)
        {
            string desea = "si";
            string nodesea = "no";
            string Desea = "1";
            string Nodesea = "2";
            Console.WriteLine("Desea enviar paquete:");
            Console.WriteLine("1. si");
            Console.WriteLine("2. no");
            string propuesta = Console.ReadLine();
            if (propuesta == desea || propuesta == Desea){
            Console.WriteLine("Enviar paquete a : ");
            Console.WriteLine("Ingrese el nombre del destinatario");
            string nombreDestinatario = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del destinatario");
            string direccionDestinatario = Console.ReadLine();
            Console.WriteLine("Envío exitoso");
        }
          }
        else
        {
            vista.MostrarMensaje("Debe iniciar sesión para utilizar esta función.");
        }
    }
}
