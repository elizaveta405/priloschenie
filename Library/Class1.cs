using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
        public class Application
    {
        //application - ссылка на единственный экземпляр класса приложения.
        //taskLists - список со списком задач.

        Application application { get; set; }
        List<TaskList> taskList { get; set; }
        //GetApplication - возвращает ссылку на экземпляр приложения, а в
        //его отсутствие создает экземпляр.
        Application GetApplication()
        {
            return application;
        }
        //CreateTaskList - Создает список задач с указанным именем и
        //добавляет его в taskLists.
        TaskList CreateTaskList(string name)
        {
            taskList = new List<TaskList>();
            return name;
        }
        //GetTaskListNames - возвращает имена списков задач
        string[] GetTaskListNames()
        {
            string[] names = new string[taskList.Count];
            return names;
        }
        //GetTaskByName - возвращает список задач по имени списка
        TaskList GetTaskListByName(string name)
        {
            TaskList taskList = new TaskList();
            return taskList;
        }
        //GetTasksByToday - получает задачи запланированные на сегодня в
        //хронологическом порядке.
        Task[] GetTaskByToday()
        {
            List<Task> tasks = new List<Task>();
            return;
        }
        //GetTasksByFuture - получает задачи запланированные завтра и
        //позже в хронологическом порядке.
        Task[] GetTaskByFuture()
        {
            return;
        }
    }
     public class TaskList
    { 
        //name - имя списка с задачами.
        //tasks - список задач, относящихся к списку.
        string name { get; set; }
        List<Task> tasks { get; set; }
        
        TaskList(string name)
        {

        }
        //GetName - возвращает имя списка задач
        public string GetName(string name)
        {
            return name;
        }
        //AddTask - добавляет задачу в список задач
        void AddTask(Task task)
        {
            tasks = new List<Task>();
        }
        //GetTasks - возвращает список всех задач
        public Task[] GetTasks ()
        {
            return tasks.ToArray();
        }
        //Remove - удаляет задачу из списка задач
        void Remove(Task task)
        {

        }
        //GetTasksByToday - возвращает задачи запланированные на сегодня
        //в хронологическом порядке.
        Task[] GetTasksByToday()
        {
            return GetTasks();
        }
//        GetTasksByFuture - возвращает задачи на завтра и позже в
//        хронологическом порядке.
        Task[] GetTasksByFuture()
        {
            return GetTasks();
        } 

    }
    
    public class Task
    {
        //Title - Название задачи.
        //Due - Дата и время завершения задачи.
        //Done - отметка о выполнении задачи.
        string Title { get; set; }
        DateTime Due { get; set; }
        Boolean Done { get; set; }
    }
}
