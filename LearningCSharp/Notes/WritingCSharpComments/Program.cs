using System;

namespace WritingCSharpComments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with tripple-slashes and have a special syntax
        /// <summary>
        /// this is the main sample application function
        /// </summary>
        /// <param name='args'>An Array of string arguments from the command line</param>
        /// <returns>
        /// No return value
        /// </returns>
        /// more tags and info at https://docs.microsoft.com/dotnet/csharp/codedoc
        static void Main(string[] args)
        {
            // Single line comments start with two slashes
            // You can have as many of these as you want
            Console.WriteLine("Hello World!");
            /* Multple line comments start with a slassh and a star
            and can continue for several lines
            until a closing star and slash are encounterd */
        }
    }
}
