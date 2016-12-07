using System.Collections.Generic;
using Dealership.Contracts;

namespace Dealership.DataStorage
{
    public interface IStorage
    {
        ICollection<IUser> Users { get; }

        IUser LoggedUser { get; set; }
    }
}
