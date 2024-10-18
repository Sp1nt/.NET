using System;
using System.Text.RegularExpressions;

namespace Lab1._1
{
    internal class Math
    {
        public string Expression { get; private set; }

        public Math(string expression)
        {
            try
            {
                SetExpression(expression);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void SetExpression(string expression)
        {
            foreach (char c in expression)
            {
                if (!char.IsDigit(c) && c != '*')
                {
                    throw new Exception("Ошибка: выражение должно содержать только целые числа и оператор '*'.");
                }
            }

            Expression = expression;
        }

        public int Evaluate()
        {
            string[] numbers = Expression.Split('*');
            int result = 1;

            foreach (var num in numbers)
            {
                result *= int.Parse(num);
            }

            return result;
        }
    }
}
