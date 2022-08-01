using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent;
using PrimordialForces.Content.Projectiles;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace PrimordialForces.Content.Items.Weapons
{
    public class TopazTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Topaz Tome");
            Tooltip.SetDefault("Explodes on enemy contact, explosions\nhave increased damage and crit chance");


        }
        public override void SetDefaults()
        {
            Item.height = 28;
            Item.width = 32;
            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.mana = 8;
            Item.damage = 10;
            Item.crit = 4;
            Item.knockBack = 3.5f;
            Item.value = 50000;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item43;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Green;
            Item.useTime = 28;
            Item.useAnimation = 28;
            

            Item.shoot = ModContent.ProjectileType<TopazTomeProjectile>();
            Item.shootSpeed = 7f;
        }
        
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Vector2 offset = new Vector2(velocity.X * 3, velocity.Y * 3);
            position = position + offset;
            Projectile.NewProjectile(source, position, velocity, type, damage, knockback, player.whoAmI);
            return false;
        }
        

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.Obsidian, 20)
            .AddIngredient(ItemID.LargeTopaz)
            .AddTile(TileID.Anvils)
            .Register();
        }
    }
}



