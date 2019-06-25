using System.Collections.Generic;

namespace ClassLibrary.Roles
{
    public class SupervisorModel : IRoleModel
    {
        public string Name => "SUPERVISOR";

        public string CertificationTitle => "Insert title for Supervisor certification!!";

        public int CountOfCertifications => 99;

        public bool IsRole { get; private set; }

        public List<CertificationModel> Certifications { get; set; } = new List<CertificationModel>();
    }
}