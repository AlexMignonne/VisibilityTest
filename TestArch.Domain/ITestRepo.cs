using System.Threading;
using System.Threading.Tasks;

namespace TestArch.Domain
{
    public interface ITestRepo
    {
        Task<string> Mod(
            string st,
            CancellationToken token);
    }
}