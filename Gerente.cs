// Implementación de la interfaz para Gerente
public class Gerente : IGerente
{
    private string nombre;
    private string id;

    public Gerente(string nombre, string id)
    {
        this.nombre = nombre;
        this.id = id;
    }

    public string ObtenerNombre() => nombre;
    public string ObtenerId() => id;

    public void GestionarProyecto()
    {
        Console.WriteLine("Gestionando proyecto...");
    }

    public void GestionarPersonal()
    {
        Console.WriteLine("Gestionando personal...");
    }

    public void ImprimirDetalles()
    {
        Console.WriteLine("Detalles del Gerente:");
        Console.WriteLine($"Nombre: {ObtenerNombre()}");
        Console.WriteLine($"ID: {ObtenerId()}");
    }
}