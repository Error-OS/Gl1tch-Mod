using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
    public class IceCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Cannon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Fires a concentrated blast of ice-fireballs.");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.magic = true;
            item.crit = 30;
            item.width = 40;
            item.height = 40;
            item.useTime = 100;
            item.useAnimation = 100;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 12;
            item.value = 10000;
            item.rare = 3;
            item.mana = 80;
            item.UseSound = SoundID.Item36;
            item.autoReuse = true;
            item.shoot = 253;
            item.shootSpeed = 22f;
        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)

        {
            for (int i = 0; i < 10; i++)

            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(3));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FireShotgun", 1);
            recipe.AddIngredient(ItemID.FlowerofFrost, 1);
            recipe.AddIngredient(ItemID.Cannon, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}