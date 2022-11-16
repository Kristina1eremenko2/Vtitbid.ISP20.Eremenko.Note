using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Eremenko.Note
{
    public class Note
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public int[] DateOfBirth { get; set; }
        public Note(string firstName, string lastName, string telephone, int[] dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Telephone = telephone;
            DateOfBirth = dateOfBirth;
        }

        public static Note[] GetNoteArray()
        {
            int numberOfPeople = 0;
            string input;
            do
            {
                Console.Write("Введите количество людей: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out numberOfPeople));

            Note[] note = new Note[numberOfPeople];

            for (int i = 0; i < note.Length; i++)
            {

                int[] dateOfBirth = new int[3];
                Console.Write("Введите имя: ");
                string firstName = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Введите дату рождения: ");
                Console.Write("День: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Год: ");
                int year = Convert.ToInt32(Console.ReadLine());
                dateOfBirth[0] = day;
                dateOfBirth[1] = month;
                dateOfBirth[2] = year;
                Console.WriteLine("Введите номер телефона: ");
                string telephone = Console.ReadLine();
                note[i] = new Note(firstName, lastName, telephone, dateOfBirth);
            }
            Note[] noteSort = note.OrderBy(ob => ob.Telephone).ToArray();
            for (int i = 0; i < note.Length; i++)
            {
                Console.WriteLine(noteSort[i]);
            }
            Console.WriteLine("Поиск по номеру телефона: ");
            string ser = Console.ReadLine();

            for (int i = 0; i < noteSort.Length; i++)
            {
                if (ser.ToLower() == note[i].Telephone.ToLower())
                {
                    Console.WriteLine(note[i]);
                }

                else if (ser.ToLower() != note[i].Telephone.ToLower() && i == note.Length - 1)
                {
                    Console.WriteLine("Такого номера телефона нет!!!");
                }
            }
            Console.ReadKey();
            return note;
        }
        public override string ToString()
        {
            return $"Имя: {FirstName}\nФамилия: {LastName}\nНомер телефон: {string.Format("{0:+#(###)###-##-##}", System.Convert.ToInt64(Telephone))}\nДата рождения: {DateOfBirth[0]}.{DateOfBirth[1]}.{DateOfBirth[2]},";
        }
    }
}
