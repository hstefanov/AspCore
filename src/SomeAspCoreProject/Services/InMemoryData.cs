using System;
using System.Collections.Generic;
using SomeAspCoreProject.Entities;

namespace SomeAspCoreProject.Services
{
    public class InMemoryData : IData
    {
        private List<SomeModel> _models;
        public InMemoryData()
        {
            _models = new List<SomeModel>
            {
                new SomeModel { Id=2, Content = "a" },
                new SomeModel { Id=3, Content = "b" },
                new SomeModel { Id=4, Content = "c" }
            };
        }
        public IEnumerable<SomeModel> GetAll()
        {
            return _models;
        }
    }
}
