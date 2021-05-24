// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Shield
using Terraria;
using Terraria.ModLoader;

public class Shield : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_Tooltip().SetDefault("this is a test item");
	}

	public override void SetDefaults()
	{
		((Entity)((ModItem)this).get_item()).width = 24;
		((Entity)((ModItem)this).get_item()).height = 28;
		((ModItem)this).get_item().value = 10000;
		((ModItem)this).get_item().rare = -12;
		((ModItem)this).get_item().accessory = true;
		((ModItem)this).get_item().defense = 100;
		((ModItem)this).get_item().lifeRegen = 100;
		((ModItem)this).get_item().crit = 100;
	}

	public Shield()
		: this()
	{
	}
}
