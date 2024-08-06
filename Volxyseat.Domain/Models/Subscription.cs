using Volxyseat.Domain.Core;

namespace Volxyseat.Domain.Models
{
    public class Subscription : Entity<Guid>
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
            _typeId = typeId;
            _statusId = statusId;
            Description = description;
            Price = price;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            _histories = new List<SubscriptionHistory>();
        }

        public SubscriptionEnum _typeId { get; private set; }
        public SubscriptionStatus _statusId { get; private set; }
        public IReadOnlyList<SubscriptionHistory> Histories => _histories;
        public string Description { get; private set; }
        public double Price { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime UpdatedOn { get; private set; }
    }
}