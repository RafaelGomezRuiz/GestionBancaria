public class OperacionRealizada{

    private Operacion operacion;

    public OperacionRealizada()
    {
        operacion = Operacion.getOperacion();
    }

    public static void GuardarOperacion(string? mensaje){
        Operacion operacion = Operacion.getOperacion();
        operacion.ActualizarUsuario=mensaje;
        GuardarJson.GuardarHistorial(operacion);
    }
    
}