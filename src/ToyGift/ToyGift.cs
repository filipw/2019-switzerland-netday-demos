using System;

namespace Articles
{
    public class ToyGift : ChristmasGift
    {
        public override string GetDescription() => "Toy | " + base.GetDescription();
    }
}
