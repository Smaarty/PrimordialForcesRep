using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent;
using PrimordialForces.Content.Projectiles;



namespace PrimordialForces.Content.Items.Weapons
{
	public class RubyRapier : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ruby Rapier");
		}

		public override void SetDefaults()
		{
			Item.damage = 18;
			Item.useStyle = ItemUseStyleID.Rapier;
			Item.useAnimation = 18;
			Item.useTime = 24;
			Item.shootSpeed = 3.7f;
			Item.knockBack = 6.5f;
			Item.width = 50;
			Item.height = 50;
			Item.scale = 1f;
			Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(silver: 50);

			Item.DamageType = DamageClass.Melee;
			Item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			Item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			Item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()
			Item.UseSound = SoundID.Item1;
			Item.shoot = ModContent.ProjectileType<RubyRapierProjectile>();
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[Item.shoot] < 1;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.Obsidian, 20)
			.AddIngredient(ItemID.LargeRuby)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}

