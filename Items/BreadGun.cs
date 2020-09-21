using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
	public class BreadGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault(""); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Sprite By EncryptGaming. It also IS EncryptGaming.");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.ranged = true;
			item.shoot = 207;
			item.shootSpeed = 16f;
			item.width = 120;
			item.height = 120;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 0;
			item.rare = -12;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
		}
	}
}