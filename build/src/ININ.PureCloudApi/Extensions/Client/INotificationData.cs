namespace ININ.PureCloudApi.Client
{
    public interface INotificationData
    {
        string TopicName { get; set; }
        string Version { get; set; }
        Metadata Metadata { get; set; }
    }
}