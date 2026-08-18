using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        int q = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        Stack<string> history = new Stack<string>();

        for (int i = 0; i < q; i++)
        {
            string line = Console.ReadLine();

            char type = line[0];

            if (type == '1')
            {
                string toAppend = line.Substring(2);

                history.Push(sb.ToString());

                sb.Append(toAppend);
            }
            else if (type == '2')
            {
                int k = int.Parse(line.Substring(2));

                history.Push(sb.ToString());

                sb.Remove(sb.Length - k, k);
            }
            else if (type == '3')
            {
                int k = int.Parse(line.Substring(2));

                Console.WriteLine(sb[k - 1]);
            }
            else if (type == '4')
            {
                string previous = history.Pop();

                sb.Clear();
                sb.Append(previous);
            }
        }
    }
}