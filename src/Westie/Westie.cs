using System;

namespace Example
{
    public class Westie : Dog
    {
        public override string GetDescription() => "Westie | " + base.GetDescription();
    }
}
