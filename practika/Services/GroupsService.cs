using Microsoft.EntityFrameworkCore;
using practika.Data;
using practika.DTO;

namespace practika.Services
{
    // Класс реализует интерфейс IGroupService
    public class GroupsService : IGroupService
    {
        private readonly AppDbContext _context;

        public GroupsService(AppDbContext context)
        {
            _context = context;
        }

        // Получение всех групп
        public async Task<List<GroupDto>> GetAllGroupsAsync()
        {
            return await _context.StudentGroups
                .Select(g => new GroupDto
                {
                    Id = g.GroupId,      // используем реальные свойства из StudentGroup
                    Name = g.GroupName
                })
                .ToListAsync();
        }
    }
}