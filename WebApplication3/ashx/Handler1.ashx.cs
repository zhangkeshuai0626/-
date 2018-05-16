using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApplication3.ashx
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            string sql = "INSERT INTO ClientUserInfo(Name,Age,Sex,Mail,Address,PhoneNum,UrgentPeopel,UrgentPhoneNum,EditerText) VALUES(";
            if (!string.IsNullOrWhiteSpace(context.Request.Params["name"]))
            {
                sql += "'" + context.Request.Params["name"] + "',";
            }
            if (!string.IsNullOrWhiteSpace(context.Request.Params["age"]))
            {
                sql += "'" + context.Request.Params["age"] + "',";
            }
            if (!string.IsNullOrWhiteSpace(context.Request.Params["sex"]))
            {
                sql += "'" + context.Request.Params["sex"] + "',";
            }
            if (!string.IsNullOrWhiteSpace(context.Request.Params["mail"]))
            {
                sql += "'" + context.Request.Params["mail"] + "',";
            }
            if (!string.IsNullOrWhiteSpace(context.Request.Params["address"]))
            {
                sql += "'" + context.Request.Params["address"] + "',";
            }
            if (!string.IsNullOrWhiteSpace(context.Request.Params["phoneNum"]))
            {
                sql += "'" + context.Request.Params["phoneNum"] + "',";
            }
            if (!string.IsNullOrWhiteSpace(context.Request.Params["urgentPeopel"]))
            {
                sql += "'" + context.Request.Params["urgentPeopel"] + "',";
            }
            if (!string.IsNullOrWhiteSpace(context.Request.Params["urgentPhoneNum"]))
            {
                sql += "'" + context.Request.Params["urgentPhoneNum"] + "',";
            }
            if (!string.IsNullOrWhiteSpace(context.Request.Params["editerText"]))
            {
                sql += "'" + context.Request.Params["editerText"] + "',";
            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ")";
            context.Response.Write(sql);
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}