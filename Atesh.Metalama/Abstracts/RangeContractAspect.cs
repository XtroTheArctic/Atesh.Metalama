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

        Builder.MustSatisfyAny(X => X.Type().MustBeOfAnyType(typeof(int), typeof(long), typeof(float), typeof(double)));
    }
}