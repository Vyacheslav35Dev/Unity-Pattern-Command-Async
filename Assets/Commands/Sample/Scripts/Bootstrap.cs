using Common.Commands.Extensions;
using Zenject;

namespace Commands.Sample.Scripts
{
    public class Bootstrap : MonoInstaller<Bootstrap>
    {
        public override void InstallBindings()
        {
            Container.BindCommand<SampleInitCommand>();
            Container.BindCommand<SampleLoadCommand>();
        }
    }
}
