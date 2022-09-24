using System;
using Metalama.Framework.Code;
using Metalama.Framework.Eligibility;

namespace Atesh.Metalama;

public abstract class RangeContractAspect : InputValidationAspect
{
    protected readonly object Value1;

    protected RangeContractAspect(IComparable Value) => Value1 = Value;

    public override void BuildEligibility(IEligibilityBuilder<IParameter> Builder)
    {
        base.BuildEligibility(Builder);

        Builder.MustSatisfyAny(X => X.Type().MustBe<int>(), X => X.Type().MustBe<long>(), X => X.Type().MustBe<float>(), X => X.Type().MustBe<double>());
    }
}