﻿using Terraria.ModLoader;

namespace PboneLib.CustomLoading.Content.Implementations.Content
{
    public abstract class PBuff : ModBuff, ICustomLoadable
    {
        public virtual bool LoadCondition() => true;
    }
}
