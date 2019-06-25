using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ReaderModel : IRoleModel
    {
        public string Name => "READER"; 
        public string CertificationTitle => "Insert Reader Certification title!!"; 
        public int CountOfCertifications => 3; 
        public bool IsRole { get; private set; }
        public List<CertificationModel> Certifications { get; set; } = new List<CertificationModel>();
    }
}
