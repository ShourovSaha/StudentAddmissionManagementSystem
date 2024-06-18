using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        private readonly List<StudentAttendanceDetailsModel> _strudentAddmissionData;
        public StudentAttendanceController()
        {
            _strudentAddmissionData = getAllStrudentsAddmissionData();
        }

        public ActionResult<List<StudentAttendanceDetailsModel>> Get()
        {
            return _strudentAddmissionData ?? new List<StudentAttendanceDetailsModel>();
        }

        private List<StudentAttendanceDetailsModel> getAllStrudentsAddmissionData()
        {
            return new List<StudentAttendanceDetailsModel>()
            {
                new StudentAttendanceDetailsModel{ID = 1, Name = "Kamal", AttendencePercentage = 80.00 }
                , new StudentAttendanceDetailsModel{ID = 2, Name = "Jamal", AttendencePercentage = 90.00 }
                , new StudentAttendanceDetailsModel{ID = 3, Name = "Rony", AttendencePercentage = 66.50 }
                , new StudentAttendanceDetailsModel{ID = 4, Name = "Jony", AttendencePercentage = 20.00 }
            };
        }
    }
}
