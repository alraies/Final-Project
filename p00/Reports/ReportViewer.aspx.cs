using Microsoft.Reporting.WebForms;
using p00.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Models;
namespace p00.Reports
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                

                //using (ReportViewerMVC.EntityFrameworkTestEntities _entities = new ReportViewerMVC.EntityFrameworkTestEntities())
                //{


                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/rpt/Degreeteacher.rdlc");


                //ReportDataSource RDS = newReportDataSource("DataSet1", datamodeltodataset());

                //ReportViewer1.LocalReport.DataSources.Add(RDS);
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Degreeteachers", GetEmployeeInfo()));
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();

                    // LoadReport();
              }
       }
       
        public List<DegreeTeachers> GetEmployeeInfo()
        {
            int x = 0, y = 0, f = 0, ave = 0;
            var list = new List<DegreeTeachers>();
            var evaluation = db.EvaluationForm.Where(a => a.iscurent == true).SingleOrDefault();
            var topicEV = db.TopicEVs.Where(a => a.EvaluationFormId == evaluation.id).ToList();
            var teacher = db.Teachers.Where(a => a.Vacation == false).ToList();
            var evaluationtosections = db.EvaluaationFormtoSections.Where(a => a.EvaluationFormID == evaluation.id).ToList();
            var top = db.Topics.ToList();
            int c = 1;
            foreach (var item in teacher)
            {
                ave = 0;
                var fo = db.TopicEVs.Where(a => a.TeacherId == item.Id).ToList();
                if (fo.Count()>0) 
                {
                    foreach (var item1 in evaluationtosections)
                    {
                        f = 0;
                        x = 0;
                        y = 0;
                        foreach (var item2 in topicEV)
                        {
                            if (item2.TeacherId == item.Id && item2.SectionsId == item1.SectionsID)
                            {
                                x = x + item2.Points;

                                var t = top.Where(a => a.Id == item2.TopicsId).SingleOrDefault(); ;
                                y = y + t.TotalPoints;
                            }
                        }
                        var s = db.Sections.Find(item1.SectionsID);
                        f = ((x * s.TotalPoints) / y);
                        ave += f;
                    }
                    list.Add(new DegreeTeachers { id = c++, FullName = item.FullName, ave = ave, year = evaluation.year });
                }
            }
            return list;
        }
    }
}