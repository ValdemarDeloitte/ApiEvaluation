using ApiEvaluation.Models;

namespace ApiEvaluation.Services
{
    public interface IEvaluationService
    {
        void AddUser(UserItem newItem);
        List<UserItem> GetUsers();
        void updtaeUser(UserItem item);
        void GetUser(int id);

    }
    public interface IEvaluationInvService
    {
        void AddItem(UserItem newItem);
        List<UserItem> GetItems();
        void GetItem(int id);

    }
}
