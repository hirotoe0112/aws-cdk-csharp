using Amazon.CDK;
using Amazon.CDK.AWS.SNS;
using Amazon.CDK.AWS.SNS.Subscriptions;
using Constructs;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject1")]

namespace CdkCsharp
{
    public class CdkCsharpStack : Stack
    {
        internal CdkCsharpStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            Topic topic = new Topic(this, "topic-email", new TopicProps {
                TopicName = "test-email-topic"
            });
            topic.AddSubscription(new EmailSubscription("****@gmail.com"));
        }
    }
}
