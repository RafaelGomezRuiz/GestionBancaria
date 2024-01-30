    public class Prestamo
    {
        public double Id { get; set; }
        public double Monto { get; set; }
        public int PlazoMeses { get; set; }
        public double TasaInteres { get; set; }
        public string? Proposito { get; set; }
        public bool Aprobado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime? FechaAprobacion { get; set; }//debe ser Solicitar prestamo y que en gestionar usuarios se pueda aprobar
        //signo de interrogacion en fecha para que pueda ser null 
        // o Nullable<DateTime>
        public Prestamo()
        {
            Aprobado=false;
            FechaSolicitud = DateTime.Now;
        }
    }