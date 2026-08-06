using System;

class SortedAnagrams
{

    public static List<List<string>> AnagramsSorted(List<string> str)
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach(var word in str) // eat
        {
            char[] chars = word.ToCharArray(); //['e', 'a', 't']
            Array.Sort(chars); // ['a', 'e', 't']

            string key = new string(chars); // ant

            if (!dict.ContainsKey(key)) //
            {
                dict[key] = new List<string>();
            }
            dict[key].Add(word); // ["aet" : ["eat", "tea"], "ant": ["tan"],  ]
        }

        return new List<List<string>>(dict.Values);
    }
    public static void Main()
    {
        string[] input = {"eat","tea","tan","ate","nat","bat"};

        var result = AnagramsSorted(input.ToList());

        foreach(var group in result)
        {
            Console.WriteLine("[");

            Console.WriteLine("[" + group.Join(","))
        }
    }
}