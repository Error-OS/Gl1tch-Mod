using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Projectiles
{
    public class petergriffin : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 300;
            projectile.height = 600;
            projectile.friendly = true;
            projectile.penetrate = 9999999;
            Main.projFrames[projectile.type] = 1;
            projectile.hostile = false;
            projectile.minion = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            aiType = 1;
        }

        public override void AI()
        {
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;
            float heyBeter = 0;
            projectile.velocity.X = heyBeter;
            projectile.velocity.Y = heyBeter;

            if (projectile.localAI[0] > 1000f)
            {
                projectile.Kill();
            }
            else
            {
                if (Main.rand.Next(2) == 0)
                {
                    projectile.velocity.X = 100;
                }
                else
                {
                    projectile.velocity.X = 100;
                }
            }

        }

        public override bool PreDraw(SpriteBatch sb, Color red)
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 10)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
                if (projectile.frame > 2)
                    projectile.frame = 0;
            }
            return true;
        }
    }
}