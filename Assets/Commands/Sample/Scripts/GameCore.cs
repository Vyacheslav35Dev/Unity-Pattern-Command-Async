using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Commands.Sample.Scripts
{
    public class GameCore : MonoBehaviour
    {
        private SampleInitCommand.Factory _initCommand;
        private SampleLoadCommand.Factory _loadCommand;
        
        [Inject]
        private void Construct(SampleInitCommand.Factory initCommand, SampleLoadCommand.Factory loadCommand)
        {
            _initCommand = initCommand;
            _loadCommand = loadCommand;
        }

        private async void Start()
        {
            await _initCommand.Create().Execute(this.GetCancellationTokenOnDestroy());
            await _loadCommand.Create().Execute(this.GetCancellationTokenOnDestroy());

            var task1 = _initCommand.Create().Execute(this.GetCancellationTokenOnDestroy());
            var task2 = _loadCommand.Create().Execute(this.GetCancellationTokenOnDestroy());
            await UniTask.WhenAll(task1, task2);
            
            var task3 = _initCommand.Create().Execute(this.GetCancellationTokenOnDestroy());
            var task4 = _loadCommand.Create().Execute(this.GetCancellationTokenOnDestroy());
            await UniTask.WhenAny(task3, task4);
            Debug.Log("Finish");
        }
    }
}