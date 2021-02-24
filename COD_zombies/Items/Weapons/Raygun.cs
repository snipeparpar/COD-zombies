using COD_zombies.Items.Weapons;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ObjectData;

namespace COD_zombies.Items.Weapons
{
	public class Raygun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Raygun");
			Tooltip.SetDefault(" ​It is one of the most iconic Zombies features in the game");
		}

		public override void SetDefaults() {
			item.damage = 1150; 
			item.ranged = true; 
			item.width = 51; 
			item.height = 36;
			item.useTime = 20;
			item.useAnimation = 20; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 4; 
			item.value = 10000; 
			item.rare = ItemRarityID.Expert; 
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Raygun_shoot");
			item.autoReuse = true; 
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

			public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddIngredient(ItemID.FallenStar, 100);
			recipe.AddIngredient(ItemID.LunarBar, 100);
			recipe.AddIngredient(mod, "Element_115", 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}





		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MoonlordBullet, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return false;
	


	
		}
	}
}	