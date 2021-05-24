// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Mystery_Box_Tile
using COD_zombies.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

public class Mystery_Box_Tile : ModTile
{
	public override void SetDefaults()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Main.tileSolidTop[((ModTile)this).get_Type()] = true;
		Main.tileFrameImportant[((ModTile)this).get_Type()] = true;
		Main.tileNoAttach[((ModTile)this).get_Type()] = true;
		Main.tileTable[((ModTile)this).get_Type()] = true;
		Main.tileLavaDeath[((ModTile)this).get_Type()] = true;
		((ModTile)this).AddToArray(ref RoomNeeds.CountsAsTable);
		ModTranslation name = ((ModTile)this).CreateMapEntryName((string)null);
		name.SetDefault("Mystery Box");
		((ModTile)this).AddMapEntry(new Color(200, 200, 200), name);
		base.disableSmartCursor = true;
		base.adjTiles = new int[1] { 18 };
		TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
		base.adjTiles = new int[1] { 79 };
		TileObjectData.addTile((int)((ModTile)this).get_Type());
		TileObjectData.newTile.set_CoordinateHeights(new int[2] { 25, 13 });
	}

	public override void NumDust(int i, int j, bool fail, ref int num)
	{
		num = (fail ? 1 : 3);
	}

	public override void KillMultiTile(int i, int j, int frameX, int frameY)
	{
		Item.NewItem(i * 32, j * 32, 32, 32, ModContent.ItemType<Mystery_Box>(), 1, false, 0, false, false);
	}

	public Mystery_Box_Tile()
		: this()
	{
	}
}
