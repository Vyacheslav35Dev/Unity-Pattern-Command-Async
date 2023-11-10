using System.Threading;
using Common.Commands;
using Cysharp.Threading.Tasks;

namespace Commands
{
    public class LoadGameCommand : Command<LoadGameCommand>
    {
        public override async UniTask Execute(CancellationToken cancellationToken = default)
        {
            await UniTask.Delay(1000, cancellationToken:cancellationToken);
        }
    }
}