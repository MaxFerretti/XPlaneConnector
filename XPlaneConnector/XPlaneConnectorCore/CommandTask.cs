using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPlaneConnectorCore
{
    public record class CommandTask(
        CancellationTokenSource TokenSource,
        Task RunningTask
    )
    {
        public async Task StopAsync()
        {
            await TokenSource.CancelAsync();
            await RunningTask;
        }
    }


}
