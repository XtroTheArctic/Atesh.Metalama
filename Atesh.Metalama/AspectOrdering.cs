using Metalama.Framework.Aspects;
using Atesh.Metalama;
using Metalama.Patterns.Contracts;

[assembly: AspectOrder(AspectOrderDirection.RunTime, typeof(ContractBaseAttribute), typeof(ValidateOperationAttribute))]