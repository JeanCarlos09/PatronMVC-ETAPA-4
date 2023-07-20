using System;
// Controlador: coordina la interacción entre el modelo y la vista
public class ControladorUsuario
{
    private Usuario usuarioActual;
    private VistaUsuario vista;

    // Constructor que inicializa el objeto de la vista del usuario.
    public ControladorUsuario()
    {
        vista = new VistaUsuario();
    }

    // Método para registrar un nuevo usuario mediante la interacción con la vista.
    public void RegistrarUsuario()
    {
        usuarioActual = vista.RegistrarUsuario();
        vista.MostrarMensaje("Usuario registrado con éxito.");
    }

    // Método para iniciar sesión mediante la interacción con la vista.
    public void IniciarSesion()
    {
        string correo = vista.IniciarSesion();

       // Verificar si el usuario actual es válido y si el correo coincide con el ingresado.
        if (usuarioActual != null && usuarioActual.Correo == correo)
        {
            vista.MostrarMensaje("Sesión iniciada con éxito.");
        }
        else
        {
            vista.MostrarMensaje("Credenciales de inicio de sesión inválidas.");
        }
    }

    // Método para cerrar la sesión del usuario actual.
    public void CerrarSesion()
    {
        usuarioActual = null;
        vista.MostrarMensaje("Sesión cerrada.");
    }

    // Método para enviar un paquete mediante la interacción con la vista.
    public void EnviarPaquete()
    {
        if (usuarioActual != null)
        {
            string desea = "si";
            string nodesea = "no";
            string Desea = "1";
            string Nodesea = "2";

            // Mostrar opciones al usuario.
            Console.WriteLine("Desea enviar paquete:");
            Console.WriteLine("1. si");
            Console.WriteLine("2. no");
            string propuesta = Console.ReadLine();

            // Verificar si el usuario desea enviar el paquete.
            if (propuesta == desea || propuesta == Desea){

            // Obtener detalles del destinatario y mostrar mensaje de envío exitoso.
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
