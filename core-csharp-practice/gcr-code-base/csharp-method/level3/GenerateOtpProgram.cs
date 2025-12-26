using System;

class GenerateOtpProgram
{
    // a. Method to generate 6-digit OTP
    public static int GenerateOTP()
    {
        Random rand = new Random();
        int otp = (int)(rand.NextDouble() * 900000) + 100000;
        return otp;
    }

    // c. Method to check uniqueness of OTPs
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }
        return true;
    }

    // MAIN METHOD
    static void Main()
    {
        int[] otps = new int[10];

        // b. Generate OTPs 10 times
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
        }

        Console.WriteLine("Generated OTPs:");
        for (int i = 0; i < otps.Length; i++)
        {
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }

        // Validate uniqueness
        bool isUnique = AreOTPsUnique(otps);
        Console.WriteLine("Are all OTPs unique: " + isUnique);
    }
}
