using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace FastPermanentConsumables.Items
{
	public class MainConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Header("Changes_require_reloads")]

		[Label("Use speed of affected items")]
		[Tooltip("Sets the useTime property of the affected items to the set value. Default value is 6. Vanilla value is 30.")]
		[Range(1, 30)]
		[Increment(1)]
		[Slider]
		[DefaultValue(6)]
		[ReloadRequired]
		public int UseTime;

		[Label("Disable use sound")]
		[Tooltip("Low UseTime values may play use sounds at an uncomfortable rate, especially for prolonged periods of time. Tick to disable the sounds of the affected items.")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool DisableSound;
	}
}
