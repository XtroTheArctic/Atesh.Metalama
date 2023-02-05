using Metalama.Framework.Aspects;

namespace Atesh.Metalama;

public class ValidateOperationAttribute : OverrideMethodAspect
{
    readonly string[] MethodNames;

    public ValidateOperationAttribute(params string[] MethodNames) => this.MethodNames = MethodNames;

    public override dynamic OverrideMethod()
    {
        foreach (var MethodName in MethodNames)
        {
            meta.InsertStatement(MethodName + "();");
        }

        return meta.Proceed();
    }
}