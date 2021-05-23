using Alten.LastHotel.Aplication.Customer;
using FluentValidation;


namespace Alten.LastHotel.Aplication.Validations
{
    public class CustomerValidations : AbstractValidator<CreateCustomerCommand>
    {
        public CustomerValidations()
        {
            RuleFor(createCustomerCommand => createCustomerCommand.LastName).NotEmpty();
            RuleFor(createCustomerCommand => createCustomerCommand.Name).NotEmpty();
            RuleFor(createCustomerCommand => createCustomerCommand.BirthDate).Must(c => c.Equals(System.DateTime.Today)).WithMessage("Date is incorrect");
        }
    }
}
