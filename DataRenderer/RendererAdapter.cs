using System.Collections.Generic;
using System.IO;

namespace DataRenderer {
    public class RendererAdapter : IDataRendererAdapter
    {
        private Renderer renderer;

        public RendererAdapter(Renderer renderer)
        {
           this.renderer = renderer; 
        }
        public string Show(IEnumerable<string> source)
        {
            return renderer.Render(File.Open("data.txt", FileMode.Open));
        }
    }
}