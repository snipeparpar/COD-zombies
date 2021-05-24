// COD_zombies.Items.Shield
using Terraria.ModLoader;

public class Shield : ModItem
{
	public override void SetStaticDefaults()
	{
		base.Tooltip.SetDefault("this is a test item");
	}

	public override void SetDefaults()
	{
		base.item.width = 24;
		base.item.height = 28;
		base.item.value = 10000;
		base.item.rare = -12;
		base.item.accessory = true;
		base.item.defense = 100;
		base.item.lifeRegen = 100;
		base.item.crit = 100;
	}
}
