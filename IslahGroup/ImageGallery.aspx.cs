using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Data;

namespace IslahGroup
{
    public partial class ImageGallery : System.Web.UI.Page
    {
        CMSLogic cmsLogic;
        DataTable imagesTable;
        public ImageGallery()
        {
            cmsLogic = new CMSLogic();
            imagesTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateImageTable();
        }
        public void PopulateImageTable()
        {
            imagesTable.Clear();
            imagesTable = cmsLogic.GetAllImage();
            RepeaterAllImages.DataSource = imagesTable;
            RepeaterAllImages.DataBind();
        }
    }
}