// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// COD_zombies.Items.COD_ZM_Damage_Class.Damage_Class
using COD_zombies.Items.COD_ZM_Damage_Class;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

public class Damage_Class : ModPlayer
{
	public float exampleDamageAdd;

	public float exampleDamageMult = 1f;

	public float exampleKnockback;

	public int exampleCrit;

	public int exampleResourceCurrent;

	public const int DefaultExampleResourceMax = 100;

	public int exampleResourceMax;

	public int exampleResourceMax2;

	public float exampleResourceRegenRate;

	internal int exampleResourceRegenTimer;

	public static readonly Color HealExampleResource = new Color(187, 91, 201);

	public static Damage_Class ModPlayer(Player player)
	{
		return player.GetModPlayer<Damage_Class>();
	}

	public override void Initialize()
	{
		exampleResourceMax = 100;
	}

	public override void ResetEffects()
	{
		ResetVariables();
	}

	public override void UpdateDead()
	{
		ResetVariables();
	}

	private void ResetVariables()
	{
		exampleDamageAdd = 0f;
		exampleDamageMult = 1f;
		exampleKnockback = 0f;
		exampleCrit = 0;
		exampleResourceRegenRate = 1f;
		exampleResourceMax2 = exampleResourceMax;
	}

	public override void PostUpdateMiscEffects()
	{
		UpdateResource();
	}

	private void UpdateResource()
	{
		exampleResourceRegenTimer++;
		if ((float)exampleResourceRegenTimer > 180f * exampleResourceRegenRate)
		{
			exampleResourceCurrent++;
			exampleResourceRegenTimer = 0;
		}
		exampleResourceCurrent = Utils.Clamp<int>(exampleResourceCurrent, 0, exampleResourceMax2);
	}

	public Damage_Class()
		: this()
	{
	}
}
