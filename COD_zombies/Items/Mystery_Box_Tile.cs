// COD_zombies.Items.Mystery_Box_Tile
using COD_zombies.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace COD_zombies.Items
{
	public class Mystery_Box_Tile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolidTop[base.Type] = true;
			Main.tileFrameImportant[base.Type] = true;
			Main.tileNoAttach[base.Type] = true;
			Main.tileTable[base.Type] = true;
			Main.tileLavaDeath[base.Type] = true;
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Mystery Box");
			AddMapEntry(new Color(200, 200, 200), name);
			disableSmartCursor = true;
			adjTiles = new int[1] { 18 };
			TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
			adjTiles = new int[1] { 79 };
			TileObjectData.addTile(base.Type);
			TileObjectData.newTile.CoordinateHeights = new int[2] { 25, 13 };
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = (fail ? 1 : 3);
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 32, j * 32, 32, 32, ModContent.ItemType<Mystery_Box>());
		}
	}
}
