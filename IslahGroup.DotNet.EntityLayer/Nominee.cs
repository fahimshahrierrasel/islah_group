using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslahGroup.DotNet.EntityLayer
{
    class Nominee
    {
        public int NomineeId { get; set; }
        public int MemberId { get; set; }
        public string NID { get; set; }
        public string Name { get; set; }
        public string FatherHusbandName { get; set; }
        public string MotherName { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Realtion { get; set; }
        public string Profession { get; set; }
        public string MobileNo { get; set; }
        public string ImageUrl { get; set; }
    }
}
