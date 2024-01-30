public class MenuGestionarUsuarios
{
    public static int opcion;

    public static void ShowMenuGestionarUsuarios()
    {
        do
        {
            System.Console.WriteLine(@"
        +-+-+-+-  Gestionar usuarios  -+-+-+-+
        Qué operación deseas realizar?
        [1]-Editar nombre
        [2]-Editar correo
        [3]-Editar cédula
        [4]-Editar teléfono
        [5]-Inhabilitar cuenta
        [6]-Inhabilitar tarjeta
        [7]-Salir
        ");
            opcion = int.Parse(Console.ReadLine()!);

            switch ((Opcion?)opcion)
            {
                case Opcion.EditarNombre:
                    EditarUsuario.EditarNombre();
                    opcion=7;
                    break;
                case Opcion.EditarCorreo:
                    EditarUsuario.EditarCorreo();
                    break;
                case Opcion.EditarCedula:
                    EditarUsuario.EditarCedula();
                    break;
                case Opcion.EditarTelefono:
                    EditarUsuario.EditarTelefono();
                    break;
                case Opcion.InhabilitarCuenta:
                    EditarUsuario.InabilitarCuenta();
                    break;
                case Opcion.InhabilitarTarjeta:
                    // Lógica para inhabilitar una tarjeta
                    break;
                case Opcion.Salir:
                    // Lógica para salir del programa
                    System.Console.WriteLine("Gracias por utilizar nuestros servicios!");
                    break;
                default:
                    System.Console.WriteLine("Opción no válida. Por favor, elige una opción correcta.");
                    break;
            }
        } while (opcion != (int)Opcion.Salir);
    }

    public enum Opcion
    {
        EditarNombre = 1,
        EditarCorreo,
        EditarCedula,
        EditarTelefono,
        InhabilitarCuenta,
        InhabilitarTarjeta,
        Salir
    }
}