using System.Collections.Generic;

namespace ClassLibrary.Roles
{
    public class ManagerModel : IRoleModel
    {
        public string Name => "MANAGER";

        public string CertificationTitle => "Insert title for Manager certification!!";

        public int CountOfCertifications => 99;

        public bool IsRole { get; private set; }

        public List<CertificationModel> Certifications { get; set; } = new List<CertificationModel>();
    }
}