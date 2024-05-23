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
            #region ValidacoesEnd

            RuleFor(c => c.PublicPlace)
                .NotEmpty().WithMessage("O longradouro precisa ser fornecido")
                .Length(2, 150).WithMessage("O longradouro precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.Neighborhood)
                .NotEmpty().WithMessage("O bairro precisa ser fornecido")
                .Length(2, 150).WithMessage("O bairro precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.ZipCode)
                .NotEmpty().WithMessage("O cep precisa ser fornecido")
                .Length(8).WithMessage("O cep precisa ter entre 8 caracteres");

            RuleFor(c => c.City)
                .NotEmpty().WithMessage("O cidade precisa ser fornecido")
                .Length(2, 150).WithMessage("O cidade precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.State)
                .NotEmpty().WithMessage("O estado precisa ser fornecido")
                .Length(2, 150).WithMessage("O estado precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.Number)
                .NotEmpty().WithMessage("O numero precisa ser fornecido")
                .Length(1, 10).WithMessage("O numero precisa ter entre 1 e 10 caracteres");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;

            #endregion

        }
    }
}