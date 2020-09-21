using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class SlimeGem : ModItem
	{
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("SlimeGem"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Magical crystalized slime. Avoid fire.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = 300000;
            item.rare = 2;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "WaterGem", 1);
            recipe.AddIngredient(ItemID.Gel, 60);
            recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}