public class Productos{

    public List<Cuenta>? Cuentas { get; set; }
    public List<Prestamo>? Prestamos { get; set; }
    public List<Tarjeta>? Tarjetas { get; set; }

    public Productos(){
        Cuentas=new List<Cuenta>();
        Prestamos=new List<Prestamo>();
        Tarjetas = new List<Tarjeta>();
    }
}