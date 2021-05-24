// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Weapons.WonderWaffe
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class WonderWaffe : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_Tooltip().SetDefault("German for: Wonder Weapon DG-2 is the second Wonder Weapon in zombies and its considered the best weapon in Zombies.");
		((ModItem)this).get_DisplayName().SetDefault("WonderWaffe DG-2");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 5000;
		((ModItem)this).get_item().magic = true;
		((ModItem)this).get_item().mana = 12;
		((Entity)((ModItem)this).get_item()).width = 40;
		((Entity)((ModItem)this).get_item()).height = 40;
		((ModItem)this).get_item().useTime = 40;
		((ModItem)this).get_item().useAnimation = 40;
		((ModItem)this).get_item().useStyle = 5;
		((ModItem)this).get_item().noMelee = true;
		((ModItem)this).get_item().knockBack = 5f;
		((ModItem)this).get_item().value = 10000000;
		((ModItem)this).get_item().rare = -12;
		((ModItem)this).get_item().UseSound = SoundID.Item20;
		((ModItem)this).get_item().autoReuse = true;
		((ModItem)this).get_item().shoot = 254;
		((ModItem)this).get_item().shootSpeed = 1f;
		((ModItem)this).get_item().crit = 500;
	}

	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	{
		Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 254, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
		return true;
	}

	public WonderWaffe()
		: this()
	{
	}
}
