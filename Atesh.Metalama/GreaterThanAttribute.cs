using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using System;

namespace Atesh.Metalama;

public class GreaterThanAttribute : RangeContractAspect
{
    public GreaterThanAttribute(int Value) : base(Value) { }
    public GreaterThanAttribute(long Value) : base(Value) { }
    public GreaterThanAttribute(float Value) : base(Value) { }
    public GreaterThanAttribute(double Value) : base(Value) { }

    // ReSharper disable once InconsistentNaming
    public override void Validate(dynamic? value)
    {
#pragma warning disable CS8602
        if (value.CompareTo(Value1) <= 0) throw new ArgumentOutOfRangeException(((IParameter)meta.Target.Declaration).Name, Strings.ValueMustBeGreaterThan(Value1.ToString()));
#pragma warning restore CS8602
    }
}