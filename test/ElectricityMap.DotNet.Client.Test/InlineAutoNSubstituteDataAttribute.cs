using AutoFixture.Xunit2;

namespace ElectricityMap.DotNet.Client.Test
{
    public class InlineAutoNSubstituteDataAttribute : InlineAutoDataAttribute
    {
        public InlineAutoNSubstituteDataAttribute(params object[] values)
            : base(new AutoNSubstituteDataAttribute(), values) { }
    }
}