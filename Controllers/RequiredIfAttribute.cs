using System.ComponentModel.DataAnnotations;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Controllers
{
    public enum Operator
    {
        EqualTo,
        NotEqualTo
    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class RequiredIfAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessageFormatString = "The {0} field is required.";

        private readonly string _dependentPropertyName;
        private readonly Operator _dependentPropertyComparison;
        private readonly object _dependentPropertyValue;


        public RequiredIfAttribute(string dependentPropertyName, Operator dependentPropertyComparison, object dependentPropertyValue, string? msg)
        {
            _dependentPropertyName = dependentPropertyName;
            _dependentPropertyComparison = dependentPropertyComparison;
            _dependentPropertyValue = dependentPropertyValue;

            if (msg is null)
            {
                msg = DefaultErrorMessageFormatString;
            }

            ErrorMessage = msg;
        }

        private bool ValidateDependentProperty(object actualPropertyValue)
        {
            switch (_dependentPropertyComparison)
            {
                case Operator.NotEqualTo:
                    return actualPropertyValue == null ? _dependentPropertyValue != null : !actualPropertyValue.Equals(_dependentPropertyValue);
                default:
                    return actualPropertyValue == null ? _dependentPropertyValue == null : actualPropertyValue.Equals(_dependentPropertyValue);
            }
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                var dependentProperty = validationContext.ObjectInstance.GetType().GetProperty(_dependentPropertyName);

                var dependentPropertyValue = dependentProperty.GetValue(validationContext.ObjectInstance, null);

                if (ValidateDependentProperty(dependentPropertyValue))
                {
                    return new ValidationResult(string.Format(ErrorMessageString, validationContext.DisplayName));
                }
            }
            return ValidationResult.Success;
        }
    }

}