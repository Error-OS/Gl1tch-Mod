using System;
using System.Collections.Generic;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class MagicHealingPin : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Magic Healing Pin"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Inefficiently converts mana to health.");
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
			if (player.statLife < (int)player.statLifeMax)
			{
				if (player.statMana >= 4)
                {
					player.statLife += 1;
					player.statMana -= 4;
				}
			}
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 4);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}