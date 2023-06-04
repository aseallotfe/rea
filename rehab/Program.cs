// See https://aka.ms/new-console-template for more information
using rehab;
using System.Runtime.CompilerServices;

Task1 reh = new Task1();
Task1 re = new Task1();
Task1 rb = new Task1();
Task1 er = new Task1();
reh.name = "clean house";
re.name = "do the homework";
rb.name = "washing clothes";
er.name = "take care of my baby";

reh.PrintTask();
re.PrintTask();

TaskManager.AddTask(reh);
TaskManager.AddTask(re);
TaskManager.AddTask(rb);
TaskManager.AddTask(er);


Console.WriteLine("\ntask found at:" + TaskManager.SearchForTask(reh));
Console.WriteLine("\ntask found at:" + TaskManager.SearchForTask(rb));
Console.WriteLine("\nTask found at:" + TaskManager.SearchForTask(er));

TaskManager.DeleteTask(re);
TaskManager.DeleteTask(rb);


Console.WriteLine("\ntask found at:" + TaskManager.SearchForTask(re));
