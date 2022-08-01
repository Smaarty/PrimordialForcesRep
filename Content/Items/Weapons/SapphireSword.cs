using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent;
using PrimordialForces.Content.Items;



namespace PrimordialForces.Content.Items.Weapons
{
    public class SapphireSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sapphire Sword");


        }
        public override void SetDefaults()
        {
            Item.height = 32;
            Item.width = 32;
            Item.scale = 1.2f;
            Item.DamageType = DamageClass.Melee;
            Item.damage = 28;
            Item.knockBack = 5f;
            Item.value = 5000;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Green;
            Item.useTime = 22;
            Item.useAnimation = 22;
            Item.reuseDelay = 0;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.Obsidian, 20)
            .AddIngredient(ItemID.LargeSapphire)
            .AddTile(TileID.Anvils)
            .Register();
        }
    }
}



