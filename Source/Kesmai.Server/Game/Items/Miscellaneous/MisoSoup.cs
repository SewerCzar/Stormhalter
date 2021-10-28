﻿using System;
using System.Collections.Generic;
using System.IO;
using Kesmai.Server.Game;
using Kesmai.Server.Network;

namespace Kesmai.Server.Items
{
	public partial class MisoSoup : ItemEntity, ITreasure
	{
		/// <inheritdoc />
		public override int Weight => 5;

		/// <summary>
		/// Gets the label number.
		/// </summary>
		public override int LabelNumber => 6000016;

		/// <summary>
		/// Initializes a new instance of the <see cref="MisoSoup"/> class.
		/// </summary>
		[WorldForge]
		public MisoSoup() : base(24)
		{
		}

		/// <inheritdoc />
		public override void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200304)); /* [You are looking at] [a delicious smelling bowl of soup.] */
		}
	}
}