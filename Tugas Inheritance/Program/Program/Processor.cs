namespace ProcessorNamespace
{
    class Processor
    {
        public string Merk, Tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.Merk = "Intel";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            base.Merk = "AMD";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.Tipe = "Core I3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.Tipe = "Core I5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.Tipe = "Core I7";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.Tipe = "Rayzen";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            base.Tipe = "Athlon";
        }
    }
}
