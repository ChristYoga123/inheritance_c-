namespace VGANamespace
{
    class VGA
    {
        public string Merk;
    }

    class Nvidia : VGA
    {
        public Nvidia()
        {
            base.Merk = "Nvidia";
        }
    }

    class AMD : VGA
    {
        public AMD()
        {
            base.Merk = "AMD";
        }
    }
}
