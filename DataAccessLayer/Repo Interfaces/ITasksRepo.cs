
using DataAccessLayer.Model;

namespace DataAccessLayer.IRepository
{
    public interface ITasksRepo
    {
        List<Person> GetTasks();
        bool CreatePerson(Person person);
        Person GetPersonByName(string name);
        List<Tasks> GetListOfTasksByName(string Name);
        List<Tasks> GetListOfCompleTaskByName(string Name);
        bool PersonExists(string name);
        bool Save();
    }
}
