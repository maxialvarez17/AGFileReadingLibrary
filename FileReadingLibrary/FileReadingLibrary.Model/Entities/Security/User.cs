using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Model.Entities.Security
{
    public class User
    {
        public static int AdminUserId = 1;
        public static int UserAId = 2;
        public static int UserBId = 3;

        public int Id { get; set; }

        public string Username { get; set; }
    }
}