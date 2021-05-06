using System;

namespace Strategy
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }

        public IEmailStrategy EmailStrategy { get; set; }
        
        public void ChangeEmail(string email)
        {
            EmailStrategy.ChangeEmail(this, email);
        }
    }
}