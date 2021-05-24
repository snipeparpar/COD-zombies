// COD_zombies.Items.Weapons.Raygun
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Raygun : ModItem
{
	public override void SetStaticDefaults()
	{
		base.DisplayName.SetDefault("Raygun");
		base.Tooltip.SetDefault(" \u200bIt is one of the most iconic Zombies features in the game");
	}

	public override void SetDefaults()
	{
		base.item.damage = 2400;
		base.item.ranged = true;
		base.item.width = 51;
		base.item.height = 36;
		base.item.useTime = 20;
		base.item.useAnimation = 20;
		base.item.useStyle = 5;
		base.item.noMelee = true;
		base.item.knockBack = 4f;
		base.item.value = 10000;
		base.item.rare = -12;
		base.item.UseSound = base.mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Raygun_Shoot");
		base.item.autoReuse = true;
		base.item.shoot = 10;
		base.item.shootSpeed = 16f;
		base.item.useAmmo = AmmoID.Bullet;
		base.item.crit = 1150;
	}

	public override void AddRecipes()
	{
		ModRecipe modRecipe = new ModRecipe(base.mod);
		modRecipe.AddTile(412);
		modRecipe.AddIngredient(127);
		modRecipe.AddIngredient(75, 100);
		modRecipe.AddIngredient(3467, 100);
		modRecipe.AddIngredient(base.mod, "Element_115", 12);
		modRecipe.SetResult(this);
		modRecipe.AddRecipe();
	}

	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	{
		Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 638, damage, knockBack, player.whoAmI);
		return false;
	}
}
