using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Exercise6.Interfaces;

namespace Exercise6.Services
{
    public class ExpressionValidator : IValidator
    {
        private static readonly Regex ValidCharacters = new Regex(@"^[0-9+\-*/().\s]+$");

        public bool IsValid(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression)) return false;
            if (!ValidCharacters.IsMatch(expression)) return false;

            int balance = 0;
            foreach (char c in expression)
            {
                if (c == '(') balance++;
                else if (c == ')') balance--;
                if (balance < 0) return false;
            }
            return balance == 0;
        }
    }
}
