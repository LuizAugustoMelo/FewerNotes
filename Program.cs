using Entities;
using FewerNotes.Entities.Exceptions;
using System;

namespace FewerNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Software para determinar a menor quantidade de notas para um valor inteiro.");
            Console.WriteLine();
            try
            {
                Console.Write("Entre com o valor (ex 200): ");
                int value = int.Parse(Console.ReadLine());

                NotesClass notes = new NotesClass(value);
                Console.WriteLine(notes.FewerNotes());
            }
            catch (NotesExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
