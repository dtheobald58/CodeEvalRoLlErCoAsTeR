using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalRoLlErCoAsTeR
{
    class Program
    {
        static void Main(string[] args)
        {
            string original1 = "To be, or not to be: that is the question.";
            string original2 = "Whether 'tis nobler in the mind to suffer.";
            string original3 = "The slings and arrows of outrageous fortune.";
            string original4 = "Or to take arms against a sea of troubles.";
            string original5 = "And by opposing end them, to die: to sleep.";

            StringBuilder coasted = new StringBuilder();
            coasted.AppendLine(ToCoaster(original1));
            coasted.AppendLine(ToCoaster(original2));
            coasted.AppendLine(ToCoaster(original3));
            coasted.AppendLine(ToCoaster(original4));
            coasted.AppendLine(ToCoaster(original5));

            Console.Write(coasted + "\n\n");           
        }

        public static string ToCoaster (string original)
        {
            string changed = "";
            for (int i = 0; i < original.Length; i++)
            {
                if (i % 2 == 0)
                {
                    changed += original[i].ToString().ToUpper();
                }
                else
                {
                    changed += original[i].ToString().ToLower();
                }              
            }
            return changed;
        }



    }
}
