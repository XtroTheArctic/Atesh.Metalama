using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace Atesh.Metalama;

public class RangeAttribute : RangeContractAspect
{
    protected readonly object Value2;

    public RangeAttribute(int Min, int Max) : base(Min) => Value2 = Max;
    public RangeAttribute(long Min, long Max) : base(Min) => Value2 = Max;
    public RangeAttribute(float Min, float Max) : base(Min) => Value2 = Max;
    public RangeAttribute(double Min, double Max) : base(Min) => Value2 = Max;

    // ReSharper disable once InconsistentNaming
    public override void Validate(dynamic? value)
    {
#pragma warning disable CS8602
        if (value.CompareTo(Value1) < 0 || value.CompareTo(Value2) > 0) throw new ArgumentOutOfRangeException(((INamedDeclaration)meta.Target.Declaration).Name, value, Strings.ValueMustBeBetween(Value1.ToString(), Value2.ToString()));
#pragma warning restore CS8602
    }
}