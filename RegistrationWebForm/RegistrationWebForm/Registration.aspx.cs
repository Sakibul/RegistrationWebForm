using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWebForm
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void enterInfoButton_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Session["firstName"] = Server.HtmlEncode(firstNameTextBox.Text);
                Session["lastName"] = Server.HtmlEncode(lastNameTextBox.Text);
                Session["address"] = Server.HtmlEncode(addressTextBox.Text);
                Session["city"] = Server.HtmlEncode(cityTextBox.Text);
                Session["stateOrProvince"] = Server.HtmlEncode(stateOrProvinceTextBox.Text);
                Session["zipCode"] = Server.HtmlEncode(zipCodeTextBox.Text);
                Session["country"] = Server.HtmlEncode(countryTextBox.Text);


                this.Response.Redirect("RegistrationResult.aspx"); // Redirect Page
            }
        }

        /*
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["address"] == null)
                {
                    enterUserInfoPanel.Visible = true;
                    userInfoPanel.Visible = false;
                }
                else
                {
                    enterUserInfoPanel.Visible = false;
                    userInfoPanel.Visible = true;

                    SetLabels();
                }
            }
        }

        protected void enterInfoButton_Click(object sender, EventArgs e)
        {
            enterUserInfoPanel.Visible = false;
            userInfoPanel.Visible = true;

            SetLabels();
        }
        */
    }
}