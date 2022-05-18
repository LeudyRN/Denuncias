
public class Persona
{

    public string Nombre { get; set; }

    public String Fecha_hecho { get; set; }

    public string Cedula_denunciador { get; set; }

    public string Titulo_denuncia { get; set; }

    public string Nombre_denunciado { get; set; }

    public string Cedula_denunciado { get; set; }

    public string Descripcion { get; set; }

    public string Tribunal { get; set; }
    

    public Persona()
    {
    }
    //Constructor que recibe parametro del mismo clase
    public Persona(Persona Add)
    {
        Nombre = Add.Nombre;
        Fecha_hecho = Add.Fecha_hecho;
        Cedula_denunciador = Add.Cedula_denunciador;
        Titulo_denuncia = Add.Titulo_denuncia;
        Nombre_denunciado = Add.Nombre_denunciado;
        Cedula_denunciado = Add.Cedula_denunciado;
        Descripcion = Add.Descripcion;
        Tribunal = Add.Tribunal;
    }

    public class StreamReader : System.IO.TextReader
    {

    }


}

