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

        if (ValidateMethod.IsStatic) ValidateMethod.Invokers.Final.Invoke(null);
        else ValidateMethod.Invokers.Final.Invoke(meta.This);

        return meta.Proceed();
    }
}