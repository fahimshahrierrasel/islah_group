using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.CMS
{
    public partial class Carousel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCarouselUpload_Click(object sender, EventArgs e)
        {
            string carouselName = DropDownListCarouselSelector.SelectedItem.Value.Replace(" ", String.Empty).ToLower();

            if (CarouselUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(CarouselUpload.PostedFile.FileName);
                string memberImageUploadPath = @"~/Upload/Images/Carousels/" + carouselName + fileExtension;
                RemoveFileIfExists(memberImageUploadPath);
                CarouselUpload.SaveAs(Server.MapPath(memberImageUploadPath));
            }
            else
            {
                Response.Write("<script>alert('No File Selected :(')</script>");
            }
            Response.Redirect(Request.RawUrl);
        }

        private void RemoveFileIfExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}