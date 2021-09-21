using System;
using System.Collections.Generic;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsBlanaced("[(){] }{[()()]()}" ));
        }

        static bool IsBlanaced(string S)
        {
            Stack<char> ST = new Stack<char>();
            for(int i=0; i<S.Length; i++)
            {
                if (S[i] == '{' || S[i] == '(' || S[i] == '[')
                    ST.Push(S[i]);
                else if(S[i] == '}')
                {
                    if (ST.Pop() != '{')
                        return false;
                }
                else if (S[i] == ']')
                {
                    if (ST.Pop() != '[')
                        return false;
                }
                else if (S[i] == ')')
                {
                    if (ST.Pop() != '(')
                        return false;
                }
            }
            return ST.Count != 0 ? false : true;
            
        }
    }
}
