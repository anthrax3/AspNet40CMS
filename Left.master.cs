using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Left : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string counter = Application["counter"].ToString();
        for (int i = 0; i < counter.Length; i++)
        {
            Image img = new Image();
            img.ImageUrl = "images/" + counter[i] + ".bmp";
            img.Height = 30;
            img.Width = 30;
            pnlCounter.Controls.Add(img);
        }
    }

    protected void btnSubscribe_Click(object sender, EventArgs e)
    {
        // 메세지를 위한 변수
        string Message = "";
        string connectionString = WebConfigurationManager.ConnectionStrings["ASPNET"].ConnectionString;

    }
}
