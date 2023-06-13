using PolymorphismInter;

internal class Program
{
    static void Main(string[] args)
    {
        PrinterWindows printerWindows = new PrinterWindows();
        Console.WriteLine("Silakan pilih jenis hewan berikut :");
        Console.WriteLine("1. Epson ");
        Console.WriteLine("2. Canon");
        Console.WriteLine("3. LaserJet");

        Console.Write("No berapa yang kamu pilih 1...3 :");
        int pilihan = Convert.ToInt32(Console.ReadLine());
        printerWindows.Jenis = pilihan;

        //deklarasi 
        IPrinter speak;
        IPrinter show;

        //Pengkondisian
        if (printerWindows.Jenis == 1)
            speak = new Epson();
        else if (printerWindows.Jenis == 2)
            speak = new Canon();
        else
            speak = new LaserJet();

        speak.Speak(printerWindows);
        Console.ReadLine();
    }
}