using System.Threading;
using Cysharp.Threading.Tasks;

namespace Common.Commands
{
    public interface ICommand
    {
        UniTask Execute(CancellationToken cancellationToken = default);
    }
}