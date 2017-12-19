using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using MyMediaBox.Models;

namespace MyMediaBox.Reports
{
    public partial class Projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AllProjects projects;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AllProjects));
            using (FileStream fileStream = new FileStream(Server.MapPath("/App_Data/Project.xml"), FileMode.Open))
            {
                projects = (AllProjects)xmlSerializer.Deserialize(fileStream);
            }
            foreach(var proj in projects.Proj)
            {
                if (proj.AllSubmissions == null)
                {
                    TableRow row = new TableRow();
                    TableCell[] cells = new TableCell[5];
                    for (int i = 0; i < cells.Length; i++)
                        cells[i] = new TableCell();
                    cells[0].Text = $"{proj.ProjectID}";
                    cells[1].Text = $"{proj.ProjectNumber}";
                    row.Cells.AddRange(cells);
                    tabProjects.Rows.Add(row);
                }
                else
                {
                    foreach (var sub in proj.AllSubmissions)
                    {
                        TableRow row = new TableRow();
                        TableCell[] cells = new TableCell[5];
                        for (int i = 0; i < cells.Length; i++)
                            cells[i] = new TableCell();
                        cells[0].Text = $"{proj.ProjectID}";
                        cells[1].Text = $"{proj.ProjectNumber}";
                        cells[2].Text = $"{sub.Type}";
                        cells[3].Text = $"{sub.SubmissionID}";
                        cells[4].Text = $"{sub.SubmissionNumber}";
                        row.Cells.AddRange(cells);
                        tabProjects.Rows.Add(row);
                    }
                }
            }
        }
    }
}