﻿using System;
using System.Collections.Generic;
using System.IO;
using Kesmai.Server.Game;
using Kesmai.Server.Network;

namespace Kesmai.Server.Items
{
	public partial class DemonFigurine : ItemEntity, ITreasure
	{
		/// <inheritdoc />
		public override int Weight => 5;

		/// <summary>
		/// Gets the label number.
		/// </summary>
		public override int LabelNumber => 6000036;

		/// <summary>
		/// Initializes a new instance of the <see cref="DemonFigurine"/> class.
		/// </summary>
		[WorldForge]
		public DemonFigurine() : base(376)
		{
		}

		/// <inheritdoc />
		public override void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200318)); /* [You are looking at] [a bronze figurine of a fearsome demon.] */
		}
	}
}