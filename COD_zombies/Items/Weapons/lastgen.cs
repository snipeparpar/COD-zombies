// COD_zombies.Items.Weapons.lastgen
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using COD_zombies.Items;

namespace COD_zombies.Items.Weapons
{
	public class lastgen : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.Tooltip.SetDefault("It can 1 hit Echdeath, but it cant bypass the calamity damage cap");
		}

		public override void SetDefaults()
		{
			base.item.damage = 999999999;
			base.item.ranged = true;
			base.item.width = 40;
			base.item.height = 20;
			base.item.useTime = 0;
			base.item.useAnimation = 0;
			base.item.useStyle = 5;
			base.item.noMelee = true;
			base.item.knockBack = 100000f;
			base.item.value = 1000000;
			base.item.rare = -12;
			base.item.UseSound = base.mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/lastgen");
			base.item.autoReuse = true;
			base.item.shoot = 10;
			base.item.shootSpeed = 30f;
			base.item.useAmmo = AmmoID.Bullet;
			base.item.crit = 999999999;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 19.89f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 30 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30f));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}
}
