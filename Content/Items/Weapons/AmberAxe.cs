using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent;
using PrimordialForces.Content.Items;



namespace PrimordialForces.Content.Items.Weapons
{
    public class AmberAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Axe");


        }
        public override void SetDefaults()
        {
            
            Item.height = 56;
            Item.width = 56;
            Item.DamageType = DamageClass.Melee;
            Item.damage = 35;
            Item.crit = 6;
            Item.knockBack = 6.5f;
            Item.value = 50000;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Green;
            Item.useTime = 34;
            Item.useAnimation = 34;

            //Axe 
            Item.axe = 60;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.Obsidian, 20)
            .AddIngredient(ItemID.LargeAmber)
            .AddTile(TileID.Anvils)
            .Register();
        }
    }
}



