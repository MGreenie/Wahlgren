using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Roles
{
    public class RoleFactory
    {
        public static IRoleModel Get(string name)
        {
            switch(name)
            {
                case "AUTHOR":
                    return new AuthorModel();
                case "REVIEWER":
                    return new ReviewerModel();
                case "SUPERVISOR":
                    return new SupervisorModel();
                case "MANAGER":
                    return new ManagerModel();
                default:
                    return new ReaderModel();
            }
        }
    }
}
