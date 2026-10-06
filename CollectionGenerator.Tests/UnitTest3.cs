using System.Collections.Immutable;

namespace CollectionGenerator.Tests;

public partial class UnitTest3 {
    [AddTo("MyCollectionField", "MyCollectionProperty")]
    public static readonly string TestString = "Hello";

    public static readonly ImmutableArray<string> MyCollectionField;
    public static ImmutableArray<string> MyCollectionProperty { get; }

    [Fact]
    public void Test1() {
        MyCollectionField.ShouldBe(["Hello"]);
        MyCollectionProperty.ShouldBe(["Hello"]);
    }

    static UnitTest3() {
        UnitTest3_AddTo(out MyCollectionField, out var MyCollectionPropertyTemp);
        MyCollectionProperty = MyCollectionPropertyTemp;
    }
}