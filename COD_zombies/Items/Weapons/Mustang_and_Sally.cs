using COD_zombies.Items.Weapons;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ObjectData;

namespace COD_zombies.Items.Weapons
{
	public class Mustang_and_Sally : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Mustang and Sally are two dual-wielded M1911 pistols that are mainly used by tank Dempsey as they are his signature weapons.");
            DisplayName.SetDefault("Mustang and Sally");
		}

		public override void SetDefaults() {
			item.damage = 300; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
			item.useTime = 20; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 20; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 1000000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Expert; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 50f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Bullet;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Sally_Shoot");
		}


	    public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.AddIngredient(ItemID.Handgun, 1);
			recipe.AddIngredient(mod, "Element_115", 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		
        // How can I shoot 2 different projectiles at the same time?
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ExplosiveBullet, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return true;
		}

	}
}