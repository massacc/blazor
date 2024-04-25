using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

List<string> words = new List<string>();

words.Add("radar");
words.Add("Anna");
words.Add("palindrom");
words.Add("zakaz");

bool check(string word)
{
    Stack stack = new Stack();

    int len = word.Length;
    int number_of_chars = len / 2;
    int middle_char = 0;

    if(len % 2 > 0 )
    {
        middle_char = 1;
    }

    for (int i = 0; i < number_of_chars; i++)
    {
       char c = char.ToUpper(word[i]);
        stack.Push(c);
    }

    for (int i = number_of_chars + middle_char; i < len; i++)
    {
        char c = (char)stack.Pop();

        if (c != char.ToUpper(word[i]))
        {
            return false;
        }

    }
    return true;

    
}

foreach(string word in words)
{
    bool result = check(word);
    Console.WriteLine($"{word} - {result}");
}
        

