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
        OperacionRealizada.GuardarOperacionProductos("Se creo un usuario");
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
                    OperacionRealizada.GuardarOperacionProductos("Se creo una cuenta");
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
            System.Console.WriteLine("Ingresa el numero de la tarjeta: ");
            int numTarjeta=int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Ingresa la fecha de expiracion:");
            string? fechaExpiracion = Console.ReadLine()!;
            
            Console.WriteLine("Ingresa el total de la deuda:");
            double saldoDeuda = double.Parse(Console.ReadLine()!);
            
            Tarjeta tarjetaNueva = new Tarjeta
            {
                NumeroTarjeta=numTarjeta,
                FechaExpiracion=fechaExpiracion,
                SaldoDeuda=saldoDeuda,
                EstadoTarjeta=true,
                FechaCreacion = DateTime.Now,
                
            };
                    ActualizarJson.ActualizarTarjetasDespuesEdicion(usuario,tarjetaNueva);
                    System.Console.WriteLine("Tarjeta creada!");
                    OperacionRealizada.GuardarOperacionProductos("Se creo una tarjeta");
        }
        else{
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
    }
    public static void CrearPrestamo()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula=buscarJson.PedirCedula();
        Usuario? usuario=buscarJson.BuscarUsuario(cedula);
        if (usuario != null)
        {   
            System.Console.WriteLine("id:");
            int id=int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Ingresa el monto del préstamo: ");
        double monto = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingresa el plazo en meses:");
        int plazoMeses = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingresa la tasa de interés:");
        double tasaInteres = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingresa el propósito del préstamo:");
        string? proposito = Console.ReadLine()!;

        Prestamo prestamoNuevo = new Prestamo
        {
            Id=id,
            Monto = monto,
            PlazoMeses = plazoMeses,
            TasaInteres = tasaInteres,
            Proposito = proposito,
            Aprobado = false,
            FechaSolicitud = DateTime.Now,
            FechaAprobacion = null, //Para no ponerlo null se le pone el minimo DateTime.MinValue
        };
            ActualizarJson.ActualizarPrestamosDespuesEdicion(usuario, prestamoNuevo);
            System.Console.WriteLine("Préstamo creado!");
            OperacionRealizada.GuardarOperacionProductos("Se creo un prestamo");
        }
        else{
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
    }
}