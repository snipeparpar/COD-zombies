using COD_zombies.Items.Weapons;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace COD_zombies.Items.Weapons
{
	public class Raygun_MK2 : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("It is the successor and the evolution of the Ray Gun");
            Tooltip.SetDefault("unlike its predecessor, the Ray Gun Mark II fires in three-round bursts with no splash damage.");
            Tooltip.SetDefault("It also has a very high penetration ability, capable of killing many zombies with one burst");
            DisplayName.SetDefault("Raygun MK2");
            }

		public override void SetDefaults() {
			item.damage = 935; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
            item.useAnimation = 12;
			item.useTime = 4;
			item.reuseDelay = 14;
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Expert; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item12; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}



			public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.AddIngredient(ItemID.LaserRifle, 1);
			recipe.AddIngredient(ItemID.FallenStar, 500);
			recipe.AddIngredient(ItemID.LunarBar, 200);
			recipe.AddIngredient(mod, "Element_115", 20);
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
