using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.CDK;
using Amazon.CDK.Assertions;
using CdkCsharp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var app = new App();
            var stack = new CdkCsharpStack(app, "test-stack");
            var template = Template.FromStack(stack);
            template.ResourceCountIs("AWS::SNS::Subscription", 1);
        }
    }
}
