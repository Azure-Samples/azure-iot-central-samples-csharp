using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTools;

namespace IoTCentralApp
{
    public class Utility
    {
        private static Random random = new Random();

        public static string RandomResourceName(string prefix, int length)
        {
            return prefix + Utility.RandomString(length);
        }

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string getInputValue(string desc)
        {
            Console.Write($"Please enter {desc}: ");
            return Console.ReadLine();
        }

        public static bool getAnswerOfYesOrNo(string desc)
        {
            while (true)
            {
                Console.Write($"{desc}? (Y/n): ");
                var ans = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(ans) || ans.ToLower() == "y")
                {
                    return true;
                }
                else if (ans.ToLower() == "n")
                {
                    return false;
                }
            }
        }

        public static string selectFromArray(List<string> list, string header = "", string title = "")
        {
            var selection = "";
            var menu = new ConsoleMenu();
            foreach (var item in list)
            {
                menu.Add(item, () =>
                {
                    selection = item;
                    menu.CloseMenu();
                });
            }

            menu.Configure(config =>
                {
                    // config.ClearConsole  = false;
                    if (!String.IsNullOrWhiteSpace(header))
                    {
                        config.WriteHeaderAction = () => Console.WriteLine(header);
                    }

                    if (!String.IsNullOrWhiteSpace(title))
                    {
                        config.Title = title;
                        config.EnableWriteTitle = true;
                    }
                });
            menu.Show();

            return selection;
        }
    }
}