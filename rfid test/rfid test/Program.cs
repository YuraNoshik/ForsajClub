using Sydesoft.NfcDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rfid_test
{
    internal class Program
    {
        private static ACR122U acr122u = new ACR122U();

        static void Main(string[] args)
        {
            acr122u.Init(false, 50, 4, 4, 200);  // NTAG213
            acr122u.CardInserted += Acr122u_CardInserted;
            acr122u.CardRemoved += Acr122u_CardRemoved;
            Console.ReadLine();
        }

        private static void Acr122u_CardInserted(PCSC.ICardReader reader)
        {
            Console.WriteLine("NFC Transponder wurde aufgelegt.");
            Console.WriteLine("Unique ID: " + BitConverter.ToString(acr122u.GetUID(reader)).Replace("-", ""));
            string data = "Hello World";
            Console.WriteLine("Daten auf NFC Transponder schreiben: " + data);
            bool ret = acr122u.WriteData(reader, Encoding.UTF8.GetBytes(data));
            Console.WriteLine("Schreibvorgang: " + (ret ? "erfolgreich" : "fehlgeschlagen"));
            Console.WriteLine("Daten von NFC Transponder auslesen: " + Encoding.UTF8.GetString(acr122u.ReadData(reader)));
            acr122u.WriteData(reader, Encoding.Unicode.GetBytes(data));
            
        }

        private static void Acr122u_CardRemoved()
        {
            Console.WriteLine("NFC Transponder wurde entfernt.");
        }
    }
}
