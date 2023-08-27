using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace Atesh.Metalama;

public class NotNullAttribute : InputValidationAspect
{
    // ReSharper disable once InconsistentNaming
    public override void Validate(dynamic? value)
    {
        if (value == null) throw new ArgumentNullException(((INamedDeclaration)meta.Target.Declaration).Name);
    }
} 