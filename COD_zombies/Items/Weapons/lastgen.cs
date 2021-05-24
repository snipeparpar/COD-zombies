// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Weapons.lastgen
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class lastgen : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_Tooltip().SetDefault("It can 1 hit Echdeath, but it cant bypass the calamity damage cap");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 999999999;
		((ModItem)this).get_item().ranged = true;
		((Entity)((ModItem)this).get_item()).width = 40;
		((Entity)((ModItem)this).get_item()).height = 20;
		((ModItem)this).get_item().useTime = 0;
		((ModItem)this).get_item().useAnimation = 0;
		((ModItem)this).get_item().useStyle = 5;
		((ModItem)this).get_item().noMelee = true;
		((ModItem)this).get_item().knockBack = 100000f;
		((ModItem)this).get_item().value = 1000000;
		((ModItem)this).get_item().rare = -12;
		((ModItem)this).get_item().UseSound = ((ModItem)this).get_mod().GetLegacySoundSlot((SoundType)2, "Sounds/Item/lastgen");
		((ModItem)this).get_item().autoReuse = true;
		((ModItem)this).get_item().shoot = 10;
		((ModItem)this).get_item().shootSpeed = 16f;
		((ModItem)this).get_item().useAmmo = AmmoID.Bullet;
		((ModItem)this).get_item().crit = 999999999;
	}

	public override bool ConsumeAmmo(Player player)
	{
		return Utils.NextFloat(Main.rand) >= 19.89f;
	}

	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		int numberProjectiles = 30 + Main.rand.Next(2);
		for (int i = 0; i < numberProjectiles; i++)
		{
			Vector2 perturbedSpeed = Utils.RotatedByRandom(new Vector2(speedX, speedY), (double)MathHelper.ToRadians(30f));
			Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
		}
		return false;
	}

	public lastgen()
		: this()
	{
	}
}
