using Newtonsoft.Json;

public class EditarUsuario{
    
    // public int numCuenta;
    // public Usuario usuario;  no pueden ser estaticas porque almacen el valor
    // BuscarJson buscarJson = new BuscarJson();
    
    public static void EditarNombre(){
        BuscarJson buscarJson = new BuscarJson(); //puedes hacer una instancia general
        string cedula = buscarJson.PedirCedula();
        Usuario? usuario = buscarJson.BuscarUsuario(cedula);

        if (usuario != null)
        {
            ActualizarJson.RemoverUsuariosJson(usuario);
            System.Console.WriteLine($"Nombre actual:{usuario.Nombre}");
            System.Console.WriteLine("Ingresa el nombre:");
            string? nombre = Console.ReadLine()!;
            usuario.Nombre = nombre;
            System.Console.WriteLine("Nombre actualizado!");
            ActualizarJson.ActualizarUsuarioDespuesEdicion(usuario);
            OperacionRealizada.GuardarOperacion("Actualizo el nombre");
        }
        else
        {
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
        
    }

    public static void EditarCorreo()
    {
        BuscarJson buscarJson = new BuscarJson();
        string cedula = buscarJson.PedirCedula();
        Usuario usuario = buscarJson.BuscarUsuario(cedula);

        if (usuario != null)
        {    ActualizarJson.RemoverUsuariosJson(usuario);

            Console.WriteLine($"Correo actual: {usuario.Correo}");
            Console.WriteLine("Ingresa el nuevo correo:");
            string? correo = Console.ReadLine()!;
            usuario.Correo = correo;

            Console.WriteLine($"Correo actualizado!");
            ActualizarJson.ActualizarUsuarioDespuesEdicion(usuario);
            OperacionRealizada.GuardarOperacion("Actualizo el correo");
        }
        else{
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
    }

    public static void EditarCedula()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula = buscarJson.PedirCedula();
        Usuario usuario = buscarJson.BuscarUsuario(cedula);

        if (usuario != null)
        {
        ActualizarJson.RemoverUsuariosJson(usuario);

        Console.WriteLine($"Cédula actual: {usuario.Cedula}");
        Console.WriteLine("Ingresa la nueva cédula:");
        string? cedulaNueva = Console.ReadLine()!;
        usuario.Cedula = cedulaNueva;

        Console.WriteLine($"Cédula actualizada!");
        ActualizarJson.ActualizarUsuarioDespuesEdicion(usuario);
        OperacionRealizada.GuardarOperacion("Actualizo la cedula");
        }
        else{
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
    }

    public static void EditarTelefono()
    {
        BuscarJson buscarJson = new BuscarJson();
        string cedula = buscarJson.PedirCedula();
        Usuario usuario = buscarJson.BuscarUsuario(cedula);

        if (usuario != null)
        {
            ActualizarJson.RemoverUsuariosJson(usuario);

        Console.WriteLine($"Teléfono actual: {usuario.Telefono}");
        Console.WriteLine("Ingresa el nuevo teléfono:");
        int telefono = int.Parse(Console.ReadLine()!);
        usuario.Telefono = telefono;

        Console.WriteLine($"Teléfono actualizado!");
        ActualizarJson.ActualizarUsuarioDespuesEdicion(usuario);
        OperacionRealizada.GuardarOperacion("Actualizo el telefono");
        }
        else{
            System.Console.WriteLine("error");
        }
    }

    public static void InabilitarCuenta(){
        BuscarJson buscarJson = new BuscarJson();
        string? cedula = buscarJson.PedirCedula();
        
        Usuario usuario=buscarJson.BuscarUsuario(cedula);
        if (usuario != null)
        {       int numCuenta = buscarJson.PedirNumCuenta();
                Cuenta cuenta=buscarJson.BuscarCuenta(numCuenta);
            if(cuenta!=null){
                ActualizarJson.RemoverCuentasUsuariosJson(usuario,cuenta);
                System.Console.WriteLine($"Estado actual: {cuenta.EstadoCuenta}");
                System.Console.WriteLine("Nuevo estado de la cuenta: ");
                bool estadoCuenta=bool.Parse(Console.ReadLine()!);
                cuenta.EstadoCuenta=estadoCuenta;
                ActualizarJson.ActualizarCuentasDespuesEdicion(usuario,cuenta);
                OperacionRealizada.GuardarOperacion("Se inabilito la cuenta");
            }
            else{
                System.Console.WriteLine("No existe cuenta con ese numero");
            }
        }
        else{
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
    }

    public static void InabilitarTarjeta(){
        BuscarJson buscarJson = new BuscarJson();
        string? cedula = buscarJson.PedirCedula();
        Usuario? usuario=buscarJson.BuscarUsuario(cedula);
        if(usuario!=null){
            int numTarjeta = buscarJson.PedirNumTarjeta();
            Tarjeta? tarjeta=buscarJson.BuscarTarjeta(numTarjeta);
            if (tarjeta !=null){//aqui
                ActualizarJson.RemoverTarjetasUsuariosJson(usuario,tarjeta);
                System.Console.WriteLine($"Estado actual: {tarjeta.EstadoTarjeta}");
                System.Console.WriteLine("Nuevo estado de la tarjeta: ");
                bool estadoTarjeta=bool.Parse(Console.ReadLine()!);
                tarjeta.EstadoTarjeta=estadoTarjeta;
                ActualizarJson.ActualizarTarjetasDespuesEdicion(usuario,tarjeta);
                OperacionRealizada.GuardarOperacion("Se inabilito la tarjeta");
            }else{
                System.Console.WriteLine("No existe tarjeta con ese numero");
            }
            }
        else{
            System.Console.WriteLine("No existe usuario con esa cedula");
        }
    }

    public static void AprobarPrestamo()
    {
        BuscarJson buscarJson = new BuscarJson();
        string? cedula = buscarJson.PedirCedula();
        Usuario? usuario = buscarJson.BuscarUsuario(cedula);

        //Comprobar si existe el usuario
        if (usuario == null) {
            Console.WriteLine("No existe usuario con esa cédula");
            return;
        }

        //Pedir Id del prestamo
        int idPrestamo = buscarJson.PedirIdPrestamo();
        Prestamo? prestamo = buscarJson.BuscarPrestamo(idPrestamo);

        //Comprobar si tiene prestamo
        if (prestamo == null) {
            Console.WriteLine("No existe préstamo con ese ID");
            return;
        }
            ActualizarJson.RemoverPrestamosUsuariosJson(usuario,prestamo);
            System.Console.WriteLine($"Esta actual del prestamo: {prestamo.Aprobado}");
            System.Console.WriteLine("Nuevo estado del prestamo: ");
            bool estadoPrestamo=bool.Parse(Console.ReadLine()!);
            prestamo.Aprobado=estadoPrestamo;
            prestamo.FechaAprobacion=DateTime.Now;
            ActualizarJson.ActualizarPrestamosDespuesEdicion(usuario,prestamo);
            OperacionRealizada.GuardarOperacion("Se aprobo un prestamo");
        }
            
        
}