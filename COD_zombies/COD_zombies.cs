using Terraria.ModLoader;

namespace COD_zombies
{
    class COD_zombies : Mod
    {
        public COD_zombies()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}