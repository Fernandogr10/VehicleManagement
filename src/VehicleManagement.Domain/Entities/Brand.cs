using System.Collections.Generic;
using System.Linq;

namespace VehicleManagement.Domain.Entities
{
    public class Brand : Entity
    {
        private readonly IList<Model> _models;

        public Brand(string name)
        {
            Name = name;
            _models = new List<Model>();
        }
        
        public string Name { get; private set; }
        public IReadOnlyCollection<Model> Models => _models.ToArray();

        public void AddModel(Model model)
        {
            _models.Add(model);
        }
    }
}