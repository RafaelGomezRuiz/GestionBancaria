using Newtonsoft.Json;

public class GuardarJson{

    public static List<Usuario> usuariosActualesJson=LeerJson.LeerUsuario();
    
    public static void GuardarUsuarioActualizado(List<Usuario> usuarios){
        
        string? usuarioJsonActualizado=JsonConvert.SerializeObject(usuarios, Formatting.Indented);
        File.WriteAllText(LeerJson.rutaUsuarios,usuarioJsonActualizado);
    }
    public static void GuardarCuentaActualizada(List<Usuario> cuentas){
        
        string? cuentaJsonActualizada=JsonConvert.SerializeObject(cuentas, Formatting.Indented);
        File.WriteAllText(LeerJson.rutaUsuarios,cuentaJsonActualizada);
    }

}