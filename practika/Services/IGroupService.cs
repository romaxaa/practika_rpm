using practika.Data; // если нужны модели базы
using practika.DTO;  // если используешь DTO

namespace practika.Services
{
    public interface IGroupService
    {
        Task<List<GroupDto>> GetAllGroupsAsync();
    }
}