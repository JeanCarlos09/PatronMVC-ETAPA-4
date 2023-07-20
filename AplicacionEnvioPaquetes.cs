using System;
// Clase principal que utiliza la aplicación
public class AplicacionEnvioPaquetes
{
    private ControladorUsuario controlador;

    public AplicacionEnvioPaquetes()
    {
        controlador = new ControladorUsuario();
    }

    public void Ejecutar()
    {
        controlador.RegistrarUsuario();
        controlador.IniciarSesion();
        controlador.EnviarPaquete();
        controlador.CerrarSesion();
    }
}
