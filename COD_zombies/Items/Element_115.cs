// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.Element_115
using Terraria;
using Terraria.ModLoader;

public class Element_115 : ModItem
{
	public override void SetStaticDefaults()
	{
		((ModItem)this).get_DisplayName().SetDefault("Element 115");
		((ModItem)this).get_Tooltip().SetDefault(" The first meteor discovered was at the Rising Sun facility in Japan, in the map Shi No Numa");
	}

	public override void SetDefaults()
	{
		((Entity)((ModItem)this).get_item()).width = 20;
		((Entity)((ModItem)this).get_item()).height = 20;
		((ModItem)this).get_item().maxStack = 999;
		((ModItem)this).get_item().value = 1000000000;
		((ModItem)this).get_item().rare = -12;
	}

	public Element_115()
		: this()
	{
	}
}
