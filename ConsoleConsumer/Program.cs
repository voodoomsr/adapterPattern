using System;
using DataRenderer;

namespace ConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var rendererAdapter = new RendererAdapter(new Renderer());
            var multiRender = new MultiRender(rendererAdapter);
            Console.WriteLine(multiRender.Show(new string[]{""}));
        }
    }
}
