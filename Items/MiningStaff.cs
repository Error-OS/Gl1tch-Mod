using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class MiningStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Staff of Mining"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Because who needs pickaxes am I right?");
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
            item.magic = true;
			item.noMelee = true;
			item.mana = 5;
			item.pick = 55;
			item.width = 80;
			item.height = 100;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 4;
			item.knockBack = 0;
			item.value = 20000;
			item.rare = 3;
			item.UseSound = SoundID.Item8;
            item.autoReuse = true;
			item.tileBoost = 4;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 5);
			recipe.AddIngredient(ItemID.StoneBlock, 60);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}