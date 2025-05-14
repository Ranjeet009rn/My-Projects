
using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;

using System.Net;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for MessageSender
/// </summary>
public class MessageSender
{
    public MessageSender()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static void SendSMS(string phoneNo, string message)
    {
        //string url = "http://login.bulksmsgateway.in/unicodesmsapi.php";
        //string result = "";
        //message = HttpUtility.UrlPathEncode(message);
        //String strPost = "?username=" + HttpUtility.UrlPathEncode("mlmsofttech") + "&password=" + HttpUtility.UrlPathEncode("mlmsofttech@123") +
        //   "&senderid=" + HttpUtility.UrlPathEncode("ARTIKA") + "&mobilenumber=" + HttpUtility.UrlPathEncode(phoneNo) + "&type=" + HttpUtility.UrlPathEncode("3") + "&message=" + message;
        //StreamWriter myWriter = null;
        //HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url + strPost);
        //objRequest.Method = "POST";
        //objRequest.ContentLength = Encoding.UTF8.GetByteCount(strPost);
        //objRequest.ContentType = "application/x-www-form-urlencoded";
        //try
        //{
        //    myWriter = new StreamWriter(objRequest.GetRequestStream());
        //    myWriter.Write(strPost);
        //}
        //catch { }
        //finally
        //{
        //    myWriter.Close();
        //}
        //HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
        //using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
        //{
        //    result = sr.ReadToEnd();
        //    // Close and clean up the StreamReader sr.Close();
        //}
    }
}