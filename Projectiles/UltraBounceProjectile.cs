using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Projectiles
{
    public class UltraBounceProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.penetrate = 9999999;
            Main.projFrames[projectile.type] = 3;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.75f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;

            if (projectile.localAI[0] > 60f)
            {
                projectile.Kill();
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