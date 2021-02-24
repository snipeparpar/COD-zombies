using COD_zombies.Items.Weapons;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ObjectData;

namespace COD_zombies.Items.Weapons
{
	public class WonderWaffe : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("German for: Wonder Weapon DG-2 is the second Wonder Weapon in zombies and its considered the best weapon in Zombies.");
            DisplayName.SetDefault("WonderWaffe DG-2");


		}

		public override void SetDefaults() {
			item.damage = 1000;
			item.magic = true;
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000000;
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.MagnetSphereBall;
			item.shootSpeed = 1f;
		}

  // How can I shoot 2 different projectiles at the same time?
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MagnetSphereBall, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return true;
		}




	}
}