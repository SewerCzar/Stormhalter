﻿using System;
using System.Collections.Generic;
using System.IO;
using Kesmai.Server.Game;
using Kesmai.Server.Network;

namespace Kesmai.Server.Items
{
	public partial class ChristmasGift : ItemEntity, ITreasure
	{
		/// <inheritdoc />
		public override int LabelNumber => 6000017;

		/// <inheritdoc />
		public override uint BasePrice => 700;

		/// <inheritdoc />
		public override int Weight => 15;

		/// <inheritdoc />
		public override int Category => 3;

		/// <summary>
		/// Initializes a new instance of the <see cref="ChristmasGift"/> class.
		/// </summary>
		public ChristmasGift() : base(320)
		{
		}

		/// <inheritdoc />
		public override void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200335)); /* [You are looking at] [a beautifully wrapped gift box.] */
		}
	}
}