using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent;
using PrimordialForces.Content.Items;
using Microsoft.Xna.Framework;




namespace PrimordialForces.Content.Items.Weapons
{
    public class EmeraldExecutioner : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Executioner");


        }
        public override void SetDefaults()
        {
            
            Item.height = 46;
            Item.width = 46;
            Item.scale = 1.5f;
            Item.DamageType = DamageClass.Melee;
            Item.damage = 48;
            Item.crit = 11;
            Item.knockBack = 8.5f;
            Item.value = 50000;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = false;
            Item.rare = ItemRarityID.Green;
            Item.useTime = 45;
            Item.useAnimation = 45;
            Item.reuseDelay = 13;

           
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                //Emit dusts when the sword is swung
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.GreenTorch, 0f, 0f, 0, Colors.RarityRed, 1f);
            }
            
        }
        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.Obsidian, 20)
            .AddIngredient(ItemID.LargeEmerald)
            .AddTile(TileID.Anvils)
            .Register();
        }
    }
}



