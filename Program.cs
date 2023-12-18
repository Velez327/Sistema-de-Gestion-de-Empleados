class Program
{
    static void Main()
    {
        var desarrollador = new Desarrollador("John Doe", "D001", new List<string> { "C#", "ASP.NET", "SQL" });
        var gerente = new Gerente("Jane Smith", "G001");

        desarrollador.ImprimirDetalles();
        Console.WriteLine();

        gerente.ImprimirDetalles();
        gerente.GestionarProyecto();
        gerente.GestionarPersonal();
    }
}

