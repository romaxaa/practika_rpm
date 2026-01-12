using practika.DTO;

namespace practika.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime
        startDate, DateTime endDate);
    }
}
