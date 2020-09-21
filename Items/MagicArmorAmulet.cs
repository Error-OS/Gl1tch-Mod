using System;
using System.Collections.Generic;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class MagicArmorAmulet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Magic Armor Amulet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Uses mana to protect you."
				+ " Makes you more vulnerable if you have no mana");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.accessory = true;
			item.value = 10000;
			item.rare = 4;
			item.defense = -5;
		}
		 
		public override void UpdateEquip(Player player)
		{
			if (player.statMana > 4)
			{
				item.defense = 10;
				player.statMana -= 1;                 
			}
			else
            {
				item.defense = -5;
            }
		}
	}
}