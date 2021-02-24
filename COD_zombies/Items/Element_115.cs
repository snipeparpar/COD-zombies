using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace COD_zombies.Items
{
	public class Element_115 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Element 115");
			Tooltip.SetDefault(" The first meteor discovered was at the Rising Sun facility in Japan, in the map Shi No Numa");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000000000;
			item.rare = ItemRarityID.Expert;
			}
		}
	}
