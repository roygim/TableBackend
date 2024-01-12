using System.ComponentModel.DataAnnotations;

namespace TableBackend.DataAnnotations
{
    public class EmailAddressOrEmpty: ValidationAttribute
    {
        public const string DefaultErrorMessage = "אימייל לא תקין";
        private EmailAddressAttribute _validator = new EmailAddressAttribute();

        public EmailAddressOrEmpty() : base(DefaultErrorMessage)
        {
        }

        public override bool IsValid(object value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
                return true;

            return _validator.IsValid(value.ToString());
        }
    }
}
