using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    Stack<char> stack = new Stack<char>();
    Queue<char> queue = new Queue<char>();
    
    public void pushCharacter(char ch)
    {
        stack.Push(ch);
    }
    
    public char popCharacter()
    {
        return stack.Pop();
    }
    
    public void enqueueCharacter(char ch)
    {
        queue.Enqueue(ch);
    }
    
    public char dequeueCharacter()
    {
        return queue.Dequeue();
    }
    
     static void Main()
    {
        string s = Console.ReadLine();
        
        Solution obj = new Solution();
        
        foreach(char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        for(int i = 0; i < s.Length / 2; i++)
        {
            if(obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;
                break;
            }
        }
        
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }

}