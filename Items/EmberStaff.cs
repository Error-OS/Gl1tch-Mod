using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Items
{
    public class EmberStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Ember Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A magical staff that spews fiery embers.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.magic = true;
            item.crit = 30;
            item.width = 40;
            item.height = 40;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 10000;
            item.rare = 3;
            item.mana = 2;
            item.UseSound = SoundID.Item21;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("EmberProjectile");
            item.shootSpeed = 16f;
        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)

        {
            for (int i = 0; i < 1; i++)

            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FireGem", 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}