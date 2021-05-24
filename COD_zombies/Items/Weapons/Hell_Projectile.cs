// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Weapons.Hell_Projectile
using Terraria;
using Terraria.ModLoader;

public class Hell_Projectile : ModProjectile
{
	public override void SetStaticDefaults()
	{
		((ModProjectile)this).get_DisplayName().SetDefault("Hell's Retriever");
	}

	public override void SetDefaults()
	{
		((Entity)((ModProjectile)this).get_projectile()).width = 22;
		((Entity)((ModProjectile)this).get_projectile()).height = 22;
		((ModProjectile)this).get_projectile().friendly = true;
		((ModProjectile)this).get_projectile().penetrate = -1;
		((ModProjectile)this).get_projectile().melee = true;
		((ModProjectile)this).get_projectile().aiStyle = 3;
		((ModProjectile)this).get_projectile().CloneDefaults(182);
		base.aiType = 182;
	}

	public Hell_Projectile()
		: this()
	{
	}
}
