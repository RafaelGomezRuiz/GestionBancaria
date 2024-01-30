public class BuscarJson{

    public static Usuario? usuario;
    public static Cuenta? cuenta;
    public static int numCuenta;
    public static string? cedula;


    public static int PedirNumCuenta(){
        System.Console.WriteLine("Ingresa el numero de cuenta:");
        numCuenta=int.Parse(Console.ReadLine()!);
        return numCuenta;
    }
    public static string? PedirCedula(){
        System.Console.WriteLine("Ingresa la cedula::");
        cedula=Console.ReadLine()!;
        return cedula;
    }

    
    public static Usuario BuscarUsuario(string cedula){
        //buscar usuario que tenga cuentas y que el numero sea igual .... Tenemos que usar any para que sea booleana la respuesta ya que firstOrDefault devuelve un tipo Cuenta
        usuario=GuardarJson.usuariosActualesJson.FirstOrDefault(d=>d.Cedula==cedula);
        
        if(usuario != null ){
                return usuario;       
        }
        else
        {                
               return null;
        }
    }
    public static Cuenta BuscarCuenta(int numCuenta){
        //buscar usuario que tenga cuentas y que el numero sea igual .... Tenemos que usar any para que sea booleana la respuesta ya que firstOrDefault devuelve un tipo Cuenta
        usuario=GuardarJson.usuariosActualesJson.FirstOrDefault(u=>u.Productos.Cuentas !=null && u.Productos.Cuentas.Any(b => b.NumeroCuenta==numCuenta));
        
        if(usuario != null && usuario.Productos.Cuentas != null){
            cuenta=usuario.Productos.Cuentas.FirstOrDefault(p => p.NumeroCuenta==numCuenta);
            if(cuenta!=null){  
                return cuenta;    
                }
            else{
                return null;
                }
        }
        else{
                    return null;
                }
        }
}