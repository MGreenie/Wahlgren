using System.Collections.Generic;

namespace ClassLibrary.Roles
{
    public class ReviewerModel : IRoleModel
    {
        public string Name => "REVIEWER";

        public string CertificationTitle => "Insert title for Reviewer certification!!";

        public int CountOfCertifications => 99;

        public bool IsRole { get; private set; }

        public List<CertificationModel> Certifications { get; set; } = new List<CertificationModel>();
    }
}