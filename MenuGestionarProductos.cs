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
        [2]-Crear cuenta a un usuario
        [3]-Eliminar cuenta a un usuario
        [4]-Crear Tarjeta a un usuario
        [5]-Eliminar Tarjeta a un usuario
        [6]-Crear préstamo a un usuario
        [7]-Eliminar préstamo a un usuario
        [8]-Salir
        ");
            opcion = int.Parse(Console.ReadLine()!);

            switch ((Opcion?)opcion)
            {
                case Opcion.CrearUsuario:
                    AgregarProductos.CrearUsuario();
                    break;
                case Opcion.CrearCuenta:
                    AgregarProductos.CrearCuenta();
                    break;
                case Opcion.EliminarCuenta:
                    // Lógica para eliminar una cuenta
                    break;
                case Opcion.CrearTarjeta:
                    // Lógica para crear una tarjeta
                    break;
                case Opcion.EliminarTarjeta:
                    // Lógica para eliminar una tarjeta
                    break;
                case Opcion.CrearPrestamo:
                    // Lógica para crear un préstamo
                    break;
                case Opcion.EliminarPrestamo:
                    // Lógica para eliminar un préstamo
                    break;
                case Opcion.Salir:
                    // Lógica para salir del programa
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
        CrearCuenta,
        EliminarCuenta,
        CrearTarjeta,
        EliminarTarjeta,
        CrearPrestamo,
        EliminarPrestamo,
        Salir
    }
}