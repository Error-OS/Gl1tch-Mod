using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
    public class FireShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shotgun of Fire"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A magical fiery shotgun that fires fireballs in fiery bursts. Did i mention the fire?.");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.magic = true;
            item.crit = 30;
            item.width = 40;
            item.height = 40;
            item.useTime = 60;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 12;
            item.value = 10000;
            item.rare = 3;
            item.mana = 20;
            item.UseSound = SoundID.Item21;
            item.autoReuse = true;
            item.shoot = 15;
            item.shootSpeed = 16f;
        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)

        {
            for (int i = 0; i < 4; i++)

            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "EmberStaff", 1);
            recipe.AddIngredient(ItemID.FlowerofFire, 1);
            recipe.AddIngredient(ItemID.Shotgun, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}