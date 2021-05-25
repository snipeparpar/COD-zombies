using COD_zombies.Items;
using COD_zombies.Items.Perks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace COD_zombies.Items
{
	public class ExpertBag : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			// This method shows adding items to Fishrons boss bag. 
			// Typically you'll also want to also add an item to the non-expert boss drops, that code can be found in ExampleGlobalNPC.NPCLoot. Use this and that to add drops to bosses.
			if (context == "bossBag" && arg == ItemID.MoonLordBossBag) ;
			{
				player.QuickSpawnItem(ModContent.ItemType<Element_115>(), Main.rand.Next(2, 0));

				player.QuickSpawnItem(ModContent.ItemType<Juggernog>(), Main.rand.Next(5, 0));

				player.QuickSpawnItem(ModContent.ItemType<DoubleTap1>(), Main.rand.Next(5, 0));

				player.QuickSpawnItem(ModContent.ItemType<SpeedCola>(), Main.rand.Next(5, 0));

				player.QuickSpawnItem(ModContent.ItemType<QuickRevive>(), Main.rand.Next(5, 0));
			}
		}
	}
}