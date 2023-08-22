// See https://aka.ms/new-console-template for more information


//Display("Dummy text");
//new Thread(() => Display("Metigator using thread !!!")).Start(); -> or
var th = new Thread(() => Display("Metigator using thread !!!"));
th.Start();
th.Join();

//Task.Run(() => Display("Metigator using task !!!"));
Task.Run(() => Display("Metigator using task !!!")).Wait();


static void Display(string message)
{
    ShowThreadInfo(Thread.CurrentThread);
    Console.WriteLine(message);
}

static void ShowThreadInfo(Thread th)
{
    Console.WriteLine($"TID: {th.ManagedThreadId}, Pooled: {th.IsThreadPoolThread}, Background: {th.IsBackground}");
}









