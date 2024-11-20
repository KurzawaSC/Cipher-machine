using System.Text;

namespace Cipher_machine;

public partial class CypherMachine : Form
{
    public CypherMachine()
    {
        InitializeComponent();
        cypherMethodComboBox.SelectedIndex = 0;
    }

    public void cypherMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cypherMethodComboBox.SelectedIndex == 0)
        {
            firstKeyLabel.Visible = true;
            firstKeyTextBox.Visible = true;
            secondKeyLabel.Visible = false;
            secondKeyTextBox.Visible = false;
        }
        else if (cypherMethodComboBox.SelectedIndex == 1)
        {
            firstKeyLabel.Visible = true;
            firstKeyTextBox.Visible = true;
            secondKeyLabel.Visible = true;
            secondKeyTextBox.Visible = true;
        }
        else if(cypherMethodComboBox.SelectedIndex == 2)
        {
            firstKeyLabel.Visible = false;
            firstKeyTextBox.Visible = false;
            secondKeyLabel.Visible = false;
            secondKeyTextBox.Visible = false;
        }
    }

    public void button1_Click(object sender, EventArgs e)
    {
        var textInBytes = Usibilities.readText(toCypherTextBox.Text, true);

        switch (cypherMethodComboBox.SelectedIndex)
        {
            case 0:
                byte key = byte.Parse(firstKeyTextBox.Text);
                var encryptedText = Usibilities.CaesarCipher(textInBytes, key, true, false);
                Usibilities.writeText(encryptedText, encryptedFileTextBox.Text);

                var encryptedTextInBytes = Usibilities.readText(encryptedFileTextBox.Text, false);
                var decipheredText = Usibilities.CaesarCipher(encryptedTextInBytes, key, false, true);
                Usibilities.writeText(decipheredText, decipheredFileTextBox.Text);

                break;

            case 1:
                byte key1 = byte.Parse(firstKeyTextBox.Text);
                byte key2 = byte.Parse(secondKeyTextBox.Text);

                var encryptedText1 = Usibilities.CaesarCipher(textInBytes, key1, true, false);
                Usibilities.writeText(encryptedText1, encryptedFileTextBox.Text.Replace(".txt", "")+"_1.txt");

                var encryptedTextInBytes1 = Usibilities.readText(encryptedFileTextBox.Text.Replace(".txt", "") + "_1.txt", false);
                var encryptedText2 = Usibilities.CaesarCipher(encryptedTextInBytes1, key2, true, false);
                Usibilities.writeText(encryptedText2, encryptedFileTextBox.Text.Replace(".txt", "") + "_2.txt");

                var encryptedTextInBytes2 = Usibilities.readText(encryptedFileTextBox.Text.Replace(".txt", "") + "_2.txt", false);
                var decipheredText2 = Usibilities.CaesarCipher(encryptedTextInBytes2, key2, false, false);
                Usibilities.writeText(decipheredText2, decipheredFileTextBox.Text.Replace(".txt", "") + "_1.txt");

                var encryptedTextInBytes3 = Usibilities.readText(decipheredFileTextBox.Text.Replace(".txt", "") + "_1.txt", false);
                var decipheredText1 = Usibilities.CaesarCipher(encryptedTextInBytes3, key1, false, true);
                Usibilities.writeText(decipheredText1, decipheredFileTextBox.Text);

                break;

            case 2:
                var code = Usibilities.readText(AppDomain.CurrentDomain.BaseDirectory + "literaryCode.txt", true);

                var encryptedTextV = Usibilities.VernamCipher(textInBytes, code, true);
                Usibilities.writeText(encryptedTextV, encryptedFileTextBox.Text);

                var encryptedTextInBytesV = Usibilities.readText(encryptedFileTextBox.Text, false);
                var decipheredTextV = Usibilities.VernamCipher(encryptedTextInBytesV, code, false);
                Usibilities.writeText(decipheredTextV, decipheredFileTextBox.Text);

                break;
        }

        var text1 = Encoding.ASCII.GetString(Usibilities.readText(toCypherTextBox.Text, false));
        var text2 = Encoding.ASCII.GetString(Usibilities.readText(decipheredFileTextBox.Text, false));
        if (text1 == text2) MessageBox.Show("Everything ran correctly");
        else MessageBox.Show("Something went wrong text after decipher is odd");
    }
}