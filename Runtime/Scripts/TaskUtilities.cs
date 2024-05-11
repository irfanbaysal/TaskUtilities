using System.Threading;

namespace TaskUtility
{
    public static class TaskUtilities
    {
        public static void StartAsyncOps(ref CancellationTokenSource cancellationTokenSource)
        {
            cancellationTokenSource?.Dispose();
            cancellationTokenSource = new CancellationTokenSource();
        }
    
        public static void StopAsyncOps(CancellationTokenSource cancellationTokenSource)
        {
            if (cancellationTokenSource == null) return;
            if (cancellationTokenSource.IsCancellationRequested) return;
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
        }
    }
}