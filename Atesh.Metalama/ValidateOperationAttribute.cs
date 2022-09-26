using System.Linq;
using Metalama.Framework.Aspects;

namespace Atesh.Metalama;

public class ValidateOperationAttribute : OverrideMethodAspect
{
    readonly string MethodName;

    public ValidateOperationAttribute(string MethodName) => this.MethodName = MethodName;

    public override dynamic? OverrideMethod()
    {
        var ValidateMethod = meta.Target.Type.Methods.OfName(MethodName).First();

        ValidateMethod.Invokers.Final.Invoke(meta.RunTime((ValidateMethod.IsStatic ? null : meta.This)));

        return meta.Proceed();
    }
}