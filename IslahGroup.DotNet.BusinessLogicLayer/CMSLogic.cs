using IslahGroup.DotNet.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public DataTable GetAllImage()
        {
            DataTable allImages = new DataTable();
            allImages = cmsData.GetAllImage();
            return allImages;
        }
        public DataTable GetAllVideo()
        {
            DataTable allImages = new DataTable();
            allImages = cmsData.GetAllVideo();
            return allImages;
        }
        public bool UploadImage(Dictionary<string, string> newImage)
        {
            SqlParameter[] parameters = new SqlParameter[newImage.Count];
            parameters[0] = new SqlParameter("Text", newImage["Text"]);
            parameters[1] = new SqlParameter("ImageUrl", newImage["ImageUrl"]);

            cmsData.UploadNewImage(parameters);
            return true;
        }
        public bool UploadVideo(Dictionary<string, string> newImage)
        {
            SqlParameter[] parameters = new SqlParameter[newImage.Count];
            parameters[0] = new SqlParameter("Text", newImage["Text"]);
            parameters[1] = new SqlParameter("VideoUrl", newImage["VideoUrl"]);

            cmsData.UploadNewVideo(parameters);
            return true;
        }
    }
}
