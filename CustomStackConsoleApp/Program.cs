using System;
using System.Collections;
using System.IO;
using CustomStackLibrary;
using CustomStackLibrary.interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CustomStackConsoleApp
{
    //I have decided to implement the methods via dependency injection. However, once you import the library, you can implement the methods as you fancy.
    class Program
    {
        private static readonly int arrayBasedStackSize = 1000;//implementation via array requires an array size
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            StackImplementationViaArraysExample(host);
            Console.WriteLine($"Press any key to start implementation via linked list");
            Console.ReadKey();
            StackImplementationViaLinkedListExample(host);
        }

        private static void StackImplementationViaArraysExample(IHost host)
        {
            Console.WriteLine("**************** We are now implementing via arrays ********************");

            var myStack = host.Services.GetService<ICustomStackUsingArray>();
            Console.WriteLine("**************** Lets push some data into  the stack ********************");

            myStack.Push(10);
            myStack.Push("Duncan");
            myStack.Push(123.98);
            myStack.Push(DateTime.Now);
             myStack.PrintStack();
            PressKeyToContinue("peek");
            myStack.Peek();
            PressKeyToContinue("pop");

            myStack.Pop();
            myStack.Size();

            PressKeyToContinue("print");
            myStack.PrintStack();
            PressKeyToContinue("clear");
            myStack.Clear();
            Console.WriteLine("**************** Implementing via arrays ended ********************");
        }
        private static void StackImplementationViaLinkedListExample(IHost host)
        {
            Console.WriteLine("**************** We are now implementing via linked list ********************");
            var myStack = host.Services.GetService<ICustomStackUsingLinkedList>();
            Console.WriteLine("**************** Lets push some data into  the stack ********************");
            myStack.Push(10);
            myStack.Push("Duncan");
            myStack.Push(123.98);
            myStack.Push(DateTime.Now);
            myStack.PrintStack();
            PressKeyToContinue("peek");
            myStack.Peek();
            PressKeyToContinue("pop");
            myStack.Pop();
            myStack.Size();
            PressKeyToContinue("print");

            myStack.PrintStack();
            PressKeyToContinue("clear");

            myStack.Clear();
        }

        private static void PressKeyToContinue(string action)
        {
            Console.WriteLine($"Press any key to {action} the stack");

            Console.ReadKey();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.SetBasePath(Directory.GetCurrentDirectory());
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<ICustomStackUsingArray>(provider => new CustomStackUsingArray(arrayBasedStackSize));
                    services.AddSingleton<ICustomStackUsingLinkedList>(provider => new CustomStackUsingLinkedList());
                });

            return hostBuilder;
        }
    }
}
