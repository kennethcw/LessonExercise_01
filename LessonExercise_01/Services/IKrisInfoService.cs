using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonExercise_01.Services
{
    public interface IKrisInfoService
    {
        List<KrisInfo> GetAllKrisInformation();
        List<KrisInfo> GetEmergencies();
        KrisInfo GetKrisInformation(string id);
    }
}
