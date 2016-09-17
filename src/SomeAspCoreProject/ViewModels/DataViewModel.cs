using SomeAspCoreProject.Entities;
using System.Collections.Generic;

namespace SomeAspCoreProject.ViewModels
{
    public class DataViewModel
    {
        public IEnumerable<SomeModel> Data { get; set; }

        public string CurrentGreeting { get; set; }
    }
}
