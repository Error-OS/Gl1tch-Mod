using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class MiniPickaxe: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Miniature Pickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This pickaxe is light so it can be used incredibly quickly.");
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
            item.melee = true;
			item.pick = 20;
			item.width = 80;
			item.height = 100;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 200;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;
			item.tileBoost = -2;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddRecipeGroup("IronBar", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}