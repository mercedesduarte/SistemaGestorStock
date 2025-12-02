using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Logica
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Validates an email address using MailAddress and a simple regex for extra safety.
        /// Returns false for null/empty values.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var _ = new MailAddress(email);
            }
            catch
            {
                return false;
            }

            // basic additional check (prevents spaces and enforces simple pattern)
            return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        /// <summary>
        /// Valid phone: allows digits, spaces, +, -, parentheses. Requires at least minDigits numeric characters.
        /// </summary>
        public static bool IsValidPhone(string phone, int minDigits = 6)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // remove non-digits
            var digits = Regex.Replace(phone, @"\D", "");
            if (digits.Length < minDigits)
                return false;

            // only allowed characters overall
            return Regex.IsMatch(phone, @"^[0-9()\+\-\s]*$");
        }

        /// <summary>
        /// Valida DNI: exactamente 8 dígitos y sin letras.
        /// </summary>
        public static bool IsValidDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return false;

            return Regex.IsMatch(dni.Trim(), @"^\d{8}$");
        }

        /// <summary>
        /// Valida nombre: no permite números. Acepta letras (incluye acentos), espacios, guiones y apóstrofes.
        /// </summary>
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            return Regex.IsMatch(name.Trim(), @"^[A-Za-zÁÉÍÓÚÜÑáéíóúüñ\s\-']+$");
        }

        /// <summary>
        /// Valida que el texto contenga solo dígitos (útil para horario si pedís solo números).
        /// </summary>
        public static bool IsDigitsOnly(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            return Regex.IsMatch(text.Trim(), @"^\d+$");
        }

        public static bool IsAlphanumeric(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;
            return Regex.IsMatch(text, @"^[a-zA-Z0-9\s]+$");
        }

        public static bool HasMaxLength(string text, int max)
        {
            if (text == null) return true;
            return text.Length <= max;
        }
    }
}
