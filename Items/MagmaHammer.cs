using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class MagmaHammer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MagmaHammer"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A great hammer that uses fiery magic with every swing!");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
            item.melee = true;
			item.mana = 60;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 600000;
            item.rare = 3;
            item.UseSound = SoundID.Item7;
            item.autoReuse = false;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 5 * 60);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FireGem", 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}