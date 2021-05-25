// COD_zombies.Items.Weapons.Mustang_and_Sally
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using COD_zombies.Items;

namespace COD_zombies.Items.Weapons
{
	public class Mustang_and_Sally : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.Tooltip.SetDefault("Mustang and Sally are two dual-wielded M1911 pistols that are mainly used by tank Dempsey as they are his signature weapons.");
			base.DisplayName.SetDefault("Mustang and Sally");
		}

		public override void SetDefaults()
		{
			base.item.damage = 1600;
			base.item.ranged = true;
			base.item.width = 40;
			base.item.height = 20;
			base.item.useTime = 20;
			base.item.useAnimation = 20;
			base.item.useStyle = 5;
			base.item.noMelee = true;
			base.item.knockBack = 4f;
			base.item.value = 1000000;
			base.item.rare = -12;
			base.item.UseSound = SoundID.Item11;
			base.item.autoReuse = true;
			base.item.shoot = 10;
			base.item.shootSpeed = 50f;
			base.item.useAmmo = AmmoID.Bullet;
			base.item.UseSound = base.mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Sally_Shoot");
			base.item.crit = 1000;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddTile(ModContent.TileType<Mystery_Box_Tile>());
			modRecipe.AddIngredient(164);
			modRecipe.AddIngredient(base.mod, "Element_115", 5);
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 286, damage, knockBack, player.whoAmI);
			return true;
		}
	}
}
