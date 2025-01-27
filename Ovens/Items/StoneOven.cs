﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WeaponOven.Ovens.Tiles;

namespace WeaponOven.Ovens.Items
{
	public class StoneOven : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Oven");
			Tooltip.SetDefault("Used to cook weapons and accessories\nRight click to open the GUI");
		}
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.createTile = ModContent.TileType<StoneOvenTile>();
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.StoneSlab, 20);
			recipe.AddIngredient(ItemID.Torch, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
