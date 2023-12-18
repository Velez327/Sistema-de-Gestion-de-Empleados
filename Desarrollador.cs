// Implementación de la interfaz para Desarrollador
public class Desarrollador : IDesarrollador
{
    private string nombre;
    private string id;
    private List<string> habilidades;

    public Desarrollador(string nombre, string id, List<string> habilidades)
    {
        this.nombre = nombre;
        this.id = id;
        this.habilidades = habilidades;
    }

    public string ObtenerNombre() => nombre;
    public string ObtenerId() => id;

    public List<string> ObtenerHabilidades() => habilidades;

    public void ImprimirDetalles()
    {
        Console.WriteLine("Detalles del Desarrollador:");
        Console.WriteLine($"Nombre: {ObtenerNombre()}");
        Console.WriteLine($"ID: {ObtenerId()}");
        Console.WriteLine($"Habilidades: {string.Join(", ", ObtenerHabilidades())}");
    }
}
