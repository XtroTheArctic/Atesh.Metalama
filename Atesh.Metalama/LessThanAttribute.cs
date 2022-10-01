using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using System;

namespace Atesh.Metalama;

public class LessThanAttribute : RangeContractAspect
{
    public LessThanAttribute(int Value) : base(Value) { }
    public LessThanAttribute(long Value) : base(Value) { }
    public LessThanAttribute(float Value) : base(Value) { }
    public LessThanAttribute(double Value) : base(Value) { }

    // ReSharper disable once InconsistentNaming
    public override void Validate(dynamic? value)
    {
#pragma warning disable CS8602
        if (value.CompareTo(Value1) >= 0) throw new ArgumentOutOfRangeException(((INamedDeclaration)meta.Target.Declaration).Name, value, Strings.ValueMustBeLessThan(Value1.ToString()));
#pragma warning restore CS8602
    }
}