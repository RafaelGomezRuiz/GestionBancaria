public class AgregarProductos{

    public static void CrearUsuario()
    {
        Console.WriteLine("Ingresa el nombre:");
        string? nombre = Console.ReadLine()!;

        Console.WriteLine("Ingresa la cédula:");
        string? cedula = Console.ReadLine()!;

        Console.WriteLine("Ingresa el correo:");
        string? correo = Console.ReadLine()!;

        Console.WriteLine("Ingresa el teléfono:");
        int telefono = int.Parse(Console.ReadLine()!);

        Usuario nuevoUsuario = new Usuario
        {
            Nombre = nombre,
            Cedula = cedula,
            Correo = correo,
            Telefono = telefono,
        };

        ActualizarJson.ActualizarUsuarioDespuesEdicion(nuevoUsuario);//debo cambiarle el nombre al metodo
        System.Console.WriteLine("Usuario ingresado al dedillo");
    }
    public static void CrearCuenta()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula=buscarJson.PedirCedula();
        Usuario? usuario=buscarJson.BuscarUsuario(cedula);
        if (usuario != null)
        {   
            System.Console.WriteLine("Ingresa el numero de la cuenta: ");
            int numCuenta=int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Ingresa el tipo de cuenta:");
            string? tipoCuenta = Console.ReadLine()!;
            
            Console.WriteLine("Ingresa el saldo inicial:");
            double saldoInicial = double.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Ingresa el PIN:");
            int pin = int.Parse(Console.ReadLine()!);
            
            Cuenta cuentaNueva = new Cuenta
            {
                NumeroCuenta=numCuenta,
                TipoCuenta=tipoCuenta,
                Saldo=saldoInicial,
                Pin=pin,
                FechaCreacion = DateTime.Now,
                EstadoCuenta=true,
            };
                    ActualizarJson.ActualizarCuentasDespuesEdicion(usuario,cuentaNueva);
        }
        else{
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
    }
    public static void CrearTarjeta()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula=buscarJson.PedirCedula();
        Usuario? usuario=buscarJson.BuscarUsuario(cedula);
        if (usuario != null)
        {   
            System.Console.WriteLine("Ingresa el numero de la cuenta: ");
            int numCuenta=int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Ingresa el tipo de cuenta:");
            string? tipoCuenta = Console.ReadLine()!;
            
            Console.WriteLine("Ingresa el saldo inicial:");
            double saldoInicial = double.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Ingresa el PIN:");
            int pin = int.Parse(Console.ReadLine()!);
            
            Cuenta cuentaNueva = new Cuenta
            {
                NumeroCuenta=numCuenta,
                TipoCuenta=tipoCuenta,
                Saldo=saldoInicial,
                Pin=pin,
                FechaCreacion = DateTime.Now,
                EstadoCuenta=true,
            };
                    ActualizarJson.ActualizarCuentasDespuesEdicion(usuario,cuentaNueva);
        }
        else{
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
    }
}