namespace IomarInn.Domain.Validation;

using System.Linq;

public static class CnpjValidation
{
    public static bool IsCNPJValid(string cnpj)
    {
        if (string.IsNullOrWhiteSpace(cnpj)) return false;

        string cnpjClean = new string(cnpj.Where(char.IsDigit).ToArray());

        if (cnpjClean.Length != 14)
        {
            return false;
        }

        int[] cnpjDigits = cnpjClean.Select(digit => int.Parse(digit.ToString())).ToArray();

        int[] weight1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] weight2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        int CalculateVerifierDigit(int[] digits, int[] weights)
        {
            int sum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                sum += digits[i] * weights[i];
            }
            int remainder = sum % 11;
            return remainder < 2 ? 0 : 11 - remainder;
        }

        int firstVerifier = CalculateVerifierDigit(cnpjDigits, weight1);
        if (firstVerifier != cnpjDigits[12])
        {
            return false;
        }

        int secondVerifier = CalculateVerifierDigit(cnpjDigits, weight2);
        if (secondVerifier != cnpjDigits[13])
        {
            return false;
        }

        return true;
    }
}
