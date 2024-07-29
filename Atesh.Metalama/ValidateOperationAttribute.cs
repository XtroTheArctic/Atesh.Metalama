using Metalama.Framework.Aspects;

namespace Atesh.Metalama;

public class ValidateOperationAttribute : OverrideMethodAspect
{
    readonly string[] MethodNames;

#pragma warning disable IDE0290
    // ReSharper disable once ConvertToPrimaryConstructor
    public ValidateOperationAttribute(params string[] MethodNames) => this.MethodNames = MethodNames;
#pragma warning restore IDE0290

    public override dynamic? OverrideMethod()
    {
        foreach (var MethodName in MethodNames)
        {
            meta.InsertStatement(MethodName + "();");
        }

        return meta.Proceed();
    }
}