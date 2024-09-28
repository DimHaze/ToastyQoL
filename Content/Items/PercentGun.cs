﻿/*using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToastyQoL.Content.Items
{
    public class PercentGun : ModItem
    {
        public override string Texture => "Terraria/Images/Item_1254";

        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("The Percenter");
            // Tooltip.SetDefault("Deals 10% of the nearest targets max HP to them\nThis is likely to break more complex fights.");
        }
        public override void SetDefaults()
        {
            Item.damage = 1;
            Item.crit = 69;
            Item.DamageType = DamageClass.Default;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = false;
            Item.useAnimation = 25;
            Item.knockBack = 1;
            Item.useTime = 25;
            Item.shoot = ProjectileID.ConfettiGun;
            Item.shootSpeed = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.width = Item.height = 25;
            Item.rare = ItemRarityID.Red;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5f, 0);
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            NPC target = player.Center.ClosestNPCAt(2500);
            if (target != null)
            {
                float lifeRatio = target.life / (float)target.lifeMax;
                if (lifeRatio > 0.1)
                {
                    target.life -= target.lifeMax / 10;
                }
                else
                {
                    target.NPCLoot();
                    target.life = 0;
                    target.active = false;
                }
            }
            return false;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(0);
            recipe.AddIngredient(ItemID.FlintlockPistol);
            recipe.AddTile(TileID.DemonAltar);
            recipe.Register();
        }
    }
}
*/