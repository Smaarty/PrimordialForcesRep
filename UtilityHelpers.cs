using Microsoft.Xna.Framework;
using Terraria;

namespace PrimordialForces
{
    public static class UtilityHelpers
    {
        public static void Resize(this Projectile projectile, int newWidth, int newHeight)
        {
            Vector2 oldCenter = projectile.Center;
            projectile.width = newWidth;
            projectile.height = newHeight;
            projectile.Center = oldCenter;
        }
    }
}