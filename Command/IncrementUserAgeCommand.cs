using System;
using Strategy;

namespace Command
{
    public class IncrementUserAgeCommand : ICommand
    {
        private readonly User _user;

        public IncrementUserAgeCommand(User user)
        {
            _user = user;
        }
        
        public bool CanExecute()
        {
            return _user?.Age > 0;
        }

        public void Execute()
        {
            if (_user is null)
                throw new InvalidOperationException();
            
            _user.Age++;
        }

        public void Undo()
        {
            if (_user is null)
                throw new InvalidOperationException();
            
            _user.Age--;
        }
    }
}