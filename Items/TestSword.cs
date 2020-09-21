using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("plz don use this.");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 300;
			item.useAnimation = 300;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 0;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 99);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}