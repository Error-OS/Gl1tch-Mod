using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class WaterGem : ModItem
	{
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("WaterGem"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("If you listen closely you can hear waves coming from the inside. For some reason it's kind of hard to carry.");
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
            recipe.AddIngredient(ItemID.Sapphire, 3);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.Tuna, 1);
            recipe.AddIngredient(ItemID.Shrimp, 1);
            recipe.AddIngredient(ItemID.Trout, 1);
            recipe.AddIngredient(ItemID.RedSnapper, 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}