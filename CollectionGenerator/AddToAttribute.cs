namespace CollectionGenerator;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class AddToAttribute(params string[] ArrayNames) : Attribute {
    public string[] ArrayNames { get; } = ArrayNames;
}