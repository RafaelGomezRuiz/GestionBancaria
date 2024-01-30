public class EliminarProductos{
    
    public static void EliminarUsuario()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula = buscarJson.PedirCedula();
        Usuario? usuario = buscarJson.BuscarUsuario(cedula);

        if (usuario != null)
        {
            Console.WriteLine("¿Estás seguro de que deseas eliminar este usuario? (1.Sí / 2.No)");
            string respuesta = Console.ReadLine();

            if (respuesta == "1")
            {
                ActualizarJson.RemoverUsuariosJson(usuario);
                Console.WriteLine("Usuario eliminado exitosamente.");
            }
            else if (respuesta == "2")
            {
                Console.WriteLine("Operación cancelada. El usuario no fue eliminado.");
            }
            else
            {
                Console.WriteLine("Respuesta no válida. Operación cancelada.");
            }
        }
        else
        {
            Console.WriteLine("No existe usuario con esa cédula");
        }
    }

    public static void EliminarCuenta()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula = buscarJson.PedirCedula();
        Usuario? usuario = buscarJson.BuscarUsuario(cedula);

        if (usuario != null)
        {
            int numCuenta = buscarJson.PedirNumCuenta();
            Cuenta? cuenta = buscarJson.BuscarCuenta(numCuenta);

            if (cuenta != null)
            {
                Console.WriteLine("¿Estás seguro de que deseas eliminar esta cuenta? (1.Sí / 2.No)");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    ActualizarJson.RemoverCuentasUsuariosJson(usuario, cuenta);
                    Console.WriteLine("Cuenta eliminada exitosamente.");
                }
                else if (respuesta == "2")
                {
                    Console.WriteLine("Operación cancelada. La cuenta no fue eliminada.");
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Operación cancelada.");
                }
            }
            else
            {
                Console.WriteLine("No existe cuenta con ese número");
            }
        }
        else
        {
            Console.WriteLine("No existe usuario con esa cédula");
        }
    }

    public static void EliminarTarjeta()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula = buscarJson.PedirCedula();
        Usuario? usuario = buscarJson.BuscarUsuario(cedula);

        if (usuario != null)
        {
            int numTarjeta = buscarJson.PedirNumTarjeta();
            Tarjeta? tarjeta = buscarJson.BuscarTarjeta(numTarjeta);

            if (tarjeta != null)
            {
                Console.WriteLine("¿Estás seguro de que deseas eliminar esta tarjeta? (1.Sí / 2.No)");
                string? respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    ActualizarJson.RemoverTarjetasUsuariosJson(usuario, tarjeta);
                    Console.WriteLine("Tarjeta eliminada exitosamente.");
                }
                else if (respuesta == "2")
                {
                    Console.WriteLine("Operación cancelada. La tarjeta no fue eliminada.");
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Operación cancelada.");
                }
            }
            else
            {
                Console.WriteLine("No existe tarjeta con ese número");
            }
        }
        else
        {
            Console.WriteLine("No existe usuario con esa cédula");
        }
    }
    public static void EliminarPrestamo()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula = buscarJson.PedirCedula();
        Usuario? usuario = buscarJson.BuscarUsuario(cedula);

        if (usuario != null)
        {
            int idPrestamo = buscarJson.PedirIdPrestamo();
            Prestamo? prestamo = buscarJson.BuscarPrestamo(idPrestamo);

            if (prestamo != null)
            {
                Console.WriteLine("¿Estás seguro de que deseas eliminar este préstamo? (1.Sí / 2.No)");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    ActualizarJson.RemoverPrestamosUsuariosJson(usuario, prestamo);
                    Console.WriteLine("Préstamo eliminado exitosamente.");
                }
                else if (respuesta == "2")
                {
                    Console.WriteLine("Operación cancelada. El préstamo no fue eliminado.");
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Operación cancelada.");
                }
            }
            else
            {
                Console.WriteLine("No existe préstamo con ese ID");
            }
        }
        else
        {
            Console.WriteLine("No existe usuario con esa cédula");
        }
    }
}
