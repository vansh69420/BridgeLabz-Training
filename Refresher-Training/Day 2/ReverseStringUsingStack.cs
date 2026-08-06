// using System;
// using System.Collections.Generic;
// using System.Text;

// class ReverseStringUsingStack
// {
//     public static void Main()
//     {
//         string s = Console.ReadLine();

//         Stack<char> stack = new Stack<char>();

//         foreach(char c in s)
//         {
//             stack.Push(c);
//         }

//         StringBuilder res = new StringBuilder();

//         while(stack.Count > 0)
//         {
//             res.Append(stack.Pop());
//         }

//         Console.WriteLine(res.ToString());
//     }
// }