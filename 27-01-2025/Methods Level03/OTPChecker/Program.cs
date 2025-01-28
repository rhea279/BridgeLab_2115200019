using System;

class OTPGenerator
{
    // Method to generate a 6-digit OTP
    static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    // Method to check uniqueness of OTPs
    static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main()
    {
        int[] otpArray = new int[10];

        for (int i = 0; i < 10; i++)
        {
            otpArray[i] = GenerateOTP();
            Console.WriteLine($"OTP {i + 1}: {otpArray[i]}");
        }

        bool unique = AreOTPsUnique(otpArray);
        Console.WriteLine($"Are OTPs Unique? {unique}");
    }
}
