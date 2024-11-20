using System.Text;

namespace Cipher_machine;

public static class Usibilities
{
    public static byte[] readText(string filePath, bool code)
    {
        string? line;
        StringBuilder sb = new StringBuilder();
        StreamReader sr = new StreamReader(filePath);
        line = sr.ReadLine();

        while (line != null)
        {
            sb.Append(line);
            line = sr.ReadLine();
        }
        sr.Close();

        if (code)
        {
            sb.Replace(" ", "$");
        }

        return Encoding.ASCII.GetBytes(sb.ToString());
    }

    public static string CaesarCipher(byte[] text, byte bKey, bool cipher, bool lastDecipher)
    {
        var byteTextAfterCipher = new List<byte>();

        int key = bKey % 95;

        foreach (byte b in text)
        {
            int result = cipher ? (b + key) : (b - key);

            if (result < 32)
            {
                result = 126 - (32 - result - 1);
            }
            if (result > 126)
            {
                result = 32 + (result - 126 - 1);
            }

            byteTextAfterCipher.Add((byte)result);
        }

        var resultText = new StringBuilder();
        resultText.Append(Encoding.ASCII.GetString(byteTextAfterCipher.ToArray()));

        if (lastDecipher)
        {
            resultText.Replace("$", " ");
        }

        return resultText.ToString();
    }

    public static void writeText(string text, string path)
    {
        var sw = new StreamWriter(path);

        sw.Write(text);

        sw.Close();
    }

    public static string VernamCipher(byte[] text, byte[] key, bool cipher)
    {
        var byteTextAfterCipher = new List<byte>();

        int result, code;

        for (int i = 0; i < text.Length; i++)
        {
            code = key[i] % 95;
            result = cipher ? (text[i] + code) : (text[i] - code);

            if (result < 32)
            {
                result = 126 - (32 - result - 1);
            }
            if (result > 126)
            {
                result = 32 + (result - 126 - 1);
            }

            byteTextAfterCipher.Add((byte)result);
        }

        var resultString = new StringBuilder();
        resultString.Append(Encoding.ASCII.GetString(byteTextAfterCipher.ToArray()));

        if (!cipher)
        {
            resultString.Replace("$", " ");
        }

        return resultString.ToString();
    }
}
