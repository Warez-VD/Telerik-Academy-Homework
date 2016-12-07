using SchoolSystem.Framework.Models.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Framework.DataStorage
{
    public interface IStorage
    {
        IDictionary<int, IStudent> Students { get; }

        IDictionary<int, ITeacher> Teachers { get; }
    }
}
