using System.Collections.Generic;
using System.Linq;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private IList<IDecoration> decorationList;

        public DecorationRepository()
        {
            decorationList = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models => decorationList.ToList();

        public void Add(IDecoration model)
        {
            decorationList.Add(model);
        }

        public bool Remove(IDecoration model)
        {
            return decorationList.Remove(model);
        }

        public IDecoration FindByType(string type)
        {
            return decorationList.FirstOrDefault(t => t.GetType().Name == type);
        }
    }
}