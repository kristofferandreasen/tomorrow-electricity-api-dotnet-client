using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Xunit2;

namespace ElectricityMap.DotNet.Client.Test
{
    public sealed class AutoNSubstituteDataAttribute : AutoDataAttribute
    {
        public AutoNSubstituteDataAttribute()
            : base(CreateCustomizedFixture)
        {
        }

        private static IFixture CreateCustomizedFixture()
        {
            var fixture = new Fixture();

            return fixture.Customize(new AutoNSubstituteCustomization());
        }
    }
}
