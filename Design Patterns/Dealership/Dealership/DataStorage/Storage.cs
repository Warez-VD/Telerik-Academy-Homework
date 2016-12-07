using System.Collections.Generic;
using Dealership.Contracts;

namespace Dealership.DataStorage
{
    public class Storage : IStorage
    {
        private ICollection<IUser> users;
        private IUser loggedUser;

        public Storage()
        {
            this.users = new List<IUser>();
            this.loggedUser = null;
        }

        public ICollection<IUser> Users
        {
            get { return this.users; }
        }

        public IUser LoggedUser
        {
            get { return this.loggedUser; }
            set { this.loggedUser = value; }
        }
    }
}
