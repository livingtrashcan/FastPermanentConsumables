using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FastPermanentConsumables.Items
{
	public class Items : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.LifeCrystal)
			{
				item.autoReuse = true;
				item.useAnimation = GetInstance<MainConfig>().UseTime;
				item.useTime = GetInstance<MainConfig>().UseTime;

				if (GetInstance<MainConfig>().DisableSound == true)
				{
					item.UseSound = null;
				}
			}

			if (item.type == ItemID.LifeFruit)
			{
				item.autoReuse = true;
				item.useAnimation = GetInstance<MainConfig>().UseTime;
				item.useTime = GetInstance<MainConfig>().UseTime;

				if (GetInstance<MainConfig>().DisableSound == true)
				{
					item.UseSound = null;
				}
			}

			if (item.type == ItemID.ManaCrystal)
			{
				item.autoReuse = true;
				item.useAnimation = GetInstance<MainConfig>().UseTime;
				item.useTime = GetInstance<MainConfig>().UseTime;

				if (GetInstance<MainConfig>().DisableSound == true)
				{
					item.UseSound = null;
				}
			}
		}
	}
}
