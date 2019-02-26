
namespace Swellaby.TestAttributes
{
    /// <summary>
    /// Constants to use consistent values on the TestCategory attribute used commonly in MSTest.
    /// In tools such like Azure DevOps, the TestCategory can be used to filter which tests are executed.
    /// </summary>
    public class TestCategories
    {
        public const string Unit = "Unit";
        public const string ComponentIntegration = "Component Integration";
        public const string SystemIntegration = "System Integration";
        public const string Functional = "Functional";
    }
}
