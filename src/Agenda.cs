using System;
using System.Collections.Generic;
using System.Linq;

public class Agenda
{
    public List<Evento> Eventos { get; set; } = new List<Evento>();
    
    public void AgendarEvento(string titulo, DateTime data)
    {
        Eventos.Add(new Evento(titulo, data));
    } 

    public void AdicionarNota(string tituloEvento, string tituloNota, string descNota, DateTime data)
    {
        var evento = Eventos.FirstOrDefault(e => e.Titulo == tituloEvento && e.Data.Date == data.Date);
        if (evento != null)
        {
            evento.AdicionarNota(tituloNota, descNota);
        }
        else
        {
            Console.WriteLine("Evento não encontrado.");
        }
    }

    public List<Evento> ListarEventosDia(DateTime data)
    {
        return Eventos.Where(e => e.Data.Date == data.Date).ToList();
    }

    public void ListarEventosSemana(DateTime data)
    {
        Console.WriteLine("\n Eventos da Semana: \n");
        for (int i = 0; i < 7; i++)
        {
            DateTime dia = data.AddDays(i); // Calcula o dia atual da semana
            var eventosDoDia = ListarEventosDia(dia);

            Console.Write($"{dia:dd/MM} - {dia:dddd} -> ");

            if (eventosDoDia.Count > 0)
            {
                Console.WriteLine(string.Join(" | ", eventosDoDia.Select(e => e.Titulo)));

                foreach (var evento in eventosDoDia)
                {
                    
                    if (evento.NotasAssociadas.Count > 0)
                    {
                        Console.WriteLine($"\n {evento.Titulo}:");
                        foreach (var nota in evento.NotasAssociadas)
                        {
                            Console.WriteLine($"- {nota.Titulo}:\n-- {nota.Desc}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhum evento.");
            }

            Console.WriteLine();
        }
    }




}