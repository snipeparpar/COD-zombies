// COD_zombies.Items.Weapons.Blundergat
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using COD_zombies.Items;

namespace COD_zombies.Items.Weapons
{
	public class Blundergat : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.Tooltip.SetDefault("First shotgun to shoot very accurate and  first Wonder Weapon to shoot regular bullets.");
			base.DisplayName.SetDefault("Blundergat");
		}

		public override void SetDefaults()
		{
			base.item.damage = 741021;
			base.item.ranged = true;
			base.item.width = 40;
			base.item.height = 20;
			base.item.useTime = 60;
			base.item.useAnimation = 60;
			base.item.useStyle = 5;
			base.item.noMelee = true;
			base.item.knockBack = 50f;
			base.item.value = 10000;
			base.item.rare = -12;
			base.item.UseSound = SoundID.Item38;
			base.item.autoReuse = true;
			base.item.shoot = 10;
			base.item.shootSpeed = 8f;
			base.item.useAmmo = AmmoID.Bullet;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 6;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 speed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2f));
				Projectile.NewProjectile(position, speed, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}

}