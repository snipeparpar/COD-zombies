// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Weapons.Blundergat
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Blundergat : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_Tooltip().SetDefault("First shotgun to shoot very accurate and  first Wonder Weapon to shoot regular bullets.");
		((ModItem)this).get_DisplayName().SetDefault("Blundergat");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 741021;
		((ModItem)this).get_item().ranged = true;
		((Entity)((ModItem)this).get_item()).width = 40;
		((Entity)((ModItem)this).get_item()).height = 20;
		((ModItem)this).get_item().useTime = 60;
		((ModItem)this).get_item().useAnimation = 60;
		((ModItem)this).get_item().useStyle = 5;
		((ModItem)this).get_item().noMelee = true;
		((ModItem)this).get_item().knockBack = 50f;
		((ModItem)this).get_item().value = 10000;
		((ModItem)this).get_item().rare = -12;
		((ModItem)this).get_item().UseSound = SoundID.Item38;
		((ModItem)this).get_item().autoReuse = true;
		((ModItem)this).get_item().shoot = 10;
		((ModItem)this).get_item().shootSpeed = 8f;
		((ModItem)this).get_item().useAmmo = AmmoID.Bullet;
	}

	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int numberProjectiles = 6;
		for (int i = 0; i < numberProjectiles; i++)
		{
			Vector2 speed = Utils.RotatedByRandom(new Vector2(speedX, speedY), (double)MathHelper.ToRadians(2f));
			Projectile.NewProjectile(position, speed, type, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
		}
		return false;
	}

	public Blundergat()
		: this()
	{
	}
}
