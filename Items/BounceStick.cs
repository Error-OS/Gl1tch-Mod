using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class BounceStick : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Bounce Stick"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Does this qualify as a weapon? I guess you could knock enemies away with it...");
		}

		public override void SetDefaults() 
		{
			item.damage = 2;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item19;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkGel, 20);
			recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}