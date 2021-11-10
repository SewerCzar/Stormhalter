﻿using System;
using System.Collections.Generic;
using System.IO;
using Kesmai.Server.Game;
using Kesmai.Server.Network;

namespace Kesmai.Server.Items
{
	public partial class ChristmasTree : ItemEntity, ITreasure
	{
		/// <inheritdoc />
		public override int LabelNumber => 6000093;

		/// <inheritdoc />
		public override uint BasePrice => 500000;

		/// <inheritdoc />
		public override int Weight => 15;

		/// <inheritdoc />
		public override int Category => 3;

		/// <summary>
		/// Initializes a new instance of the <see cref="ChristmasTreeGem"/> class.
		/// </summary>
		public ChristmasTreeGem() : base(324)
		{
		}

		/// <inheritdoc />
		public override void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200339)); /* [You are looking at] [a miniature decorative holiday tree.] */
		}
	}
}