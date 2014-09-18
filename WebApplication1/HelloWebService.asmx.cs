using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Collections;
using System.Data;
using System.IO;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for HelloWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HelloWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetList()
        {
            return(PeopleXML(null));
        }


        [WebMethod]
        public string GetRecord(string strID)
        {
            return (PeopleXML(strID));
        }


        static string PeopleXML(string strID)
        {
                 
            DataTable dt = new DataTable() { TableName = "People" };
            DataColumn keyColumn = dt.Columns.Add("ID", typeof(System.Int32));

            dt.Clear();
            dt.Columns.Add("Name", typeof(System.String));
            dt.Columns.Add("Age", typeof(System.String));
            dt.Columns.Add("PopStar", typeof(System.String));
            dt.PrimaryKey = new DataColumn[] { keyColumn };

            ArrayList arr = arrPeople(strID);
            for (int i = 0; i < arr.Count; i++)
            {
                MyDetails md = (MyDetails)arr[i];
                dt.Rows.Add(new object[] { Convert.ToInt32(md.ID), md.Name, md.Age, md.PopStar });
            }

            dt.AcceptChanges();

            string xml = string.Empty;
            using (TextWriter writer = new StringWriter())
            {
                dt.WriteXml(writer);
                xml = writer.ToString();
            }
        
            return (xml);
        }


        static ArrayList arrPeople(string strID)
        {
            MyDetails md;
            
            ArrayList aList = new ArrayList();

            md = new MyDetails();
            md.ID = "123";
            md.Name = "Karlos";
            md.Age = "40";
            md.PopStar = "Shaking Stevens";
            aList.Add(md);

            md = new MyDetails();
            md.ID = "456";
            md.Name = "Johnny B";
            md.Age = "31";
            md.PopStar = "Beyonce";
            aList.Add(md);

            md = new MyDetails();
            md.ID = "789";
            md.Name = "Jim Bob";
            md.Age = "17";
            md.PopStar = "Girls Aloud";
            aList.Add(md);

            if (!string.IsNullOrEmpty(strID))
            {
                for (int i = 0; i < aList.Count; i++)
                {
                    md = (MyDetails)aList[i];
                    if (md.ID == strID)
                    {
                        aList.Clear();
                        aList.Add(md);
                        break;
                    }
                }
            }

            return (aList);
        }

    }

    public class MyDetails
    {
        public string ID;
        public string Name;
        public string Age;
        public string PopStar;
    }
}
