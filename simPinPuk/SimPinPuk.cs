using System;

namespace simPinPuk
{
    internal abstract class Identifier
    {
        private readonly int _numb;
        private readonly string _badMessage;
        protected Identifier(int numb, string badMessage)
        {
            this._numb = numb;
            this._badMessage = badMessage;
        }
        
        public void GivePin()
        {
            Console.WriteLine("Adj egy számot");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input != _numb ? "Nem jó, még 1 próbálkozás" : "ok");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input != _numb ? "Nem jó, még 2 próbálkozás" : "ok");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input != _numb ? _badMessage : "ok");
        }
    }
    internal class Pin : Identifier
    {
        public Pin(int numb, string badMessage) : base(numb, badMessage)
        {
        }
    }

    internal class Puk : Identifier
    {
        public Puk(int numb, string badMessage) : base(numb, badMessage)
        {
        }
    }
    internal static class Program
    {
        public static void Main()
        {
            var pin = new Pin(12345, "Add meg a PUK kódot");
            pin.GivePin();
            var puk = new Puk(54321, "Vedd fel a kapcsolatot a szolgáltatóval!");
            puk.GivePin();
            
            Console.ReadKey();
        }
    }
}