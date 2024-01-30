public class MenuGestionarProductos
{
    public static int opcion;

    public static void ShowMenuGestionarProductos()
    {
        do
        {
            System.Console.WriteLine(@"
        +-+-+-+-  Gestionar productos  -+-+-+-+
        Qué operación quieres realizar?
        [1]-Crear usuario
        [2]-Eliminar usuario
        [3]-Crear cuenta a un usuario
        [4]-Eliminar cuenta a un usuario
        [5]-Crear Tarjeta a un usuario
        [6]-Eliminar Tarjeta a un usuario
        [7]-Crear préstamo a un usuario
        [8]-Eliminar préstamo a un usuario
        [9]-Salir
        ");
            opcion = int.Parse(Console.ReadLine()!);

            switch ((Opcion)opcion)
            {
                case Opcion.CrearUsuario:
                    AgregarProductos.CrearUsuario();
                    break;
                case Opcion.EliminarUsuario:
                    EliminarProductos.EliminarUsuario();
                    break;
                case Opcion.CrearCuenta:
                    AgregarProductos.CrearCuenta();
                    break;
                case Opcion.EliminarCuenta:
                    EliminarProductos.EliminarCuenta();
                    break;
                case Opcion.CrearTarjeta:
                    AgregarProductos.CrearTarjeta();
                    break;
                case Opcion.EliminarTarjeta:
                    EliminarProductos.EliminarTarjeta();
                    break;
                case Opcion.CrearPrestamo:
                    AgregarProductos.CrearPrestamo();
                    break;
                case Opcion.EliminarPrestamo:
                    EliminarProductos.EliminarPrestamo();
                    break;
                case Opcion.Salir:
                    break;
                default:
                    System.Console.WriteLine("Opción no válida. Por favor, elige una opción correcta.");
                    break;
            }
        } while (opcion != (int)Opcion.Salir);
    }

    public enum Opcion
    {
        CrearUsuario = 1,
        EliminarUsuario,
        CrearCuenta,
        EliminarCuenta,
        CrearTarjeta,
        EliminarTarjeta,
        CrearPrestamo,
        EliminarPrestamo,
        Salir
    }
}