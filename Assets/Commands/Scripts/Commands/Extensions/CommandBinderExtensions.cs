using Zenject;

namespace Common.Commands.Extensions
{
    public static class CommandBinderExtensions
    {
        public static void BindCommand<TCommandType>(this DiContainer container)
            where TCommandType : Command<TCommandType>
        {
            container.BindFactory<TCommandType, Command<TCommandType>.Factory>();
        }
        public static void BindCommand<TParam, TCommandType>(this DiContainer container)
            where TCommandType : Command<TParam, TCommandType>
        {
            container.BindFactory<TParam, TCommandType, Command<TParam, TCommandType>.Factory>();
        }
        public static void BindCommand<TParam1, TParam2, TCommandType>(this DiContainer container)
            where TCommandType : Command<TParam1, TParam2, TCommandType>
        {
            container.BindFactory<TParam1, TParam2, TCommandType, Command<TParam1, TParam2, TCommandType>.Factory>();
        }
        
    }
}