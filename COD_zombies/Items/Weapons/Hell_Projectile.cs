// COD_zombies.Items.Weapons.Hell_Projectile
using Terraria.ModLoader;

public class Hell_Projectile : ModProjectile
{
	public override void SetStaticDefaults()
	{
		base.DisplayName.SetDefault("Hell's Retriever");
	}

	public override void SetDefaults()
	{
		base.projectile.width = 22;
		base.projectile.height = 22;
		base.projectile.friendly = true;
		base.projectile.penetrate = -1;
		base.projectile.melee = true;
		base.projectile.aiStyle = 3;
		base.projectile.CloneDefaults(182);
		aiType = 182;
	}
}
