using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Yazilimpark.Models;

namespace Yazilimpark.Services
{
    public class ProjectService: IProjectService
    {
        private static List<ProjectModel> _list;

        public ProjectService()
        {
            InitializeList();
        }
        private void InitializeList()
        {
            var file = File.ReadAllText("project.json");
            var data = JsonSerializer.Deserialize<List<ProjectModel>>(file);
            _list = data;
        }

        public List<ProjectModel> GetProjects()
        {
            return _list;
        }
    }

    public interface IProjectService
    {
        List<ProjectModel> GetProjects();
    }
}