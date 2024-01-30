public class MenuPrincipal{

    public static int opcion;

    public static void ShowMenuPrincipal(){
        do
        {
            System.Console.WriteLine(@"
        +-+-+-+-  Bienvenido  -+-+-+-+
        Que operacion quieres realizar?
        [1]-GestionarProductos
        [2]-GestionarUsuarios
        [3]-Salir
        ");
        opcion=int.Parse(Console.ReadLine()!);

        switch ((Opcion?)opcion)
        {
            case Opcion.GestionarProductos:
            MenuGestionarProductos.ShowMenuGestionarProductos();
            break;
            case Opcion.GestionarUsuarios:
            MenuGestionarUsuarios.ShowMenuGestionarUsuarios();
            break;
            case Opcion.Salir:
            System.Console.WriteLine("Gracias por utilizar nuestros servicios!");
            break;
            
            default:
            break;
        }
        } while (opcion!=3);
    }

    public enum Opcion{
        GestionarProductos =1,
        GestionarUsuarios,
        Salir
    }

}