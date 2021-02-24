using COD_zombies.Items;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using System;
using Terraria.ObjectData;

namespace COD_zombies.Items
{
	public class Mystery_Box : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("When the box is opened, a small music-box like music will play, and will stop just after the weapon appears.");
            DisplayName.SetDefault("Mystery Box");
		}

		public override void SetDefaults() {
			item.width = 25;
			item.height = 12;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.createTile = ModContent.TileType<Items.Mystery_Box_Tile>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.AddIngredient(ItemID.Wood, 115);
            recipe.AddIngredient(ItemID.PixieDust, 20);
            recipe.AddIngredient(ItemID.FallenStar, 40);
            recipe.AddIngredient(ItemID.PlatinumCoin, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}






namespace COD_zombies.Items
{
	public class Mystery_Box_Tile : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = true;
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Mystery Box");
			AddMapEntry(new Color(200, 200, 200), name);
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.WorkBenches };
			TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
			adjTiles = new int[] { TileID.Beds };
			TileObjectData.addTile(Type);
			TileObjectData.newTile.CoordinateHeights = new[] { 25, 13 };
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 32, j * 32, 32, 32, ModContent.ItemType<Items.Mystery_Box>());
		}
	}
}