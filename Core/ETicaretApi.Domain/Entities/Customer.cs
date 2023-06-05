using ETicaretApi.Domain.Entities.Common;

namespace ETicaretApi.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
