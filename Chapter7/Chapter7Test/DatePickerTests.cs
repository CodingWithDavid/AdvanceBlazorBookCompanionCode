using Bunit;
using Chapter7.Components;


public class DatePickerTests : TestContext
{
    [Fact]
    public void DatePicker_Should_RenderDefaultDate_When_Loaded()
    {
        var cut = RenderComponent<DatePicker>();

        Assert.Contains("<input type=\"text\" value=\"12/31/2024\"", cut.Markup);
    }


}

