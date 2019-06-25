using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IRoleModel
    {
        string Name { get; }
        string CertificationTitle { get; }
        int CountOfCertifications { get; }
        bool IsRole { get; }
        List<CertificationModel> Certifications { get; set; }
    }
}