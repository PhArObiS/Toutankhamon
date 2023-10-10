using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toutankhamon
{
    internal enum TreasureType
    {
        Common = 0,
        Rare,
        Cursed,
    }

    internal class TreasureItem
    {
        internal string Name;
        internal int Weight;
        internal float Value;
        internal TreasureType Type;

        internal TreasureItem(
            string name,
            int weight,
            float value)
        {
            Name = name;
            Weight = weight;
            Value = value;
        }
    }

    internal class CommonTreasureItem : TreasureItem
    {
        internal CommonTreasureItem(
            string name,
            int weight,
            float value)
            : base(name, weight, value)
        {
            Type = TreasureType.Common;
        }
    }

    internal class RareTreasureItem : TreasureItem
    {
        internal RareTreasureItem(
            string name,
            int weight,
            float value)
            : base(name, weight, value)
        {
            Type = TreasureType.Rare;
        }
    }

    internal class CursedTreasureItem : TreasureItem
    {
        internal CursedTreasureItem(
            string name,
            int weight,
            float value)
            : base(name, weight, value)
        {
            Type = TreasureType.Cursed;
        }
    }
}