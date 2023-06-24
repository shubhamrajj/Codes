using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Caching;

namespace CachingDemo
{
    public partial class DataCachingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string data = "";
            if(Cache["data"]==null)
            {
                data = File.ReadAllText(Server.MapPath("~/TextFile1.txt")); //create data for the first time
                //create cache file dependency

                var cacheDep = new CacheDependency(Server.MapPath("~/TextFile1.txt"));

                //Add Cache Data

               -- Cache.Add("data", data, cacheDep, new DateTime(2022, 03, 21, 13, 0, 0), Cache.NoSlidingExpiration, CacheItemPriority.High, null);
                //or

                --
               // Cache["data"] = data;//cache the data
            }
            else
            {
                data = Cache["data"].ToString();    
            }
            lblMsg.Text = data;
        }
    }
}