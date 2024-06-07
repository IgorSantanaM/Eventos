using Events.IO.Domain.Core.Models;
using FluentValidation;

namespace Events.IO.Domain.DEvents
{
    public class Address : Entity<Address>
    {

        public string  PublicPlace { get; private set; }
        public string  Number { get; private set; }
        public string  Complement { get; private set; }
        public string Neighborhood { get; private set; }
        public string  ZipCode { get; private set; }
        public string  City { get; private set; }
        public string  State{ get; private set; }
        public Guid? EventId { get; private set; }

        //EF
        public virtual DEvent DEvent { get; private set; }

        public Address(Guid id, string publicPlace, string number, string complement, string neighborhood, string zipCode, string city, string state, Guid? eventId)
        {
            Id = id;
            PublicPlace = publicPlace;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            City = city;
            State = state;
            EventId = eventId;

        }
        //contrutor EF
        protected Address() { }
        public override bool IsValidate()
        {
                #region ValidationsAddress

                RuleFor(c => c.PublicPlace)
                .NotEmpty().WithMessage("The street name must be provided")
                .Length(2, 150).WithMessage("The street name must be between 2 and 150 characters");

            RuleFor(c => c.Neighborhood)
                .NotEmpty().WithMessage("The neighborhood must be provided")
                .Length(2, 150).WithMessage("The neighborhood must be between 2 and 150 characters");

            RuleFor(c => c.ZipCode)
                .NotEmpty().WithMessage("The ZIP code must be provided")
                .Length(8).WithMessage("The ZIP code must be 8 characters long");

            RuleFor(c => c.City)
                .NotEmpty().WithMessage("The city must be provided")
                .Length(2, 150).WithMessage("The city must be between 2 and 150 characters");

            RuleFor(c => c.State)
                .NotEmpty().WithMessage("The state must be provided")
                .Length(2, 150).WithMessage("The state must be between 2 and 150 characters");

            RuleFor(c => c.Number)
                .NotEmpty().WithMessage("The number must be provided")
                .Length(1, 10).WithMessage("The number must be between 1 and 10 characters");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;

            #endregion


        }
    }
}