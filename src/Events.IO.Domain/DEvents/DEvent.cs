using Events.IO.Domain.Core.Models;
using FluentValidation;
using Events.IO.Domain.Hosts;
<<<<<<< HEAD
using FluentValidation.Results;
=======
>>>>>>> TesteApi

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

<<<<<<< HEAD
        public DEvent() { }

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
=======
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
>>>>>>> TesteApi


        //EF
        public virtual Category Category { get; private set; }
        public virtual Address Address { get; private set; }
        public virtual Host Host { get; private set; }

<<<<<<< HEAD
=======

>>>>>>> TesteApi
        public void AssignAddress(Address address)
        {
            if (!address.IsValidate()) return;
            Address = address;
        }
        public void DeleteEvent()
        {
            Deleted = true;
        }
<<<<<<< HEAD
         
=======
        
>>>>>>> TesteApi
        public void AssignCategory(Category category)
        {
            if (!category.IsValidate()) return;
            Category = category;
        }
        public override bool IsValidate()
        {
<<<<<<< HEAD
            ValidatingTheEvent();
=======
			Authenticate();
>>>>>>> TesteApi
            return ValidationResult.IsValid;
        }
        #region Validations

<<<<<<< HEAD
        private void ValidatingTheEvent()
        {
            NameValidation();
            PriceValidation();
            CompanyNameValidation();
            DateValidation();
            LocalValidation();
            ValidationResult = Validate(this);

            ValidatingAddress();
=======
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
>>>>>>> TesteApi
        }
        private void NameValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The name must be declared")
                .Length(2, 150).WithMessage("The event name must be between 2 and 15");
        }
        private void PriceValidation()
        {
<<<<<<< HEAD
            if (!Free)
                RuleFor(c => c.Price)
                    .ExclusiveBetween(1, 50000)
                    .WithMessage("The price must be between 1.00 and 50.000");


            if (Free)
                RuleFor(c => c.Price)
                    .ExclusiveBetween(0, 0).When(e => e.Free)
                    .WithMessage("The price must be between 0 since its free");
        }


        private void DateValidation()
        {
            RuleFor(c => c.BeginDate)
                .GreaterThan(c => c.EndDate)
                .WithMessage("The begin date must be later than the end date.");

            RuleFor(c => c.BeginDate)
                .LessThan(DateTime.Now)
=======
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
>>>>>>> TesteApi
                .WithMessage("The event cannot begin before the current date");
        }
        private void LocalValidation()
        {
            if (Online)
                RuleFor(c => c.Address)
<<<<<<< HEAD
                    .Null().When(c => c.Online == true)
                    .WithMessage("The event don't need an address since it's online.");

=======
                    .Null().When(c => c.Online)
                    .WithMessage("The event don't need an address since it's online.");


>>>>>>> TesteApi
            if (!Online)
                RuleFor(c => c.Address)
                    .NotNull().When(c => c.Online == false)
                    .WithMessage("The event address must be declared.");
<<<<<<< HEAD

=======
>>>>>>> TesteApi
        }
        private void CompanyNameValidation()
        {
            RuleFor(c => c.CompanyName)
                .NotEmpty().WithMessage("The host name must be declared")
                .Length(2, 150).WithMessage("The host name must be between 2 and 150 chars.");
        }

<<<<<<< HEAD
        private void ValidatingAddress()
=======

        private void AddressValidate()
>>>>>>> TesteApi
        {
            if (Online) return;
            if (Address.IsValidate()) return;

<<<<<<< HEAD
            foreach (var error in ValidationResult.Errors)
=======
            foreach(var error in Address.ValidationResult.Errors)
>>>>>>> TesteApi
            {
                ValidationResult.Errors.Add(error);
            }
        }
<<<<<<< HEAD

=======
>>>>>>> TesteApi
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
<<<<<<< HEAD
                   Address = address,
                    CategoryId = categoryId
				};
                if(hostId.HasValue)
=======
                    Address = address,
                    CategoryId = categoryId
				};
                if(hostId.HasValue )
                {
>>>>>>> TesteApi
                    devent.HostId = hostId.Value;

                    if (online)
                        devent.Address = null;
<<<<<<< HEAD

=======
                }
>>>>>>> TesteApi
                return devent;

            }
        }
    }
}
