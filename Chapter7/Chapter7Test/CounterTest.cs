using Bunit;
using Chapter7.Components.Pages;

namespace Chapter7Test
{
    public class CounterTest : TestContext
    {
        [Fact]
        public void Counter_Should_IncrementValue_When_ButtonIsClicked()
        {
            var cut = RenderComponent<Counter>();

            var button = cut.Find("button");
            button.Click();

            Assert.Equal(1, cut.Instance.CurrentCount);
        }

    }
}
