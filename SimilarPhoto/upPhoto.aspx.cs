using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimilarPhoto
{
    public partial class upPhoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.HttpFileCollection _file = System.Web.HttpContext.Current.Request.Files;
            if (_file.Count > 0)
            {
                IsCheck(_file);
            }
        }
        public void IsCheck(HttpFileCollection _file)
        {
            SimilarPhoto sp = null;
            //文件大小   
            long size = _file[0].ContentLength;
            //文件类型   
            string type = _file[0].ContentType;
            //文件名   
            string name = _file[0].FileName;
            //文件格式   
            string _tp = System.IO.Path.GetExtension(name);
            string path = "";
            if (_tp.ToLower() == ".jpg" || _tp.ToLower() == ".jpeg" || _tp.ToLower() == ".gif" || _tp.ToLower() == ".png" || _tp.ToLower() == ".swf")
            {
                //获取文件流   
                System.IO.Stream stream = _file[0].InputStream;
                //保存文件   
                string saveName = DateTime.Now.ToString("yyyyMMddHHmmss") + _tp;
                path = Server.MapPath("upload") + "/" + saveName;
                _file[0].SaveAs(path);
            }
            if (!string.IsNullOrWhiteSpace(path))
            {
                sp = new SimilarPhoto(path);
                string getHash = sp.GetHash();
                string[] strArray = File.ReadAllLines("");
                string[] fit = null;
                foreach (var item in strArray)
                {
                    int count = SimilarPhoto.CalcSimilarDegree(getHash, item);
                    if (count < 5)
                    {
                        fit[fit.Length] = item;
                    }
                }
            }
        }
        /// <summary>
        /// 计算现有图库所有的图片hash指纹
        /// </summary>
        public void AllImageHash()
        {
            
        }
    }
}