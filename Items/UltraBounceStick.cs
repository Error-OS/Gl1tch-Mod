using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class UltraBounceStick : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("ULTRA BOUNCE STICK"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("BEGONE FROM MY SIGHT");
		}

		public override void SetDefaults() 
		{
			item.damage = 2;
			item.melee = true;
			item.width = 120;
			item.height = 120;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 99999999999999;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item19;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("UltraBounceProjectile");
			item.shootSpeed = 12f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BounceStick", 1);
			recipe.AddIngredient(ItemID.LunarBar, 20);
			recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}