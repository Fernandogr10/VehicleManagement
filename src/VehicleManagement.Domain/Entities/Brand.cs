using System.Collections.Generic;

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
        public IReadOnlyCollection<Model> Models { get; set; }

        public void AddModel(Model model)
        {
            _models.Add(model);
        }
    }
}