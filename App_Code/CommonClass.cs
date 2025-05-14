using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.IO;

public class CommonClass
{
    public static string Sucess = "success";
    public static string Error = "error";
    public static string Warning = "warning";
    public static string Info = "info";
    //public static double currentLimt;

    public CommonClass()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static string MessageBox(string messageType = "", string message = "")
    {
        string notification = string.Empty;
        try
        {
            switch (messageType)
            {
                case "info":
                    notification = "<div class=\"info animated flash\"><div style='color: green; font-size: 18px;'>" + message + "</div></div>";
                    break;
                case "warning":
                    notification = "<div class='alert dark alert-warning alert-dismissible' role='alert'> <button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button><div class=\"warning animated flash\"><div style='color: white;font-size: 18px;'>" + message + "</div></div></div>";
                    break;
                case "error":
                    notification = "<div class='alert dark alert-danger alert-dismissible' role='alert'> <button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button><div class=\"error animated flash\"><div style='color: white;font-size: 18px;'>" + message + "</div></div></div>";
                    break;
                case "success":
                    notification = "<div class='alert dark alert-success alert-dismissible' role='alert'> <button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button><div class=\"success animated flash\"><div style='color: white;font-size: 18px;'>" + message + "</div></div></div>";
                    break;
                default:
                    notification = string.Empty;
                    break;
            }
        }
        catch{}
        return notification;
    }

    public static string GetFundWallet(string usernm)
    {
        JoinUsDbmlFileDataContext db = new JoinUsDbmlFileDataContext();
        double fundInward = 0, outward = 0;
        try
        {
            fundInward = (double)db.tbl_FranchiseeDeposits.Where(x => x.franchiseeId == usernm && x.status == true).Sum(x => x.amount);
        }
        catch { }
        try
        {
            outward = (double)db.tbl_PackageRequests.Where(x => x.memberId == usernm).Sum(x => x.amount);
        }
        catch { }

        return (fundInward - outward).ToString();
    }


    public static void SendWhatsupMsg(string msg, string mobile)
    {
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        // string msg = "Welcome " + txtFname.Text.Trim() + " to Genpharma Your userid is " + id + "and password is " + password + "\n\n Visit to www.genpharma.org";
        //string Uri = "https://chatway.in/api/send-msg?username=sanglisoftware&number=91" + mobile +
        //"&message=" + msg + "&token=a1ArUm1XeU5EVDJjemFjeHNGWS81UT09";
       // string Uri = "http://api.iconicsolution.co.in/wapp/v2/api/send?apikey=131f99a88a254b78a2de286a91793da2&mobile=" + mobile + "&msg=" + msg;
        string Uri = "http://api.iconicsolution.co.in/wapp/v2/api/send?apikey=6fdd5a88134f4a60aac8c40319145309&mobile=" + mobile + "&msg=" + msg;
        HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(Uri);
        httpWReq.Method = "GET";
        httpWReq.ContentType = "application/json";
        HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string responseString = reader.ReadToEnd();
        reader.Close();
        response.Close();

    }
}

//public class DataItem
//{
//    public int LevelNo { get; set; }
//    public decimal TotalAmount { get; set; }
//}

//public class RankItem
//{
//    public int LevelNo { get; set; }
//    public string RankName { get; set; }
//}