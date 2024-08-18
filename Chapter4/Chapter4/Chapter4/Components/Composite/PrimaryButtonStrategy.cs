namespace Chapter4.Components.Composite
{
    public class PrimaryButtonStrategy : IButtonStyleStrategy
    {
        public string GetCssClass() => "btn-primary";
    }
}
