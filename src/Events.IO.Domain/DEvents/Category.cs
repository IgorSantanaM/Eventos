using Events.IO.Domain.Core.Models;

namespace Events.IO.Domain.DEvents
{
    public class Category : Entity<Category>
    {
        public Category(Guid id)
        {
            Id = id;
        }
        public string Name { get; private set; }
        public virtual ICollection<DEvent> DEvents { get;  set; }

        protected Category() { }
        public override bool IsValidate()
        {
            return true;
        }
    }
}