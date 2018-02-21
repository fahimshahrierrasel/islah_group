using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Data;

namespace IslahGroup
{
    public partial class VideoGallery : System.Web.UI.Page
    {
        CMSLogic cmsLogic;
        DataTable videosTable;
        public VideoGallery()
        {
            cmsLogic = new CMSLogic();
            videosTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateImageTable();
        }
        public void PopulateImageTable()
        {
            videosTable.Clear();
            videosTable = cmsLogic.GetAllVideo();
            RepeaterAllVideos.DataSource = videosTable;
            RepeaterAllVideos.DataBind();
        }
    }
}