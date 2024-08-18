namespace Chapter4.Components.Composite
{
    public class DangerButtonStrategy : IButtonStyleStrategy
    {
        public string GetCssClass() => "btn-danger";
    }
}
