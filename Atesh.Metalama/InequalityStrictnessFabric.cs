using Metalama.Framework.Fabrics;
using Metalama.Patterns.Contracts;

namespace Atesh.Metalama;

class InequalityStrictnessFabric : TransitiveProjectFabric
{
    public override void AmendProject(IProjectAmender Amender) => Amender.ConfigureContracts(new() { DefaultInequalityStrictness = InequalityStrictness.Strict });
}