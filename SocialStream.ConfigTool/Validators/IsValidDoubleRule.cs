﻿using System.Globalization;
using System.Windows.Controls;

namespace SocialStream.ConfigTool.Validators
{
    /// <summary>
    /// A validation rule for a double.
    /// </summary>
    public class IsValidDoubleRule : ValidationRule
    {
        /// <summary>
        /// When overridden in a derived class, performs validation checks on a value.
        /// </summary>
        /// <param name="value">The value from the binding target to check.</param>
        /// <param name="cultureInfo">The culture to use in this rule.</param>
        /// <returns>
        /// A <see cref="T:System.Windows.Controls.ValidationResult"/> object.
        /// </returns>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string val = value as string;

            if (val == null || string.IsNullOrWhiteSpace(val))
            {
                return new ValidationResult(false, SocialStream.ConfigTool.Properties.Resources.NumberError);
            }

            double parsed;
            if (double.TryParse(val, NumberStyles.Float, CultureInfo.InvariantCulture, out parsed))
            {
                return ValidationResult.ValidResult;
            }
            else
            {
                return new ValidationResult(false, SocialStream.ConfigTool.Properties.Resources.NumberError);
            }
        }
    }
}
