using System;
using System.Web;
using System.Web.Caching;

namespace Day9_10
{
    public partial class Default : System.Web.UI.Page
    {
        HttpBrowserCapabilities brows;
        CacheDependency cache1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void StoreBrowserClick(object sender, EventArgs e)
        {
            try
            {
                brows = Request.Browser;
                Cache["name"] = brows.Browser;
                Cache["version"] = brows.Version;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void ExpireCacheClick(object sender, EventArgs e)
        {
            try
            {
                brows = Request.Browser;
                Cache.Insert("name", brows.Browser, null, DateTime.Now.AddSeconds(15), Cache.NoSlidingExpiration);
                Cache.Insert("version", brows.Version, null, DateTime.Now.AddSeconds(15), Cache.NoSlidingExpiration);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void AddDate(object sender, EventArgs e)
        {
            Cache["currentdate"] = DateTime.Now.Date.ToString("d");
        }

        //Function for clear cache on file modification
        protected void FileModify(object sender, EventArgs e)
        {
            try
            {
                cache1 = new CacheDependency(Server.MapPath("Sample.txt"));
                Cache.Insert("name", cache1);
                Cache.Insert("version", cache1);
                Cache.Insert("currentdate", cache1);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}