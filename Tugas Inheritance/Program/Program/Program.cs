// import namespace
using VGANamespace;
using LaptopNamespace;
using ProcessorNamespace;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.VGA = new Nvidia();
            laptop1.Processor = new CoreI5();

            Laptop laptop2 = new Ideapad();
            laptop2.VGA = new VGANamespace.AMD(); // di VGA ada class AMD dan processor ada kelas AMD jadinya ambigu di errornya. Harus dikasih Namespace buat pembeda
            laptop2.Processor = new Ryzen();

            Predator predator = new Predator();
            predator.VGA = new VGANamespace.AMD();
            predator.Processor = new CoreI7();

            /*
             1. Jalankan method LaptopDinyalakan() dan LaptopDinyalakan() pada laptop2. Apa yang terjadi? Mengapa begitu?
             */
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan(); // method berjalan karena objek laptop2 memiliki tipe data Laptop yang merupakan sebuah class pemilik method laptopDinyalakan dan laptopDimatikan.

            /*
             2. Jalankan method Ngoding() pada laptop1. Apa yang terjadi? Mengapa begitu?
             */
            //laptop1.Ngoding(); // error karena tipe datanya adalah Laptop dan Laptop tidak memiliki method Ngoding.

            /*
             3. Dapatkah Anda menampilkan di console spesifikasi (merk vga, merk processor, tipe processor)apa yang digunakan laptop1? Bagaimana caranya?
             */
            // bisa
            Console.WriteLine($"Laptop {laptop1.Merk} dengan VGA {laptop1.VGA.Merk} dan Processor {laptop1.Processor.Merk} {laptop1.Processor.Tipe}");
            /*
             4. Jalankan method BermainGame() pada predator. Apa yang terjadi? Mengapa begitu?
             */
            predator.BermainGame(); // bisa karena tipe data objek predator adalah Predator itu sendiri dan  memiliki method bermainGame() sehingga dia bisa mengakses method bermainGame().

            /*
             5. Buatlah sebuah variabel acer bertipe data ACER, kemudian masukkan objek predator sebagai nilainya. Jalankan method BermainGame() pada acer. Apa yang terjadi? Mengapa begitu?
             */
            ACER acer = new Predator();
            // acer.BermainGame(); // Error. Karena sekalipun tipe data Acer merupakan parent class dari Predator, tetapi dia tidak memiliki method BermainGame() sehingga dia tidak mengakses method BermainGame(). 
        }
    }
}