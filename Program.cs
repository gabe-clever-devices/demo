using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        private const string _reverseSentenceCommand = "-reverse";
        private const string _intersectStringsCommand = "-intersect";
        private const int _minimumArguments = 3;

        static void Main(string[] args)
        {
            if (args.Length >= _minimumArguments && IsFirstArgumentRecognized(args[0]))
            {
                if (args[0] == _reverseSentenceCommand)
                {
                    Console.WriteLine(GetReversedSentenceFromArguments(args));

                    return;
                }
                else if (args[0] == _intersectStringsCommand)
                {
                    Console.WriteLine(GetCharacterIntersection(args[1], args[2]));

                    return;
                }
            }

            WriteUsageToConsole();
        }

        private static bool IsFirstArgumentRecognized(string firstArgument)
        {
            return firstArgument == _reverseSentenceCommand
                || firstArgument == _intersectStringsCommand;
        }

        private static string GetReversedSentenceFromArguments(string[] args)
        {
            var argumentStack = new Stack<string>();
            var reversedArguments = new List<string>();

            foreach (var arg in args.Skip(1))
            {
                argumentStack.Push(arg);
            }

            while (argumentStack.IsEmpty() == false)
            {
                reversedArguments.Add(argumentStack.Pop());
            }

            return string.Join(" ", reversedArguments);
        }

        private static string GetCharacterIntersection(string first, string second)
        {
            var intersection = new List<char>();

            foreach (var character in first)
            {
                if(second.Contains(character))
                {
                    intersection.Add(character);
                }
            }

            return string.Concat(intersection);
        }

        private static void WriteUsageToConsole()
        {
            Console.WriteLine(Properties.Resources.Usage);
        }
    }
}
