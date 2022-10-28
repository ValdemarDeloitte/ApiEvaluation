using ApiEvaluation.Models;

namespace ApiEvaluation.Services
{
    public class EvaluationService : IEvaluationService
    {
        private static List<UserItem> userList = new List<UserItem>();
        public void AddUser(UserItem newItem)
        {
            newItem.Id = userList.Count + 1;
            userList.Add(newItem);
        }

        public List<UserItem> GetUsers()
        {
            return userList;
        }

        public void updtaeUser(UserItem itemToUpdate)
        {
            {
                UserItem itemUpdated = new UserItem();
                foreach (UserItem user in userList)
                {
                    if (user.Id == itemToUpdate.Id)
                    {
                        user.Name = itemToUpdate.Name;
                        user.Email = itemToUpdate.Email;
                        user.Phone = itemToUpdate.Phone;
                        itemUpdated = user;

                    }
                }
            }
        }

        public void GetUser(int id)
        {
            foreach (UserItem user in userList)
            {
                if (user.Id == id)
                {
                    return;

                }
            }
        }
    }
    public class EvaluationInvService : IEvaluationInvService
    {
        private static List<UserItem> invItem = new List<UserItem>();
        public void AddItem(UserItem newItem)
        {
            newItem.Id = invItem.Count + 1;
            invItem.Add(newItem);
        }

        public List<UserItem> GetItems()
        {
            return invItem;
        }

        public void GetItem(int id)
        {
            foreach (UserItem user in invItem)
            {
                if (user.Id == id)
                {
                    return;

                }
            }
        }
    }
}
