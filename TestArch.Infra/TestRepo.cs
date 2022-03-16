using System.Threading;
using System.Threading.Tasks;

using TestArch.Domain;

namespace TestArch.Infra
{
    public sealed class TestRepo : ITestRepo
    {
        public Task<string> Mod(string st, CancellationToken token) =>
            Task.FromResult($"{st} in repo.");
    }
}