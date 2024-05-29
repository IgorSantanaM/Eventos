using Events.IO.Domain.Core.Models;
using FluentValidation;
using Events.IO.Domain.Hosts;

namespace Events.IO.Domain.DEvents
{
    public class DEvent : Entity<DEvent>
    {
        public DEvent(string name, DateTime beginDate, DateTime endDate, bool free, decimal price, bool online, string companyName)
        {
            Id = Guid.NewGuid();
            Name = name;
            BeginDate = beginDate;
            EndDate = endDate;
            Free = free;
            Price = price;
            Online = online;
            CompanyName = companyName;
        }

        public DEvent() {}

		public string Name { get; protected set; }
		public string ShortDescription { get; protected set; }
		public string LongDescription { get; protected set; }
		public DateTime BeginDate { get; protected set; }
		public DateTime EndDate { get; protected set; }
		public bool Free { get; protected set; }
		public decimal Price { get; protected set; }
		public bool Online { get; protected set; }
		public string CompanyName { get; protected set; }
		public bool Deleted { get; protected set; }
		public ICollection<Tags> Tags { get; protected set; }
		public Guid? CategoryId { get; protected set; }
		public Guid? AddressId { get; protected set; }
		public Guid? HostId { get; protected set; }


        //EF
        public virtual Category Category { get; private set; }
        public virtual Address Address { get; private set; }
        public virtual Host Host { get; private set; }


        public void AssignAddress(Address address)
        {
            if (!address.IsValidate()) return;
            Address = address;
        }
        public void DeleteEvent()
        {
            Deleted = true;
        }
        
        public void AssignCategory(Category category)
        {
            if (!category.IsValidate()) return;
            Category = category;
        }
        public override bool IsValidate()
        {
			Authenticate();
            return ValidationResult.IsValid;
        }
        #region Validations

        private void Authenticate()
        {
            NameValidation();
            CompanyNameValidation();
            DateValidation();
            LocalValidation();
            PriceValidation();
            ValidationResult = Validate(this);

            //Validacoes adicionais
            AddressValidate();
        }
        private void NameValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The name must be declared")
                .Length(2, 150).WithMessage("The event name must be between 2 and 15");
        }
        private void PriceValidation()
        {
            RuleFor(c => c.Price)
                .Must((c, price) => !c.Free || (price >= 0 && price <= 50000))
                .WithMessage("The event price must be between 0 and 50000 if not free.");
        }

        private void DateValidation()
        {
            RuleFor(c => c.BeginDate)
                .LessThan(c => c.EndDate)
                .WithMessage("The event cannot begin after its end");

            RuleFor(c => c.BeginDate)
                .GreaterThan(DateTime.Now)
                .WithMessage("The event cannot begin before the current date");
        }
        private void LocalValidation()
        {
            if (Online)
                RuleFor(c => c.Address)
                    .Null().When(c => c.Online)
                    .WithMessage("The event don't need an address since it's online.");


            if (!Online)
                RuleFor(c => c.Address)
                    .NotNull().When(c => c.Online == false)
                    .WithMessage("The event address must be declared.");
        }
        private void CompanyNameValidation()
        {
            RuleFor(c => c.CompanyName)
                .NotEmpty().WithMessage("The host name must be declared")
                .Length(2, 150).WithMessage("The host name must be between 2 and 150 chars.");
        }


        private void AddressValidate()
        {
            if (Online) return;
            if (Address.IsValidate()) return;

            foreach(var error in Address.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }
        #endregion

        public static class EventFactory
        {
            public static DEvent NewCompletedEvent(Guid id,
                string name,
                string shortDesc, 
                string longDesc,
                DateTime beginDate,
                DateTime endDate, 
                bool free,
                decimal price, 
                bool online, 
                string companyName, 
                Guid? hostId, 
                Address address, 
                Guid categoryId)
            {
                var devent = new DEvent()
                {
                    Id = id,
                    Name = name,
                    ShortDescription = shortDesc,
                    LongDescription = longDesc,
                    BeginDate = beginDate,
                    EndDate = endDate,
                    Free = free,
                    Price = price,
                    Online = online,
                    CompanyName = companyName,
                    Address = address,
                    CategoryId = categoryId
				};
                if(hostId.HasValue )
                {
                    devent.HostId = hostId.Value;

                    if (online)
                        devent.Address = null;
                }
                return devent;

            }
        }
    }
}
