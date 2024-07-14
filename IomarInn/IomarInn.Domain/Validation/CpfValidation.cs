namespace IomarInn.Domain.Validation;

using System.Linq;

public static class CpfValidation
{
    public static bool IsCPFValid(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf)) return true;

        string cpfClean = new string(cpf.Where(char.IsDigit).ToArray());

        if (cpfClean.Length != 11)
        {
            return false;
        }

        int[] cpfDigits = cpfClean.Select(digit => int.Parse(digit.ToString())).ToArray();

        int[] weight1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] weight2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

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

        int firstVerifier = CalculateVerifierDigit(cpfDigits, weight1);
        if (firstVerifier != cpfDigits[9])
        {
            return false;
        }

        int secondVerifier = CalculateVerifierDigit(cpfDigits, weight2);
        if (secondVerifier != cpfDigits[10])
        {
            return false;
        }

        return true;
    }
}
