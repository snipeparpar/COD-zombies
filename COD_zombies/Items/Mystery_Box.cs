// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Mystery_Box
using COD_zombies.Items;
using Terraria;
using Terraria.ModLoader;

public class Mystery_Box : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_Tooltip().SetDefault("When the box is opened, a small music-box like music will play, and will stop just after the weapon appears.");
		((ModItem)this).get_DisplayName().SetDefault("Mystery Box");
	}

	public override void SetDefaults()
	{
		((Entity)((ModItem)this).get_item()).width = 25;
		((Entity)((ModItem)this).get_item()).height = 12;
		((ModItem)this).get_item().maxStack = 99;
		((ModItem)this).get_item().useTurn = true;
		((ModItem)this).get_item().autoReuse = true;
		((ModItem)this).get_item().useAnimation = 15;
		((ModItem)this).get_item().useTime = 10;
		((ModItem)this).get_item().useStyle = 1;
		((ModItem)this).get_item().consumable = true;
		((ModItem)this).get_item().value = 150;
		((ModItem)this).get_item().createTile = ModContent.TileType<Mystery_Box_Tile>();
	}

	public override void AddRecipes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		ModRecipe val = new ModRecipe(((ModItem)this).get_mod());
		val.AddTile(412);
		val.AddIngredient(9, 115);
		val.AddIngredient(501, 20);
		val.AddIngredient(75, 40);
		val.AddIngredient(74, 1);
		val.SetResult((ModItem)(object)this, 1);
		val.AddRecipe();
	}

	public Mystery_Box()
		: this()
	{
	}
}
