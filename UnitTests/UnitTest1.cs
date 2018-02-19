using System;
using Xunit;
using DataRenderer;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void MultiRenderShouldRenderText()
        {
            var rendererAdapter = new RendererAdapter(new Renderer());
            var multiRender = new MultiRender(rendererAdapter);
            Assert.NotEmpty(multiRender.Show(new string[]{""}));
        }
    }
}
