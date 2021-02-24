  
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using COD_zombies.Items.Weapons;





namespace COD_zombies.Items.Weapons
{
	public class Hell : ModItem
	{

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hell's Retriever");
            Tooltip.SetDefault("The Hell's Retriever is a wonder weapon and a tactical item featured in the Zombies map, Mob of the Dead");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.sellPrice(gold: 10);
			item.rare = ItemRarityID.Expert;
			item.noMelee = false;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 20;
			item.useTime = 20;
			item.knockBack = 4f;
			item.damage = 3000;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("Hell_Projectile");
			item.shootSpeed = 15.1f;
			item.melee = false;
			item.crit = 80;
		}





	}
}























namespace COD_zombies.Items.Weapons
{
	public class Hell_Projectile : ModProjectile
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hell's Retriever");
		}

		public override void SetDefaults()
		{
			projectile.width = 22;
			projectile.height = 22;
			projectile.friendly = true;
			projectile.penetrate = -1; // Make the flail infinitely penetrate like other flails
			projectile.melee = true;
			projectile.aiStyle = 3;
		    projectile.CloneDefaults(ProjectileID.PossessedHatchet);
            aiType = ProjectileID.PossessedHatchet;
        
        }







	}
}
