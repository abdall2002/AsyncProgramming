// See https://aka.ms/new-console-template for more information


Task<DateTime> task = Task.Run(() => DateTime.Now);
Console.WriteLine(task);           // -> print "System.Threading.Tasks.Task`1[System.DateTime]"
Console.WriteLine(task.Result);    // -> print "8/22/2023 2:54:00 PM"










