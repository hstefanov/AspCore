using SomeAspCoreProject.Models;
using System.Collections.Generic;

namespace SomeAspCoreProject.Services
{
    public interface IData
    {
        IEnumerable<SomeModel> GetAll();
    }
}
