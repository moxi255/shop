<%@ Application Language="C#" %>
<%@ Import Namespace="ep229" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.IO" %>
<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        Application["AccessCount"] = 0;

        Application["OnlineCount"] = 0;

        string file = Server.MapPath("/AccessCount.txt");
        if (File.Exists(file))
        {

            StreamReader sr = File.OpenText(file);

            Application["AccessCount"] = Int32.Parse(sr.ReadLine());
            sr.Close();

        }

        else
        {
            StreamWriter sw = File.CreateText(file);
            sw.WriteLine("1");
            sw.Close();
        }

    }

    void Application_End(object sender, EventArgs e){
   string file = Server.MapPath("AccessCount.txt");
        StreamWriter sw = new StreamWriter(file);
        sw.WriteLine(Application["/AccessCount"].ToString());
        sw.Close();
    }


    void Session_Start(object sender, EventArgs e)
    {
        Application.Lock();

        Application["OnlineCount"] = (int)Application["AccessCount"] + 1;
        Application["AccessCount"] = (int)Application["AccessCount"] + 1;
        Application.UnLock();
    }


    void Session_End(object sender, EventArgs e)
    {
        Application.Lock();

        Application["OnlineCount"] = (int)Application["OnlineCount"];
        Application.UnLock();
    }



</script>
