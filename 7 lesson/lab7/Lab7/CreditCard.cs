using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    internal class CreditCard
    {
        public string CardNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public string CVC { get; private set; }
        public DateTime ExpirationDate { get; private set; }

        public CreditCard(string cardNumber, string cardHolderName, string cvc, DateTime expirationDate)
        {
            try
            {
                SetCardNumber(cardNumber);
                SetCardHolderName(cardHolderName);
                SetCVC(cvc);
                SetExpirationDate(expirationDate);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка инициализации карты: " + ex.Message);
            }
        }

        private void SetCardNumber(string cardNumber)
        {
            if (cardNumber.Length != 16 || !Regex.IsMatch(cardNumber, @"^\d{16}$"))
            {
                throw new Exception("Номер карты должен содержать 16 цифр.");
            }
            CardNumber = cardNumber;
        }

        private void SetCardHolderName(string cardHolderName)
        {
            if (string.IsNullOrEmpty(cardHolderName))
            {
                throw new Exception("ФИО владельца не должно быть пустым.");
            }

            if (!Regex.IsMatch(cardHolderName, @"^[a-zA-Zа-яА-Я\s]+$"))
            {
                throw new Exception("ФИО владельца должно содержать только буквы и пробелы, без цифр и символов.");
            }

            CardHolderName = cardHolderName;
        }

        private void SetCVC(string cvc)
        {
            if (cvc.Length != 3 || !Regex.IsMatch(cvc, @"^\d{3}$"))
            {
                throw new Exception("CVC должен содержать 3 цифры.");
            }
            CVC = cvc;
        }

        private void SetExpirationDate(DateTime expirationDate)
        {
            if (expirationDate <= DateTime.Now || expirationDate.Year > 2029)
            {
                throw new Exception("Срок действия карты должен быть позже текущей даты.");
            }
            ExpirationDate = expirationDate;
        }
    }
}
