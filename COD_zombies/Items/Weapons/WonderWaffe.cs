// COD_zombies.Items.Weapons.WonderWaffe
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class WonderWaffe : ModItem
{
	public override void SetStaticDefaults()
	{
		base.Tooltip.SetDefault("German for: Wonder Weapon DG-2 is the second Wonder Weapon in zombies and its considered the best weapon in Zombies.");
		base.DisplayName.SetDefault("WonderWaffe DG-2");
	}

	public override void SetDefaults()
	{
		base.item.damage = 5000;
		base.item.magic = true;
		base.item.mana = 12;
		base.item.width = 40;
		base.item.height = 40;
		base.item.useTime = 40;
		base.item.useAnimation = 40;
		base.item.useStyle = 5;
		base.item.noMelee = true;
		base.item.knockBack = 5f;
		base.item.value = 10000000;
		base.item.rare = -12;
		base.item.UseSound = SoundID.Item20;
		base.item.autoReuse = true;
		base.item.shoot = 254;
		base.item.shootSpeed = 1f;
		base.item.crit = 500;
	}

	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	{
		Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 254, damage, knockBack, player.whoAmI);
		return true;
	}
}
