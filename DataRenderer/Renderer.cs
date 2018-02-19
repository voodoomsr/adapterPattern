using System;
using System.IO;
using System.Text;

namespace DataRenderer
{
    public class Renderer
    {
        public string Render(FileStream stream){
            byte[] buffer = new byte[1024];
            var encoder = new UTF8Encoding();
            var accumulator = new StringBuilder();

            while(stream.Read(buffer, 0, buffer.Length)>0)
            {
                accumulator.AppendLine(encoder.GetString(buffer));
            }

            return accumulator.ToString();
        }
    }
}
