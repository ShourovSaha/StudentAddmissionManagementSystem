using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAddmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAddmissionController : ControllerBase
    {
        private readonly List<StudentAddmissionDetailModel> _strudentAddmissionData;
        public StudentAddmissionController()
        {
            _strudentAddmissionData = getAllStrudentAddmissionData();   
        }

        public ActionResult<List<StudentAddmissionDetailModel>> Get()
        {
            return _strudentAddmissionData ?? new List<StudentAddmissionDetailModel>();
        }

        private List<StudentAddmissionDetailModel> getAllStrudentAddmissionData()
        {
            return new List<StudentAddmissionDetailModel>()
            {
                new StudentAddmissionDetailModel{ID = 1, Name = "Kamal", Class = "Six", DateofJoining = DateTime.Now.AddYears(-6)}
                , new StudentAddmissionDetailModel{ID = 2, Name = "Jamal", Class = "Six", DateofJoining = DateTime.Now.AddYears(-6)}
                , new StudentAddmissionDetailModel{ID = 3, Name = "Rony", Class = "Five", DateofJoining = DateTime.Now.AddYears(-5)}
                , new StudentAddmissionDetailModel{ID = 4, Name = "Jony", Class = "Five", DateofJoining = DateTime.Now.AddYears(-5)}
            };
        }
    }
}
