using System;
using System.Data;

namespace Strategy
{
    public class StudentEmailStrategy : IEmailStrategy
    {
        public void ChangeEmail(User user, string email)
        {
            if (user.Email.Contains($"{user.Name}.{user.Surname}"))
                Console.WriteLine("Changed email for student");
            else
                throw new DataException();
        }
    }
}