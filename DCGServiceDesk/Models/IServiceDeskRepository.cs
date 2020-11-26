using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCGServiceDesk.Models
{
    public interface IServiceDeskRepository
    {
        List<ScheduledWork> GetServiceWorks(int eId, DateTime date);
        List<Categorization> GetServices(string category);
        List<Impact> GetImpacts();
        List<Urgency> GetUrgencies();
        int SetPriority(int urgency, int impact);
    }
}
