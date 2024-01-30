using Newtonsoft.Json;

public class EditarUsuario{

    public static string? nombre; 
    public static bool estadoCuenta;
    public static string? correo;
    public static int telefono;
    public static Cuenta cuenta;
    
    public static string? cedula =BuscarJson.PedirCedula();
    public static int numCuenta=BuscarJson.PedirNumCuenta();

    
    public static Usuario usuario;
    
    public static void EditarNombre(){
        usuario=BuscarJson.BuscarUsuario(cedula);
        ActualizarJson.RemoverUsuariosJson(usuario);
        System.Console.WriteLine($"Nombre actual:{usuario.Nombre}");
        System.Console.WriteLine("Ingresa el nombre:");
        nombre=Console.ReadLine()!;
        usuario.Nombre=nombre;
        System.Console.WriteLine("Nombre actualizado!");
        ActualizarJson.ActualizarUsuarioDespuesEdicion(usuario);
    }

    public static void EditarCorreo()
    {
        usuario = BuscarJson.BuscarUsuario(cedula);
        ActualizarJson.RemoverUsuariosJson(usuario);

        Console.WriteLine($"Correo actual: {usuario.Correo}");
        Console.WriteLine("Ingresa el nuevo correo:");
        correo = Console.ReadLine()!;
        usuario.Correo = correo;

        Console.WriteLine($"Correo actualizado!");
        ActualizarJson.ActualizarUsuarioDespuesEdicion(usuario);
    }

    public static void EditarCedula()
    {
        usuario = BuscarJson.BuscarUsuario(cedula);
        ActualizarJson.RemoverUsuariosJson(usuario);

        Console.WriteLine($"Cédula actual: {usuario.Cedula}");
        Console.WriteLine("Ingresa la nueva cédula:");
        cedula = Console.ReadLine()!;
        usuario.Cedula = cedula;

        Console.WriteLine($"Cédula actualizada!");
        ActualizarJson.ActualizarUsuarioDespuesEdicion(usuario);
    }

    public static void EditarTelefono()
    {
        usuario = BuscarJson.BuscarUsuario(cedula);
        ActualizarJson.RemoverUsuariosJson(usuario);

        Console.WriteLine($"Teléfono actual: {usuario.Telefono}");
        Console.WriteLine("Ingresa el nuevo teléfono:");
        telefono = int.Parse(Console.ReadLine()!);
        usuario.Telefono = telefono;

        Console.WriteLine($"Teléfono actualizado!");
        ActualizarJson.ActualizarUsuarioDespuesEdicion(usuario);
    }
    public static void InabilitarCuenta(){
        usuario=BuscarJson.BuscarUsuario(cedula);
        cuenta=BuscarJson.BuscarCuenta(numCuenta);
        ActualizarJson.RemoverCuentasUsuariosJson(usuario,cuenta);
        System.Console.WriteLine($"Estado actual: {cuenta.EstadoCuenta}");
        System.Console.WriteLine("Nuevo estado de la cuenta: ");
        estadoCuenta=bool.Parse(Console.ReadLine()!);
        cuenta.EstadoCuenta=estadoCuenta;
        ActualizarJson.ActualizarCuentasDespuesEdicion(usuario,cuenta);
    }
            
        
}