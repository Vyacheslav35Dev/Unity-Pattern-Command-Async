using System.Threading;
using Cysharp.Threading.Tasks;
using Zenject;

namespace Common.Commands
{
    public abstract class CommandBase : ICommand
    {
        public abstract UniTask Execute(CancellationToken cancellationToken = default);
    }

    public abstract class Command<T> : CommandBase where T : Command<T>
    {
        public class Factory : PlaceholderFactory<T>{}
    }
    
    public abstract class Command<TParam1,T> : CommandBase where T : Command<TParam1,T>
    {
        public class Factory : PlaceholderFactory<TParam1,T>{}
    }
    
    public abstract class Command<TParam1,TParam2,T> : CommandBase where T : Command<TParam1,TParam2,T>
    {
        public class Factory : PlaceholderFactory<TParam1,TParam2,T>{}
    }
    
    public abstract class Command<TParam1,TParam2,TParam3,T> : CommandBase where T : Command<TParam1, TParam2, TParam3,T>
    {
        public class Factory : PlaceholderFactory<TParam1,TParam2,TParam3,T>{}
    }
    
    public abstract class Command<TParam1,TParam2,TParam3, TParam4,T> : CommandBase where T : Command<TParam1,TParam2,TParam3, TParam4,T>
    {
        public class Factory : PlaceholderFactory<TParam1,TParam2,TParam3, TParam4,T>{}
    }
}