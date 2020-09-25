using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gl1tchMod.Projectiles
{
    public class EmberProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.friendly = true;
            projectile.penetrate = 4;
            Main.projFrames[projectile.type] = 3;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 2 * 60);
        }

        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;

            if (projectile.localAI[0] > 480f)
            {
                projectile.Kill();
            }
            else
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Fire);
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