using System;
using System.Text.RegularExpressions;
using HumanResourcesSystem.Properties;

namespace HumanResourcesSystem.Presenters.Common
{
    public static class Validation
    {
        private static readonly string onlyLettersPattern = @"^[a-zA-Zа-яА-ЯёЁ]+$";

        private static readonly string phoneNumberPattern = @"^\+7\(\d{3}\)-\d{3}-\d{2}-\d{2}$";

        private static readonly string emailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

        private static readonly string telegramPattern = @"^@[\w]+$";

        public static bool ValidateStringValue(string value, string fieldName, bool allowOnlyLetters = false)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception(string.Format(Resources.ValidationErrorCannotBeEmpty, fieldName));

            if (allowOnlyLetters && !Regex.IsMatch(value, onlyLettersPattern))
                throw new Exception(string.Format(Resources.ValidationErrorMustContainOnlyLetters, fieldName));

            return true;
        }

        public static bool ValidateStringValueAsNullableString(string value, string fieldName, bool allowOnlyLetters = false)
        {
            if (string.IsNullOrEmpty(value))
                return true;

            if (allowOnlyLetters && !Regex.IsMatch(value, onlyLettersPattern))
                throw new Exception(string.Format(Resources.ValidationErrorMustContainOnlyLetters, fieldName));

            return true;
        }

        public static bool ValidateStringValueAsPhoneNumber(string value, string fieldName)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception(string.Format(Resources.ValidationErrorCannotBeEmpty, fieldName));

            if (!Regex.IsMatch(value, phoneNumberPattern))
                throw new Exception(string.Format(Resources.ValidationErrorInvalidPhoneNumber, fieldName));

            return true;
        }

        public static bool ValidateStringValueAsEmail(string value, string fieldName)
        {
            if (string.IsNullOrEmpty(value))
                return true;

            if (!Regex.IsMatch(value, emailPattern))
                throw new Exception(string.Format(Resources.ValidationErrorInvalidEmail, fieldName));

            return true;
        }

        public static bool ValidateStringValueAsTelegram(string value, string fieldName)
        {
            if (string.IsNullOrEmpty(value))
                return true;

            if (!Regex.IsMatch(value, telegramPattern))
                throw new Exception(string.Format(Resources.ValidationErrorInvalidTelegram, fieldName));

            return true;
        }

        public static bool ValidateStringValueAsInt(
            string value, string fieldName, 
            int min = 0, int max = Int32.MaxValue,
            int minLength = 0, int maxLength = Int32.MaxValue
        ) {
            if (string.IsNullOrEmpty(value))
                throw new Exception(string.Format(Resources.ValidationErrorCannotBeEmpty, fieldName));

            if (value.Length < minLength)
                throw new Exception(string.Format(Resources.ValidationErrorMinLength, fieldName, minLength));

            if (value.Length > maxLength)
                throw new Exception(string.Format(Resources.ValidationErrorMaxLength, fieldName, maxLength));

            if (!int.TryParse(value, out int number))
                throw new Exception(string.Format(Resources.ValidationErrorMustBeInteger, fieldName));

            if (number < min)
                throw new Exception(string.Format(Resources.ValidationErrorMinValue, fieldName, min));

            if (number > max)
                throw new Exception(string.Format(Resources.ValidationErrorMaxValue, fieldName, max));

            return true;
        }

        public static bool ValidateStringValueAsDouble(
            string value, string fieldName,
            double min = 0, double max = Int32.MaxValue,
            double minLength = 0, double maxLength = Int32.MaxValue
        ) {
            if (string.IsNullOrEmpty(value))
                throw new Exception(string.Format(Resources.ValidationErrorCannotBeEmpty, fieldName));

            if (value.Length < minLength)
                throw new Exception(string.Format(Resources.ValidationErrorMinLength, fieldName, minLength));

            if (value.Length > maxLength)
                throw new Exception(string.Format(Resources.ValidationErrorMaxLength, fieldName, maxLength));

            if (!double.TryParse(value, out double number))
                throw new Exception(string.Format(Resources.ValidationErrorMustBeDouble, fieldName));

            if (number < min)
                throw new Exception(string.Format(Resources.ValidationErrorMinValue, fieldName, min));

            if (number > max)
                throw new Exception(string.Format(Resources.ValidationErrorMaxValue, fieldName, max));

            return true;
        }

        public static bool ValidateDateTimeValue(
            DateTime value, string fieldName,
            DateTime minDate, DateTime maxDate,
            string minDateFieldName = null, string maxDateFieldName = null
        ) {
            if (value < minDate)
                throw new Exception(string.Format(Resources.ValidationErrorMinDate, fieldName, minDateFieldName));

            if (value > maxDate)
                throw new Exception(string.Format(Resources.ValidationErrorMaxDate, fieldName, maxDateFieldName));

            return true;
        }

        public static bool ValidateDateTimeValue(
            DateTime value, string fieldName
        ) {
            if (value > DateTime.Now)
                throw new Exception(string.Format(Resources.ValidationErrorMustBeValidDate, fieldName, DateTime.Now));

            return true;
        }
    }
}
