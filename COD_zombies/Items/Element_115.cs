// COD_zombies.Items.Element_115
using Terraria.ModLoader;

public class Element_115 : ModItem
{
	public override void SetStaticDefaults()
	{
		base.DisplayName.SetDefault("Element 115");
		base.Tooltip.SetDefault(" The first meteor discovered was at the Rising Sun facility in Japan, in the map Shi No Numa");
	}

	public override void SetDefaults()
	{
		base.item.width = 20;
		base.item.height = 20;
		base.item.maxStack = 999;
		base.item.value = 1000000000;
		base.item.rare = -12;
	}
}
