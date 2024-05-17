using Eventos.IO.Domain.Core.Models;
using FluentValidation;

namespace Eventos.IO.Domain.Eventos
{
    public class Endereco : Entity<Endereco>
    {

        public string  Longradouro { get; private set; }
        public string  Numero { get; private set; }
        public string  Complemento { get; private set; }
        public string  Bairro { get; private set; }
        public string  CEP { get; private set; }
        public string  Cidade { get; private set; }
        public string  Estado{ get; private set; }
        public Guid? EventoId { get; private set; }

        //EF
        public virtual Evento Evento { get; private set; }

        public Endereco(Guid id, string longradouro, string numero, string complemento, string bairro, string cep, string cidade, string estado, Guid? eventoId, Evento evento)
        {
            Id = id;
            Longradouro = longradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
            EventoId = eventoId;

        }
        //contrutor EF
        protected Endereco() { }
        public override bool EhValido()
        {
            #region ValidacoesEnd

            RuleFor(c => c.Longradouro)
                .NotEmpty().WithMessage("O longradouro precisa ser fornecido")
                .Length(2, 150).WithMessage("O longradouro precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("O bairro precisa ser fornecido")
                .Length(2, 150).WithMessage("O bairro precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.CEP)
                .NotEmpty().WithMessage("O cep precisa ser fornecido")
                .Length(8).WithMessage("O cep precisa ter entre 8 caracteres");

            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("O cidade precisa ser fornecido")
                .Length(2, 150).WithMessage("O cidade precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("O estado precisa ser fornecido")
                .Length(2, 150).WithMessage("O estado precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("O numero precisa ser fornecido")
                .Length(1, 10).WithMessage("O numero precisa ter entre 1 e 10 caracteres");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;

            #endregion

        }
    }
}