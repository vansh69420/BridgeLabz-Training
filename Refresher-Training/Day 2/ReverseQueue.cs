// using System;

// class ReverseQueue
// {
//     public static void Main()
//     {
//         Queue<int> queue = new Queue<int>();
//         queue.Enqueue(10);
//         queue.Enqueue(20);
//         queue.Enqueue(30);
//         queue.Enqueue(40);

//         Stack<int> stack = new Stack<int>();

//         while(queue.Count > 0)
//         {
//             stack.Push(queue.Dequeue());
//         }

//         while(stack.Count > 0)
//         {
//             queue.Enqueue(stack.Pop());
//         }

//         foreach(int i in queue)
//         {
//             Console.WriteLine(i + " ");
//         }
//     }
// }