﻿using ExtensionMethodsApp.Extensions;

namespace ExtensionMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "Lorem ipsum dolor sit amet consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            var shortenedPost = post.Shorten(5);

            System.Console.WriteLine(shortenedPost);
        }
    }
}