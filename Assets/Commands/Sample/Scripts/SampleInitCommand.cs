using System.Threading;
using Common.Commands;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Commands.Sample.Scripts
{
    public class SampleInitCommand : Command<SampleInitCommand>
    {
        public override async UniTask Execute(CancellationToken cancellationToken = default)
        {
            await UniTask.Delay(1000);
            Debug.Log("Completed SampleInitCommand");
        }
    }
}