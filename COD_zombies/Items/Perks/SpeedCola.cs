using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace COD_zombies.Items.Perks
{

	public class SpeedCola : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Speedcola Machine");
			Tooltip.SetDefault("Living the fast life. That's the way I roll!, Tank Dempsy");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			base.item.createTile = ModContent.TileType<SpeedCola_Machine>();
			item.width = 24;
			item.height = 24;
			item.height = 24;
			item.rare = -12;
			item.value = 100000;
			item.accessory = true;
		}
	}
}
	





















	