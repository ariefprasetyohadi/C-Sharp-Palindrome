class Program
{
    // Fungsi sederhana untuk mengecek palindrome
    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        // Loop untuk membandingkan huruf dari kiri & kanan
        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false; // langsung bukan palindrome
            }

            left++;
            right--;
        }

        return true; // jika tidak ada yang beda, maka palindrome
    }

    static void Main()
    {
        // Test case yang akan diuji
        string[] testWords = { "katak", "level", "civic", "makan", "radar", "mobil" };

        Console.WriteLine("Palindrome Checker Test");
        Console.WriteLine("-----------------------");

        // Loop untuk menguji semua test case
        foreach (var word in testWords)
        {
            bool result = IsPalindrome(word);

            if (result)
                Console.WriteLine($"{word} → Palindrome");
            else
                Console.WriteLine($"{word} → Not Palindrome");
        }
    }
}
