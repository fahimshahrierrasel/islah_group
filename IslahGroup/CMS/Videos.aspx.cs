using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace IslahGroup.CMS
{
    public partial class Videos : System.Web.UI.Page
    {
        CMSLogic cmsLogic;
        DataTable videoTable;
        public Videos()
        {
            cmsLogic = new CMSLogic();
            videoTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateVideoTable();
        }
        public void PopulateVideoTable()
        {
            videoTable.Clear();
            videoTable = cmsLogic.GetAllVideo();
            RepeaterAllVideos.DataSource = videoTable;
            RepeaterAllVideos.DataBind();
        }
        protected void ButtonUploadVideo_Click(object sender, EventArgs e)
        {
            string videoUrl = TextBoxVideoUrl.Text;
            string videoText = "https://www.youtube.com/embed/" + TextBoxVideoText.Text;

            Dictionary<string, string> newUpload = new Dictionary<string, string>()
            {
                { "Text", videoText },
                { "VideoUrl", videoUrl }
            };
            cmsLogic.UploadVideo(newUpload);
            Response.Redirect(Request.RawUrl);
        }
    }
}