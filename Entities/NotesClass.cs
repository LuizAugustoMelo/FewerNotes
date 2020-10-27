using FewerNotes.Entities.Exceptions;
using System.Text;

namespace Entities
{
    class NotesClass
    {
        protected int[] ValidNotes = { 50, 20, 10, 5, 2, 1 };

        public int Value { get; protected set; }

        public NotesClass(int value)
        {
            Value = value;
        }

        public string FewerNotes()
        {
            StringBuilder sb = new StringBuilder();
            int modulus = 0;
            if (Value != 0)
            {
                sb.Append("São necessarias ");
                for (int i = 0; i < ValidNotes.Length; i++)
                {
                    if (Value%ValidNotes[i] == 0)
                    {
                        sb.Append($"{Value/ValidNotes[i]} de {ValidNotes[i]}");
                        return sb.ToString();
                    }
                    else
                    {
                        modulus = Value % ValidNotes[i];
                        Value -= modulus;
                        if (Value != 0)
                        {
                            int division = Value / ValidNotes[i];
                            if (division > 1)
                                sb.Append($"{division} notas de {ValidNotes[i]}, ");
                            else
                                sb.Append($"{division} nota de {ValidNotes[i]}, ");
                        }
                    }
                    Value = modulus;
                }
            }
            else
                throw new NotesExceptions("Valor deve ser maior que 0!");
            
            return sb.ToString();
        }
    }
}
