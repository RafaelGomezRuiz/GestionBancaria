using Newtonsoft.Json;

public class LeerJson{



    public const string? rutaUsuarios=@"C:\Users\gsant\Programacionll\ATM\Main\usuarios.json";
    public const string? rutaOperaciones="operaciones.txt";

    public static List<Usuario> LeerUsuario(){
        if(File.Exists(rutaUsuarios)){
            string? JsonUsuario = File.ReadAllText(rutaUsuarios);
            List<Usuario>? usuario = JsonConvert.DeserializeObject<List<Usuario>>(JsonUsuario); 
            return  usuario;
        }
        else{
            
            return new List<Usuario>();
        }
    }
    
    public static List<Operacion> LeerHistorialOperaciones(){
        
            string? JsonHistorial=File.ReadAllText(rutaOperaciones);
            List<Operacion> operaciones=JsonConvert.DeserializeObject<List<Operacion>>(JsonHistorial);
            return operaciones;
       
    }
        
    /*public static List<Operaciones> LeerHistorialOperaciones()
    {
        if (File.Exists(GuardarJson.rutaHistorialOperaciones)){

            string? JsonHistorial=File.ReadAllText(GuardarJson.rutaHistorialOperaciones);
            List<Operaciones>? operacion=JsonConvert.DeserializeObject<List<Operaciones>>(JsonHistorial);
                return operacion;
            }
        else{    
   
                return new List<Operaciones>();
            }
    }
    */
}