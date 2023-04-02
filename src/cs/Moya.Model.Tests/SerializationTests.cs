namespace Moya.Model.Tests;

[TestClass]
public class SerializationTests
{
    public static IEnumerable<object[]> SerializationTestData => new []
    {
        new object[] { new Ingredient(), "TestData/Ingredient01.json" },
        new object[] { new Ingredient() { Name = "Hello" },  "TestData/Ingredient02.json" }
    };

    [DataTestMethod]
    [DynamicData(nameof(SerializationTestData))]
    public void SerializationTest(object obj, string expectedJsonFile)
    {
        var actualJson = System.Text.Json.JsonSerializer.Serialize(obj);
        if (!File.Exists(expectedJsonFile))
           Assert.Inconclusive($"Json file not found: {expectedJsonFile}");
        var expectedJson = File.ReadAllText(expectedJsonFile);
        Assert.AreEqual(expectedJson, actualJson);
    }
}
