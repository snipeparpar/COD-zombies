using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace COD_zombies.Items
{

	public class Element_Drop : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(2) == 0)
			{
				if (npc.type == NPCID.MoonLordCore)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Element_115"));
				}
			}
		}
	}
}