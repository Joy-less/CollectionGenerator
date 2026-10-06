using System.Collections.Immutable;

namespace CollectionGenerator.Tests;

public partial class UnitTest2 {
    [AddTo("MyCollection")]
    public static readonly string TestStringField = "Hello";
    [AddTo("MyCollection")]
    public static string TestStringProperty { get; } = "World";
    [AddTo("MyCollection", "MyIntCollection")]
    [AddTo("MyNumberCollection")]
    public static int TestIntProperty { get; } = 9;

    public static readonly ImmutableArray<object> MyCollection;
    public static readonly ImmutableArray<int> MyIntCollection;
    public static readonly ImmutableArray<int> MyNumberCollection;

    [Fact]
    public void Test1() {
        MyCollection.ShouldBe(["Hello", "World", 9]);
        MyIntCollection.ShouldBe([9]);
        MyNumberCollection.ShouldBe([9]);
    }
}