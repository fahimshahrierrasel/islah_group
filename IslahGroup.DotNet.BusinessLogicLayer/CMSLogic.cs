using IslahGroup.DotNet.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class CMSLogic
    {
        CMSData cmsData;
        public CMSLogic()
        {
            cmsData = new CMSData();
        }
        public DataTable GetOwnersShortBio()
        {
            DataTable ownersBio = new DataTable();
            ownersBio = cmsData.GetOwnerShortBio();
            return ownersBio;
        }
    }
}
