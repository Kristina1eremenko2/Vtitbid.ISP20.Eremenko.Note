using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Eremenko.Note
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Note[] notes = Note.GetNoteArray();
            foreach (Note note in notes)
            {
                Console.WriteLine(note);
            }
        }
    }
}
