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
            Cuenta cuentaNueva=new Cuenta();
            ActualizarJson.ActualizarCuentasDespuesEdicion(usuario,cuentaNueva);
        }
    }
}