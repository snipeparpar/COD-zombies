// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Weapons.Raygun_MK2
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Raygun_MK2 : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_Tooltip().SetDefault("It is the successor and the evolution of the Ray Gun");
		((ModItem)this).get_Tooltip().SetDefault("unlike its predecessor, the Ray Gun Mark II fires in three-round bursts with no splash damage.");
		((ModItem)this).get_Tooltip().SetDefault("It also has a very high penetration ability, capable of killing many zombies with one burst");
		((ModItem)this).get_DisplayName().SetDefault("Raygun MK2");
	}

	public override void SetDefaults()
	{
		((ModItem)this).get_item().damage = 935;
		((ModItem)this).get_item().ranged = true;
		((Entity)((ModItem)this).get_item()).width = 40;
		((Entity)((ModItem)this).get_item()).height = 20;
		((ModItem)this).get_item().useAnimation = 12;
		((ModItem)this).get_item().useTime = 4;
		((ModItem)this).get_item().reuseDelay = 14;
		((ModItem)this).get_item().useStyle = 5;
		((ModItem)this).get_item().noMelee = true;
		((ModItem)this).get_item().knockBack = 4f;
		((ModItem)this).get_item().value = 10000;
		((ModItem)this).get_item().rare = -12;
		((ModItem)this).get_item().UseSound = ((ModItem)this).get_mod().GetLegacySoundSlot((SoundType)2, "Sounds/Item/Raygun_ShootMK2");
		((ModItem)this).get_item().autoReuse = true;
		((ModItem)this).get_item().shoot = 10;
		((ModItem)this).get_item().shootSpeed = 16f;
		((ModItem)this).get_item().useAmmo = AmmoID.Bullet;
	}

	public override void AddRecipes()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		ModRecipe val = new ModRecipe(((ModItem)this).get_mod());
		val.AddTile(412);
		val.AddIngredient(514, 1);
		val.AddIngredient(75, 500);
		val.AddIngredient(3467, 200);
		val.AddIngredient(((ModItem)this).get_mod(), "Element_115", 20);
		val.SetResult((ModItem)(object)this, 1);
		val.AddRecipe();
	}

	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	{
		Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 638, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
		return false;
	}

	public Raygun_MK2()
		: this()
	{
	}
}
