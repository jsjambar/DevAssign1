using DatabaseManagementTool.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool.Models
{
    class Project : ORM
    {
        public int Id;
        public string Name { get; set; }
        public string Location { get; set; }
        public int Budget;
        public int Hours;

        Database database = new Database();

        public void Create(object model)
        {
            Project insertable_project = new Project { Name = Name, Location = Location, Budget = Budget, Hours = Hours };
            string create_project = $"INSERT INTO `projects` (`name`, `location`, `budget`, `hours`) VALUES ('{Name}' ,'{Location}', '{Budget}', '{Hours}')";
            database.DoQuery(create_project);
        }

        public void Delete(int id)
        {
            string delete_project = $"UPDATE `projects` SET `boolean_deleted` = 1 WHERE `id` = '{id}'";
            database.DoQuery(delete_project);
        }

        public object Find(int id)
        {
            string find_project = $"SELECT * FROM `projects` WHERE `boolean_deleted` = 0 and `id` = {id}";
            List<Project> projects = database.projectQuery(find_project);

            return projects;
        }

        public object FindAll()
        {
            string getall_projects = "SELECT * FROM `projects` WHERE `boolean_deleted` = 0";
            List<Project> projects = database.projectQuery(getall_projects);

            return projects;
        }

        public object FindLast()
        {
            throw new NotImplementedException();
        }

        public void Update(object model)
        {
            Project project = (Project)model;
            string update_project = $"UPDATE `projects` SET `name` = '{project.Name}', `location` = '{project.Location}', `budget` = '{project.Budget}', `hours` = '{project.Hours}' WHERE `id` = '{project.Id}'";
            database.DoQuery(update_project);
        }
    }
}
