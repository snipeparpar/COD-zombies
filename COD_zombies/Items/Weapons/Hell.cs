// COD_zombies.Items.Weapons.Hell
using Terraria;
using Terraria.ModLoader;
using COD_zombies.Items;


namespace COD_zombies.Items.Weapons
{
	public class Hell : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Hell's Retriever");
			base.Tooltip.SetDefault("The Hell's Retriever is a wonder weapon and a tactical item featured in the Zombies map, Mob of the Dead");
		}

		public override void SetDefaults()
		{
			base.item.width = 22;
			base.item.height = 20;
			base.item.value = Item.sellPrice(0, 10);
			base.item.rare = -12;
			base.item.noMelee = false;
			base.item.useStyle = 5;
			base.item.useAnimation = 5;
			base.item.useTime = 5;
			base.item.knockBack = 4f;
			base.item.damage = 5000;
			base.item.noUseGraphic = true;
			base.item.shoot = base.mod.ProjectileType("Hell_Projectile");
			base.item.shootSpeed = 15.1f;
			base.item.melee = false;
			base.item.crit = 500;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddTile(ModContent.TileType<Mystery_Box_Tile>());
			modRecipe.AddIngredient(1122);
			modRecipe.AddIngredient(207);
			modRecipe.AddIngredient(175, 35);
			modRecipe.AddIngredient(3467, 50);
			modRecipe.AddIngredient(base.mod, "Element_115", 25);
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}


	}

}