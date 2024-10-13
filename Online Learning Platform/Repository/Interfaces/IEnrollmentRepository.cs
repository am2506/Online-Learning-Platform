using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Repository.Interfaces
{
    public interface IEnrollmentRepository
    {
        void Insert (Enrollment enrollment);
        void Save();
        bool check(int crsid, int userid);
    }
}
