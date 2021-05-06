using System;
using System.Data;

namespace Strategy
{
    public class TeacherEmailStrategy : IEmailStrategy
    {
        public void ChangeEmail(User user, string email)
        {
            if (user.Email.Contains("@university.com"))
                Console.WriteLine("Changed email for teacher");
            else
                throw new DataException();
        }
    }
}