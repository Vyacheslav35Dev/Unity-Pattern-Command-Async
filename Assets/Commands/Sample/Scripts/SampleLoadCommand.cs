using System.Threading;
using Common.Commands;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Commands.Sample.Scripts
{
    public class SampleLoadCommand : Command<SampleLoadCommand>
    {
        public override async UniTask Execute(CancellationToken cancellationToken = default)
        {
            await UniTask.Delay(2000);
            Debug.Log("Completed SampleLoadCommand");
        }
    }
}