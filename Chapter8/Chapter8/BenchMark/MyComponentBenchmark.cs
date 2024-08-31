using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Chapter8.Components;


namespace BenchMark
{
    public class MyComponentBenchmark
    {
        private MyComponent _component;

        [GlobalSetup]
        public void Setup()
        {
            _component = new MyComponent();
        }

        [Benchmark]
        public void RenderComponent()
        {
            _component.Render();
        }

    }
}
