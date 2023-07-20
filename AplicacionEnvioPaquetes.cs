using System;
// Clase principal que utiliza la aplicación
public class AplicacionEnvioPaquetes
{
    private ControladorUsuario controlador;

    // Constructor que inicializa el objeto del controlador de usuario.
    public AplicacionEnvioPaquetes()
    {
        controlador = new ControladorUsuario();
    }

    // Método "Ejecutar" que realiza una secuencia de acciones relacionadas con el controlador de usuario.
    public void Ejecutar()
    {
        // Registrar un nuevo usuario.
        controlador.RegistrarUsuario();

        // Iniciar sesión para poder realizar acciones adicionales.
        controlador.IniciarSesion();

        // Envía un paquete (solo si el usuario ha iniciado sesión correctamente).
        controlador.EnviarPaquete();

        // Cierra la sesión del usuario actual.
        controlador.CerrarSesion();
    }
}
