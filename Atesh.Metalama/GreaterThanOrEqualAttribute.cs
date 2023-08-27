using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace Atesh.Metalama;

public class GreaterThanOrEqualAttribute : RangeContractAspect
{
    public GreaterThanOrEqualAttribute(int Value) : base(Value) { }
    public GreaterThanOrEqualAttribute(long Value) : base(Value) { }
    public GreaterThanOrEqualAttribute(float Value) : base(Value) { }
    public GreaterThanOrEqualAttribute(double Value) : base(Value) { }

    // ReSharper disable once InconsistentNaming
    public override void Validate(dynamic? value)
    {
#pragma warning disable CS8602
        if (value.CompareTo(Value1) < 0) throw new ArgumentOutOfRangeException(((INamedDeclaration)meta.Target.Declaration).Name, value, Strings.ValueCantBeLessThan(Value1.ToString()));
#pragma warning restore CS8602
    }
}