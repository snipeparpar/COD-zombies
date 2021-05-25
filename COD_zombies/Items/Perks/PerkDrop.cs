using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace COD_zombies.Items
{

	public class PerkDrop : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(5) == 0)
			{
				if (npc.type == NPCID.MoonLordCore)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Juggernog"));

					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DoubleTap1"));

					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SpeedCola"));

					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("QuickRevive"));
				}
			}
		}
	}
}