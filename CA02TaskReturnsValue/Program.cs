// See https://aka.ms/new-console-template for more information

using System;

//Task<DateTime> task = Task.Run(() => DateTime.Now);
Task<DateTime> task = Task.Run(GetCurrentDateTime);
//Console.WriteLine(task);           // -> print "System.Threading.Tasks.Task`1[System.DateTime]"
//Console.WriteLine(task.Result);    // -> print "8/22/2023 2:54:00 PM"

Console.WriteLine(task.GetAwaiter().GetResult());
static DateTime GetCurrentDateTime() => DateTime.Now;







