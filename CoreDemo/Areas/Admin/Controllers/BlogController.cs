using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workBook=new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("BlogListesi");
                workSheet.Cell(1, 1).Value = "Blog Id";
                workSheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    workSheet.Cell(BlogRowCount, 1).Value = item.Id;
                    workSheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application / vnd.openxmlformats - officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }
            }
               
        }
       public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{ Id=1,BlogName="c# a giriş"},
                new BlogModel{ Id=2,BlogName="python  a giriş"},
                new BlogModel{ Id=3,BlogName="c++  a giriş"},
            };
            return bm;
        }
    }
}
