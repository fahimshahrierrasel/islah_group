using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public static class BranchInfo
    {
        public static int BranchId { get; set; }
        public static string BranchCode { get; set; }
        public static int UserId { get; set; }
        public static string Username { get; set; }

        public static void SetBranchInfo(int branchId, string branchCode, int userId, string username)
        {
            BranchId = branchId;
            BranchCode = branchCode;
            UserId = userId;
            Username = username;
        }
    }
}
