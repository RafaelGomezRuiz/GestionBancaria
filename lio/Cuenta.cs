public class Cuenta{
    
    
    public DateTime FechaCreacion;
    public int NumeroCuenta { get; set; }
    public int Pin { get; set; }
    public double Saldo { get; set; }
    public string? TipoCuenta { get; set; }
    public bool EstadoCuenta {get;set;}
    
    public Cuenta()
    {
        System.Console.WriteLine("Ingresa el numero de la cuenta: ");
        int numCuentaU=int.Parse(Console.ReadLine()!);
        NumeroCuenta=numCuentaU;
        Console.WriteLine("Ingresa el tipo de cuenta:");
        string? tipoCuenta = Console.ReadLine()!;
        TipoCuenta=tipoCuenta;
        Console.WriteLine("Ingresa el saldo inicial:");
        double saldoInicial = double.Parse(Console.ReadLine()!);
        Saldo=saldoInicial;
        Console.WriteLine("Ingresa el PIN:");
        int pin = int.Parse(Console.ReadLine()!);
        Pin=pin;
        
        FechaCreacion = DateTime.Now;
        EstadoCuenta=true;
    }

    public override string ToString()
        {
            return $"Número de Cuenta: {NumeroCuenta}, Tipo de Cuenta: {TipoCuenta}, Saldo: {Saldo:C}, Estado de Cuenta: {(EstadoCuenta ? "Activa" : "Inactiva")}";
        }

    
}