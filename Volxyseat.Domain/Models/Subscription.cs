using Volxyseat.Domain.Core;

namespace Volxyseat.Domain.Models
{
    public class Subscription : Entity
    {
        private readonly List<SubscriptionHistory> _histories;

        public Subscription(
            SubscriptionEnum typeId,
            SubscriptionStatus statusId,
            string description,
            double price,
            DateTime createdOn,
            DateTime updatedOn)
        {
            TypeId = typeId;
            StatusId = statusId;
            Description = description;
            Price = price;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            _histories = new List<SubscriptionHistory>();
        }

        public SubscriptionEnum TypeId { get; private set; }
        public SubscriptionStatus StatusId { get; private set; }
        public IReadOnlyList<SubscriptionHistory> Histories => _histories;
        public string Description { get; private set; }
        public double Price { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime UpdatedOn { get; private set; }
    }
}