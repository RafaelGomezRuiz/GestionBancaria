using Newtonsoft.Json;

public class GuardarJson{

    public static List<Usuario> usuariosActualesJson=LeerJson.LeerUsuario();

    public static void GuardarUsuarioActualizado(List<Usuario> usuarios){
        
        string? usuarioJsonActualizado=JsonConvert.SerializeObject(usuarios, Formatting.Indented);
        File.WriteAllText(LeerJson.rutaUsuarios,usuarioJsonActualizado);
    }
    public static void GuardarCuentaActualizada(List<Usuario> listaUsuarios){
        if (listaUsuarios != null)
        {
            string? cuentaJsonActualizada=JsonConvert.SerializeObject(listaUsuarios, Formatting.Indented);
            File.WriteAllText(LeerJson.rutaUsuarios,cuentaJsonActualizada);
        
        }
        else
        {
            System.Console.WriteLine("Error: La lista de usuarios es null al intentar guardar la cuenta actualizada.");
        }
    }
    public static void GuardarHistorial(Operacion operacion)
    {
        // string? archivo=File.ReadAllText(LeerJson.rutaOperaciones);
        // List<Operacion> operaciones=JsonConvert.DeserializeObject<List<Operacion>>(archivo);
        // operaciones.Add(operacion);
        List<Operacion> operacionesActualesJson=LeerJson.LeerHistorialOperaciones();
        operacionesActualesJson.Add(operacion);
        string? HistorialOperaciones=JsonConvert.SerializeObject(operacionesActualesJson,Formatting.Indented);
        File.WriteAllText(LeerJson.rutaOperaciones,HistorialOperaciones);
    }

}