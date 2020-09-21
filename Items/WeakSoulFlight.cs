using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class WeakSoulFlight : ModItem
	{
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Weak Soul of Flight"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A weak soul of a flying creature.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 99;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofFlight, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();
		}
	}
}