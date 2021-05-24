// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Weapons.Hell
using Terraria;
using Terraria.ModLoader;

public class Hell : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("Hell's Retriever");
		((ModItem)this).get_Tooltip().SetDefault("The Hell's Retriever is a wonder weapon and a tactical item featured in the Zombies map, Mob of the Dead");
	}

	public override void SetDefaults()
	{
		((Entity)((ModItem)this).get_item()).width = 22;
		((Entity)((ModItem)this).get_item()).height = 20;
		((ModItem)this).get_item().value = Item.sellPrice(0, 10, 0, 0);
		((ModItem)this).get_item().rare = -12;
		((ModItem)this).get_item().noMelee = false;
		((ModItem)this).get_item().useStyle = 5;
		((ModItem)this).get_item().useAnimation = 5;
		((ModItem)this).get_item().useTime = 5;
		((ModItem)this).get_item().knockBack = 4f;
		((ModItem)this).get_item().damage = 5000;
		((ModItem)this).get_item().noUseGraphic = true;
		((ModItem)this).get_item().shoot = ((ModItem)this).get_mod().ProjectileType("Hell_Projectile");
		((ModItem)this).get_item().shootSpeed = 15.1f;
		((ModItem)this).get_item().melee = false;
		((ModItem)this).get_item().crit = 500;
	}

	public Hell()
		: this()
	{
	}
}
