using Metalama.Framework.Code;
using Metalama.Framework.Eligibility;

namespace Atesh.Metalama;

public abstract class RangeContractAspect : InputValidationAspect
{
    protected readonly object Value1;

    // ReSharper disable once ConvertToPrimaryConstructor
    protected RangeContractAspect(IComparable Value) => Value1 = Value;

    public override void BuildEligibility(IEligibilityBuilder<IParameter> Builder)
    {
        base.BuildEligibility(Builder);

        Builder.MustSatisfyAny(X => X.Type().MustBe(typeof(int)), X => X.Type().MustBe(typeof(long)), X => X.Type().MustBe(typeof(float)), X => X.Type().MustBe(typeof(double)));
    }
}