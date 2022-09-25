using VGANamespace;
using ProcessorNamespace;
namespace LaptopNamespace
{
    class Laptop
    {
        public string Merk, Tipe;
        public VGA VGA; // using VGA namespace from VGA.cs
        public Processor Processor; // using Processor namespace from Processor.cs

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {this.Merk} {this.Tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {this.Merk} {this.Tipe} mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.Merk = "ASUS";
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            base.Merk = "ACER";
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.Merk = "Lenovo";
        }
    }

    class ROG : ASUS
    {
        public ROG()
        {
            base.Tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.Tipe = "Vivobook";
        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.Tipe = "Swift";
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.Tipe = "Predator";
        }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {base.Merk} {base.Tipe} sedang memainkan game.");
        }
    }

    class Ideapad : Lenovo
    {
        public Ideapad()
        {
            base.Tipe = "Ideapad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.Tipe = "Legion";
        }
    }

    
}
