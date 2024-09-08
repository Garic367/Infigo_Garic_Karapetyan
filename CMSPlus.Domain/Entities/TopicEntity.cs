using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMSPlus.Domain.Entities;

public class TopicEntity:BaseEntity
{
    public string SystemName { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Body { get; set; } = null!;
    public IEnumerable<CommentEntity>? Comments { get; set; }
}
