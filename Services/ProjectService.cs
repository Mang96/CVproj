using DataWS1;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProjectService
    {
        public void SaveNewProject(ProjectCreateModel model)
        {
            using (var context = new ApplicationDbContext())
            {
                var newProject = new Project()
                {
                    Title = model.Title
                };

                var filename = model.Image.FileName;
                var filepath = Server.MapPath("~/ProjectImages");
                model.Image.SaveAs(filepath + "/" + filename);

                newProject.ImagePath = filename;

                context.Projects.Add(newProject);
                context.SaveChanges();
            }
        }
    }
}
