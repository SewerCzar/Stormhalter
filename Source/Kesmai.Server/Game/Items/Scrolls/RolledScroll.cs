﻿using System;
using System.Collections.Generic;
using System.IO;
using Kesmai.Server.Game;
using Kesmai.Server.Network;

namespace Kesmai.Server.Items
{
	public partial class RolledScroll : ItemEntity, ITreasure
	{
		/// <inheritdoc />
		public override int Weight => 5;

		/// <summary>
		/// Gets the label number.
		/// </summary>
		public override int LabelNumber => 6000078;

		/// <summary>
		/// Initializes a new instance of the <see cref="RolledScroll"/> class.
		/// </summary>
		[WorldForge]
		public RolledScroll() : base(128)
		{
		}

		/// <inheritdoc />
		public override void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200317)); /* [You are looking at] [a small leather scroll.] */
		}
	}
}