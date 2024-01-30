public class ActualizarJson{

        public static void RemoverUsuariosJson(Usuario usuario){
                    //ya tengo la cuenta del ususario logeado
                    GuardarJson.usuariosActualesJson.Remove(usuario);
                     GuardarJson.GuardarUsuarioActualizado(GuardarJson.usuariosActualesJson);       
        }
        public static void RemoverCuentasUsuariosJson(Usuario usuario, Cuenta cuenta){
                    //ya tengo la cuenta del ususario logeado
                    usuario.Productos.Cuentas.Remove(cuenta);
                GuardarJson.GuardarCuentaActualizada(GuardarJson.usuariosActualesJson);
                    
            }
        public static void RemoverTarjetasUsuariosJson(Usuario usuario, Tarjeta tarjeta)
        {
                usuario.Productos.Tarjetas.Remove(tarjeta);
                GuardarJson.GuardarCuentaActualizada(GuardarJson.usuariosActualesJson);      
        }

        public static void ActualizarUsuarioDespuesEdicion(Usuario usuario) {//recuerda que esta es la cuenta del usuario logeado    
                
                GuardarJson.usuariosActualesJson.Add(usuario);
                GuardarJson.GuardarUsuarioActualizado(GuardarJson.usuariosActualesJson);
        }
        public static void ActualizarCuentasDespuesEdicion(Usuario usuario,Cuenta cuentaUsuario) 
        {//recuerda que esta es la cuenta del usuario logeado
                
                        usuario.Productos.Cuentas.Add(cuentaUsuario);
                        GuardarJson.GuardarCuentaActualizada(GuardarJson.usuariosActualesJson);
        }
        public static void ActualizarTarjetasDespuesEdicion(Usuario usuario,Tarjeta tarjeta) 
        {//recuerda que esta es la cuenta del usuario logeado    
                usuario.Productos.Tarjetas.Add(tarjeta);
                GuardarJson.GuardarCuentaActualizada(GuardarJson.usuariosActualesJson);
        }
}