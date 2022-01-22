using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;

            string str20 = "20";
            int int20 = 20;
            string newString = str20 + int20.ToString();
            Console.WriteLine(newString);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dateTime);
            Console.WriteLine(hour);
        }
    }
}
