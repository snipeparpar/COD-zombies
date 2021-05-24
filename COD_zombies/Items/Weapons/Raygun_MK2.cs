// COD_zombies.Items.Weapons.Raygun_MK2
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Raygun_MK2 : ModItem
{
	public override void SetStaticDefaults()
	{
		base.Tooltip.SetDefault("It is the successor and the evolution of the Ray Gun");
		base.Tooltip.SetDefault("unlike its predecessor, the Ray Gun Mark II fires in three-round bursts with no splash damage.");
		base.Tooltip.SetDefault("It also has a very high penetration ability, capable of killing many zombies with one burst");
		base.DisplayName.SetDefault("Raygun MK2");
	}

	public override void SetDefaults()
	{
		base.item.damage = 935;
		base.item.ranged = true;
		base.item.width = 40;
		base.item.height = 20;
		base.item.useAnimation = 12;
		base.item.useTime = 4;
		base.item.reuseDelay = 14;
		base.item.useStyle = 5;
		base.item.noMelee = true;
		base.item.knockBack = 4f;
		base.item.value = 10000;
		base.item.rare = -12;
		base.item.UseSound = base.mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Raygun_ShootMK2");
		base.item.autoReuse = true;
		base.item.shoot = 10;
		base.item.shootSpeed = 16f;
		base.item.useAmmo = AmmoID.Bullet;
	}

	public override void AddRecipes()
	{
		ModRecipe modRecipe = new ModRecipe(base.mod);
		modRecipe.AddTile(412);
		modRecipe.AddIngredient(514);
		modRecipe.AddIngredient(75, 500);
		modRecipe.AddIngredient(3467, 200);
		modRecipe.AddIngredient(base.mod, "Element_115", 20);
		modRecipe.SetResult(this);
		modRecipe.AddRecipe();
	}

	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	{
		Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 638, damage, knockBack, player.whoAmI);
		return false;
	}
}
