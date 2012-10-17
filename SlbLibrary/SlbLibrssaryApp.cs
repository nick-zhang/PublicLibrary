using System;

namespace SlbLibrary
{
    class SlbLibrssaryApp
    {
        static void Main(string[] args)
        {
            var library = new Library();
            var message = library.Start();
            Display.ShowMessage(message);
            Console.ReadKey();
        }
    }
}
