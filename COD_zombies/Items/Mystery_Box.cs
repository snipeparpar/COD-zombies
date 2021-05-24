// COD_zombies.Items.Mystery_Box
using COD_zombies.Items;
using Terraria.ModLoader;

public class Mystery_Box : ModItem
{
	public override void SetStaticDefaults()
	{
		base.Tooltip.SetDefault("When the box is opened, a small music-box like music will play, and will stop just after the weapon appears.");
		base.DisplayName.SetDefault("Mystery Box");
	}

	public override void SetDefaults()
	{
		base.item.width = 25;
		base.item.height = 12;
		base.item.maxStack = 99;
		base.item.useTurn = true;
		base.item.autoReuse = true;
		base.item.useAnimation = 15;
		base.item.useTime = 10;
		base.item.useStyle = 1;
		base.item.consumable = true;
		base.item.value = 150;
		base.item.createTile = ModContent.TileType<Mystery_Box_Tile>();
	}

	public override void AddRecipes()
	{
		ModRecipe modRecipe = new ModRecipe(base.mod);
		modRecipe.AddTile(412);
		modRecipe.AddIngredient(9, 115);
		modRecipe.AddIngredient(501, 20);
		modRecipe.AddIngredient(75, 40);
		modRecipe.AddIngredient(74);
		modRecipe.SetResult(this);
		modRecipe.AddRecipe();
	}
}
