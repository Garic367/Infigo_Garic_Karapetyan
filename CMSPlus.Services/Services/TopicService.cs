using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Persistance;
using CMSPlus.Services.Interfaces;

namespace CMSPlus.Services.Services;

public class TopicService:ITopicService
{
    private readonly ITopicRepository _repository;

    public TopicService(ITopicRepository repository)
    {
        _repository = repository;
    }

    public async Task<TopicEntity> GetById(int id)
    {
        return await _repository.GetById(id);
    }
    
    public async Task<TopicEntity?> GetBySystemName(string systemName)
    {
        return await _repository.GetBySystemName(systemName);
    }

    public async Task<IEnumerable<TopicEntity>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task Create(TopicEntity entity)
    {
        await _repository.Create(entity);
    }

    public async Task Update(TopicEntity entity)
    {
        await _repository.Update(entity);
    }

    public async Task Delete(int id)
    {
        await _repository.Delete(id);
    }
    
    private readonly ApplicationDbContext _context;

    public TopicService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task AddComment(CommentEntity comment)
    {
        _context.Comments.Add(comment);
        await _context.SaveChangesAsync();
    }
}