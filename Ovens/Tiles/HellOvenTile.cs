﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace WeaponOven
{
	public class HellOvenTile : ModTile
	{
		public override void PostSetDefaults()
		{
			Main.tileSolid[Type] = false;
			Main.tileMergeDirt[Type] = false;
			Main.tileBlockLight[Type] = false;
			ItemDrop = ModContent.ItemType<HellOven>();
			AddMapEntry(new Color(100, 100, 100));
		}
	}
}