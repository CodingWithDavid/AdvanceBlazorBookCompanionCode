namespace Chapter4.Components.Composite
{
    public class SecondaryButtonStrategy : IButtonStyleStrategy
    {
        public string GetCssClass() => "btn-secondary";
    }
}
