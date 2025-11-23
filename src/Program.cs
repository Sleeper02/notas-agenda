using System;

class Program
{
    static void Main(string[] args)
    {
        // Criar uma nova agenda
        Agenda minhaAgenda = new Agenda();

        // Agendar alguns eventos (aulas)
        minhaAgenda.AgendarEvento("Cálculo I", new DateTime(2025, 11, 25));
        minhaAgenda.AgendarEvento("Programação", new DateTime(2025, 11, 25));
        minhaAgenda.AgendarEvento("Física", new DateTime(2025, 11, 26));
        minhaAgenda.AgendarEvento("Banco de Dados", new DateTime(2025, 11, 27));

        // Adicionar notas aos eventos
        minhaAgenda.AdicionarNota("Cálculo I", "Derivadas", "Estudar capítulo 3", new DateTime(2025, 11, 25));
        minhaAgenda.AdicionarNota("Cálculo I", "Exercícios", "Fazer lista 5", new DateTime(2025, 11, 25));
        minhaAgenda.AdicionarNota("Programação", "C#", "Revisar implementações", new DateTime(2025, 11, 25));
        minhaAgenda.AdicionarNota("Física", "Cinemática", "Resolver problemas", new DateTime(2025, 11, 26));

        // Exibir a semana (a partir de hoje ou de uma data específica)
        minhaAgenda.ListarEventosSemana(new DateTime(2025, 11, 23));

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

}