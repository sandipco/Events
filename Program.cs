using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            book _book = new book();
            _book.Name = "The Jungle Book";
            _book.NameChanged += nameChangedNotification;
            _book.NameChanged += nameChangedNotification2;
            _book.Name = "Robinson Crusoe";
            Console.ReadLine();
        }
        static void nameChangedNotification(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", args.oldValue, args.newValue);
        }
        static void nameChangedNotification2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("****************");
        }
    }
}
