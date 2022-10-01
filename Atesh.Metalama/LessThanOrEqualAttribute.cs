using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using System;

namespace Atesh.Metalama;

public class LessThanOrEqualAttribute : RangeContractAspect
{
    public LessThanOrEqualAttribute(int Value) : base(Value) { }
    public LessThanOrEqualAttribute(long Value) : base(Value) { }
    public LessThanOrEqualAttribute(float Value) : base(Value) { }
    public LessThanOrEqualAttribute(double Value) : base(Value) { }

    // ReSharper disable once InconsistentNaming
    public override void Validate(dynamic? value)
    {
#pragma warning disable CS8602
        if (value.CompareTo(Value1) > 0) throw new ArgumentOutOfRangeException(((INamedDeclaration)meta.Target.Declaration).Name, value, Strings.ValueCantBeGreaterThan(Value1.ToString()));
#pragma warning restore CS8602
    }
}