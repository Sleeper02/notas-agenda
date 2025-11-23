public class Nota
{
    public string Titulo {get ; set;}
    public string Desc{get ; set;}


    public Nota(string titulo, string desc)
    {
        this.Titulo = titulo;
        this.Desc = desc;
    }

    public override string ToString() // Método para exibir a nota 
    {
        return $"Título: {Titulo}\nDescrição: {Desc}"; //
    }
}