using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Model.Entities.Security
{
    public class Role
    {
        public static int AdminRoleId = 1;
        public static int AuditorRoleId = 2;
        public static int ManagerRoleId = 3;

        public int Id { get; set; }

        public string Name { get; set; }
    }
}