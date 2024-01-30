public class GestionarProductos{
    
    
    public static void RemoverCuentasUsuariosJson(Usuario usuario, Cuenta cuenta)
    {
                //ya tengo la cuenta del ususario logeado
                usuario.Productos.Cuentas.Remove(cuenta);
                GuardarJson.GuardarCuentaActualizada(GuardarJson.usuariosActualesJson);   
    }

    public static void ActualizarCuentasDespuesTransaccion(Usuario usuario,Cuenta cuentaUsuario) {//recuerda que esta es la cuenta del usuario logeado    
        usuario.Productos.Cuentas.Add(cuentaUsuario);
        GuardarJson.GuardarCuentaActualizada(GuardarJson.usuariosActualesJson);
    }
    
}