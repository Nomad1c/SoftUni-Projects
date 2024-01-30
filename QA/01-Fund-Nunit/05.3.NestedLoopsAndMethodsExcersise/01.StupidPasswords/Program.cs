using System;

class Program
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        string[] result = GeneratePasswords(N);
        Console.WriteLine(string.Join(" ", result));
    }

    static string[] GeneratePasswords(int n)
    {
        System.Collections.Generic.List<string> passwords = new System.Collections.Generic.List<string>();

        for (int i = 2; i <= n; i += 2)
        {
            for (int j = 1; j <= n; j += 2)
            {
                int k = i * j;
                passwords.Add($"{i}{j}{k}");
            }
        }

        return passwords.ToArray();
    }
}
