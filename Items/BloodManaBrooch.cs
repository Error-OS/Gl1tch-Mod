using System;
using System.Collections.Generic;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class BloodManaBrooch : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blood Mana Brooch"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Increases magic damage and converts health to mana.");
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
			player.magicDamage += 0.5f;
			if (player.statMana < (int)player.statManaMax)
			{
				if (player.statLife > 1)
                {
					player.statLife -= 1;
					player.statMana += 1;
				}
			}
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 4);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}