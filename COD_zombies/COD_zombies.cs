using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

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




        public override void Load()
        {
            if (!Main.dedServ)
            {
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Juggernog"), ItemType("Juggernog"), TileType("Juggernog_Machine"));

                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Doubletap"), ItemType("DoubleTap1"), TileType("DoubleTap1_Machine"));

                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SpeedCola"), ItemType("SpeedCola"), TileType("SpeedCola_Machine"));

                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/QuickRevive"), ItemType("QuickRevive"), TileType("QuickRevive_Machine"));
            }
        }
    }
}
    
   