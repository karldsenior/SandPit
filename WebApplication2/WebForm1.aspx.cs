using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Collections;
using System.IO;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateLists();
        }


        protected void PopulateLists()
        {
            if (!Page.IsPostBack)
            {
                HelloWebService.HelloWebServiceSoapClient client = new HelloWebService.HelloWebServiceSoapClient();
                string xml = client.GetList();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                foreach (XmlNode node in doc.ChildNodes[0].ChildNodes)
                {
                    dropNames.Items.Add(new ListItem(node["Name"].InnerText, node["ID"].InnerText));
                } 
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            HelloWebService.HelloWebServiceSoapClient client = new HelloWebService.HelloWebServiceSoapClient();
            string xml = client.GetRecord(dropNames.SelectedValue);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            foreach (XmlNode node in doc.ChildNodes[0].ChildNodes)
            {
                Label1.Text = "Age: " + node["Age"].InnerText + "<br/>Favourite pop star: " + node["PopStar"].InnerText;
                break;
            }
        }


    }


}

