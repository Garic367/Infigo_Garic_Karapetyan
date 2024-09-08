using CMSPlus.Domain.Entities;

namespace CMSPlus.Services.Interfaces;

public interface ITopicService
{
    public Task<TopicEntity> GetById(int id);
    public Task<TopicEntity?> GetBySystemName(string systemName);
    public Task<IEnumerable<TopicEntity>> GetAll();
    public Task Create(TopicEntity entity);
    public Task Update(TopicEntity entity);
    public Task Delete(int id);
    Task AddComment(CommentEntity commentEntity);
}