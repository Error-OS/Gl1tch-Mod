using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class FireGem : ModItem
	{
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("FireGem"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This gem is glowing with fiery energy. You might wanna consider using gloves.");
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
            recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddIngredient(ItemID.MagmaStone, 1);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}