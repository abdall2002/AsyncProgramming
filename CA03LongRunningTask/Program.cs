// See https://aka.ms/new-console-template for more information

using System;

var task = Task.Factory.StartNew(() => RunLongTask(),
TaskCreationOptions.LongRunning);
Console.WriteLine(task);


static void RunLongTask()
{
    Thread.Sleep(3000);
    ShowThreadInfo(Thread.CurrentThread);
    Console.WriteLine("Completed");
}
static void ShowThreadInfo(Thread th)
{
    Console.WriteLine($"TID: {th.ManagedThreadId}, Pooled: {th.IsThreadPoolThread}, Background: {th.IsBackground}");
}














