public class Operacion{

    public string? ActualizarUsuario {get;set;}
    public string? GestionarProductos{get;set;}
    public DateTime Fecha {get;set;}

    private static Operacion operaciones;
    
    private Operacion(){
        Fecha=DateTime.Now;
    }

    public static Operacion getOperacion(){
        if (operaciones== null){
            operaciones = new Operacion();
            return operaciones;
        }
        else{
            return operaciones;
        }
    }
    
    

}