namespace CMSPlus.Domain.Entities;

public class CommentEntity
{

        public string FullName { get; set; } = null!;
        public string CommentText { get; set; } = null!;

        
        public int TopicId { get; set; }
        public TopicEntity Topic { get; set; } = null!;
}


