using System.Threading.Tasks;
using BlazorTasksOnServer.Model;
using BlazorTasksOnServer.Repositories;
using Microsoft.AspNetCore.Components;

namespace BlazorTasksOnServer.Pages.Tasks
{
    public partial class EditTask
    {
        [Parameter]
        public string TaskId { get; set; }

        private TaskModel task = null;

        [Inject] ITasksRepository _taskService { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        protected override void OnInitialized()
        {
            task = _taskService.GetTask(TaskId);
        }

        public void UpdateTask()
        {
            _taskService.UpdateTask(task);
            _navManager.NavigateTo("mytasks");
        }
    }
}