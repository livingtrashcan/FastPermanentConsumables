using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FastPermanentConsumables.Items
{
	public class LifeFruit : GlobalItem
	{
		public override void SetDefaults(Item item)
        {
			if (item.type == ItemID.LifeFruit)
            {
                item.autoReuse = true;
				item.useAnimation = 6;
                item.useTime = 6;
			}
		}
	}
}
