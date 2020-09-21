using System;
using System.Collections.Generic;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class CubeofRisk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cube of Risk"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Has a high chance to negate damage, if it doesn't you die.");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.accessory = true;
			item.value = 10000;
			item.rare = 4;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{

		}
	}
}