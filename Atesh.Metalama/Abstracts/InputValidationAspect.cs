using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.Eligibility;

namespace Atesh.Metalama;

public abstract class InputValidationAspect : ContractAspect
{
    public override void BuildEligibility(IEligibilityBuilder<IParameter> Builder)
    {
        base.BuildEligibility(Builder);

        Builder.MustBeReadable();
    }
}