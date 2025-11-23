public class Evento
{
    public string Titulo {get ; set;}
    public DateTime Data {get ; set;}
    public List<Nota> NotasAssociadas {get ; set;} = new List<Nota>();

    public Evento(string titulo, DateTime data)
    {
        this.Titulo = titulo;
        this.Data = data;
    }

    public void AdicionarNota(string titulo, string desc)
    {
        Nota novaNota = new Nota(titulo, desc);
        NotasAssociadas.Add(novaNota);
    }
}
   