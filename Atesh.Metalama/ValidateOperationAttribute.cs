using Metalama.Framework.Aspects;

namespace Atesh.Metalama;

public class ValidateOperationAttribute : OverrideMethodAspect
{
    readonly string MethodName;

    public ValidateOperationAttribute(string MethodName) => this.MethodName = MethodName;

    public override dynamic? OverrideMethod()
    {
        meta.InsertStatement(MethodName + "();");

        return meta.Proceed();
    }
}