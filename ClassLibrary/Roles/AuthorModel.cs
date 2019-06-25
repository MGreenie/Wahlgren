using System.Collections.Generic;

namespace ClassLibrary.Roles
{
    public class AuthorModel : IRoleModel
    {
        public string Name => "AUTHOR";

        public string CertificationTitle => "Insert Author Certification title!!";

        public int CountOfCertifications => 5;

        public bool IsRole { get; private set; }

        public List<CertificationModel> Certifications { get; set; } = new List<CertificationModel>();

    }
}