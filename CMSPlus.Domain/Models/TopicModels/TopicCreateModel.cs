namespace CMSPlus.Domain.Models.TopicModels;

public class TopicCreateModel:BaseTopicModel
{
    public string SystemName { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    
    
}