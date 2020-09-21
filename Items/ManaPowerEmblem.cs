using System;
using System.Collections.Generic;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class ManaPowerEmblem : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mana Power Emblem"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Magic damage changes based on mana. max mana doubles damage, zero negates it, etc.");
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
			if (player.statMana > 0)
            {
				player.magicDamage = ((player.magicDamage * ((player.statMana * 2) / (player.statManaMax / 100)) / 100));
			}
			else
            {
				player.magicDamage = 0;
            }
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sapphire, 4);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}