using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace IslahGroup.CMS
{
    public partial class Images : System.Web.UI.Page
    {
        CMSLogic cmsLogic;
        DataTable imagesTable;
        public Images()
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

        protected void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            string imageUploadPath = "";
            string imageText = TextBoxImageText.Text;

            if (FileUploadImage.HasFile)
            {
                string fileExtension = Path.GetExtension(FileUploadImage.PostedFile.FileName);
                imageUploadPath = @"~/Upload/Images/ImageGallery/" + DateTime.Now.ToString("hh_mm_ss_dd_MM_YYYY") + fileExtension;
                FileUploadImage.SaveAs(Server.MapPath(imageUploadPath));
            }

            if (!imageUploadPath.Equals(""))
            {
                Dictionary<string, string> newUpload = new Dictionary<string, string>()
                {
                    { "Text", imageText },
                    { "ImageUrl", imageUploadPath }
                };
                cmsLogic.UploadImage(newUpload);
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}