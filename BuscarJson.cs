public class BuscarJson{

    public static Usuario? usuario;
    public static Cuenta? cuenta;
    public static Tarjeta? tarjeta;
    public static int numCuenta;
    public static int numTarjeta;
    public static string? cedula;

    
    public  int PedirNumCuenta(){
        System.Console.WriteLine("Ingresa el numero de cuenta:");
        numCuenta=int.Parse(Console.ReadLine()!);
        return numCuenta;
    }
    public  string? PedirCedula(){
        System.Console.WriteLine("Ingresa la cedula del ususario:");
        cedula=Console.ReadLine()!;
        return cedula;
    }
    public int PedirNumTarjeta(){
        System.Console.WriteLine("Ingresa el numero de la tarjeta:");
        int numTarjeta=int.Parse(Console.ReadLine()!);
        return numTarjeta;
    }
    
    // public static int BuscarUltimoNumCuenta(List<Usuario> usuarios)
    // {
    //     int MaxNum = usuarios.SelectMany(u => u.Productos.Cuentas)
    //                         .Max(c => c.NumeroCuenta);
    //     return MaxNum;
    // } no se pudo
    


    
    public  Usuario BuscarUsuario(string cedula){
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
    public  Cuenta BuscarCuenta(int numCuenta){
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
    public  Tarjeta BuscarTarjeta(int numTarjeta)
    {
        //buscar usuario que tenga cuentas y que el numero sea igual .... Tenemos que usar any para que sea booleana la respuesta ya que firstOrDefault devuelve un tipo Cuenta
        usuario=GuardarJson.usuariosActualesJson.FirstOrDefault(u=>u.Productos.Tarjetas !=null && u.Productos.Tarjetas.Any(b => b.NumeroTarjeta==numTarjeta));
        
        if(usuario != null && usuario.Productos.Tarjetas != null)
        {
            tarjeta=usuario.Productos.Tarjetas.FirstOrDefault(p => p.NumeroTarjeta==numTarjeta);
            if(tarjeta!=null)
            {  
                return tarjeta;    
            }
            else
            {
                return null;
            }
        }
        else
        {
            return null;
        }
    }
}