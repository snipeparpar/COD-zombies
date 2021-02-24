  
using COD_zombies.Items.Weapons;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace COD_zombies.Items.Weapons
{
	public class Blundergat : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("First shotgun to shoot very accurate and  first Wonder Weapon to shoot regular bullets.");
            DisplayName.SetDefault("Blundergat");
		}

		public override void SetDefaults() {
			item.damage = 741021; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
			item.useTime = 60; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 60; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 50; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Expert; // the color that the item's name will be in-game
            item.UseSound = SoundID.Item38;
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 8f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
        }		

            public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 6;
            for(int i = 0; i < numberProjectiles; i++)
            {
                Vector2 speed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
                Projectile.NewProjectile(position, speed, type, damage, knockBack, player.whoAmI);
            }

            return false;
        }


        }
	                                        }
    