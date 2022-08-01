using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria.Audio;

namespace PrimordialForces.Content.Projectiles
{
	public class TopazTomeProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Topaz Tome");
		}
		public override void SetDefaults()
		{
			Projectile.width = 16; 
			Projectile.height = 16;
			
			Projectile.aiStyle = 29; // The ai style of the projectile, please reference the source code of Terraria
			Projectile.friendly = true; // Can the projectile deal damage to enemies?
			Projectile.hostile = false; // Can the projectile deal damage to the player?
			Projectile.DamageType = DamageClass.Magic; // Is the projectile shoot by a ranged weapon?
			Projectile.penetrate = -1; // How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			Projectile.timeLeft = 6 * 60; // The live time for the projectile (60 = 1 second, so 600 is 10 seconds
			Projectile.light = 0.5f; // How much light emit around the projectile
			Projectile.ignoreWater = true; // Does the projectile's speed be influenced by water?
			Projectile.tileCollide = true; // Can the projectile collide with tiles?
			Projectile.extraUpdates = 1; // Set to above 0 if you want the projectile to update multiple time

			AIType = ProjectileID.TopazBolt;

		}

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
			Projectile.Kill();
			return true;
        }

		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {

			int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			#region
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.YellowStarDust, 0f, 0f, 0, Colors.RarityOrange, 1f);


			#endregion
			Main.dust[dust].noGravity = true;
			Main.dust[dust].scale = (float)Main.rand.Next(1, 8) * 0.015f;
			Main.dust[dust].velocity *= 0;

			Projectile.damage = 15;
			Projectile.CritChance = 25;
			Projectile.knockBack = 3f;
			Projectile.alpha = 255;
			Projectile.timeLeft = 3;
			Projectile.velocity *= 0f;
			Projectile.Resize(86, 86);
			SoundEngine.PlaySound(SoundID.Item14, Projectile.position);
			target.immune[Projectile.owner] = 3;
			


		}

    }
}
