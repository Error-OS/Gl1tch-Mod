using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class ErrorGun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Error"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Error");
		}

		public override void SetDefaults() 
		{
			item.damage = 200;
            item.summon = true;
			item.shoot = mod.ProjectileType("petergriffin");
			item.shootSpeed = 14f;
			item.width = 32;
			item.height = 32;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 5;
            item.knockBack = -6;
			item.value = 0;
			item.rare = -12;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
		}
	}
}