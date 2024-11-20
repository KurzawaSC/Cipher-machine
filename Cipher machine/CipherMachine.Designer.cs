namespace Cipher_machine
{
    partial class CypherMachine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pathLabel1 = new Label();
            toCypherTextBox = new TextBox();
            pathLabel2 = new Label();
            encryptedFileTextBox = new TextBox();
            pathLabel3 = new Label();
            decipheredFileTextBox = new TextBox();
            button1 = new Button();
            cypherMethodComboBox = new ComboBox();
            optionLabel = new Label();
            firstKeyLabel = new Label();
            firstKeyTextBox = new TextBox();
            secondKeyTextBox = new TextBox();
            secondKeyLabel = new Label();
            SuspendLayout();
            // 
            // pathLabel1
            // 
            pathLabel1.AutoSize = true;
            pathLabel1.Location = new Point(59, 31);
            pathLabel1.Name = "pathLabel1";
            pathLabel1.Size = new Size(178, 20);
            pathLabel1.TabIndex = 0;
            pathLabel1.Text = "File to be encrypted path:";
            // 
            // toCypherTextBox
            // 
            toCypherTextBox.Location = new Point(59, 54);
            toCypherTextBox.Name = "toCypherTextBox";
            toCypherTextBox.Size = new Size(195, 27);
            toCypherTextBox.TabIndex = 1;
            // 
            // pathLabel2
            // 
            pathLabel2.AutoSize = true;
            pathLabel2.Location = new Point(59, 126);
            pathLabel2.Name = "pathLabel2";
            pathLabel2.Size = new Size(137, 20);
            pathLabel2.TabIndex = 2;
            pathLabel2.Text = "Encrypted file path:";
            // 
            // encryptedFileTextBox
            // 
            encryptedFileTextBox.Location = new Point(59, 149);
            encryptedFileTextBox.Name = "encryptedFileTextBox";
            encryptedFileTextBox.Size = new Size(195, 27);
            encryptedFileTextBox.TabIndex = 3;
            // 
            // pathLabel3
            // 
            pathLabel3.AutoSize = true;
            pathLabel3.Location = new Point(59, 219);
            pathLabel3.Name = "pathLabel3";
            pathLabel3.Size = new Size(148, 20);
            pathLabel3.TabIndex = 4;
            pathLabel3.Text = "Deciphered file path:";
            // 
            // decipheredFileTextBox
            // 
            decipheredFileTextBox.Location = new Point(59, 246);
            decipheredFileTextBox.Name = "decipheredFileTextBox";
            decipheredFileTextBox.Size = new Size(195, 27);
            decipheredFileTextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(187, 319);
            button1.Name = "button1";
            button1.Size = new Size(169, 84);
            button1.TabIndex = 6;
            button1.Text = "RUN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cypherMethodComboBox
            // 
            cypherMethodComboBox.FormattingEnabled = true;
            cypherMethodComboBox.Items.AddRange(new object[] { "Caesar's cipher", "Two-key cipher", "Vernam Cipher" });
            cypherMethodComboBox.Location = new Point(327, 54);
            cypherMethodComboBox.Name = "cypherMethodComboBox";
            cypherMethodComboBox.Size = new Size(151, 28);
            cypherMethodComboBox.TabIndex = 7;
            cypherMethodComboBox.SelectedIndexChanged += this.cypherMethodComboBox_SelectedIndexChanged;
            // 
            // optionLabel
            // 
            optionLabel.AutoSize = true;
            optionLabel.Location = new Point(327, 31);
            optionLabel.Name = "optionLabel";
            optionLabel.Size = new Size(114, 20);
            optionLabel.TabIndex = 8;
            optionLabel.Text = "Cypher Method:";
            // 
            // firstKeyLabel
            // 
            firstKeyLabel.AutoSize = true;
            firstKeyLabel.Location = new Point(327, 126);
            firstKeyLabel.Name = "firstKeyLabel";
            firstKeyLabel.Size = new Size(36, 20);
            firstKeyLabel.TabIndex = 9;
            firstKeyLabel.Text = "Key:";
            // 
            // firstKeyTextBox
            // 
            firstKeyTextBox.Location = new Point(327, 149);
            firstKeyTextBox.Name = "firstKeyTextBox";
            firstKeyTextBox.Size = new Size(125, 27);
            firstKeyTextBox.TabIndex = 10;
            // 
            // secondKeyTextBox
            // 
            secondKeyTextBox.Location = new Point(327, 246);
            secondKeyTextBox.Name = "secondKeyTextBox";
            secondKeyTextBox.Size = new Size(125, 27);
            secondKeyTextBox.TabIndex = 11;
            // 
            // secondKeyLabel
            // 
            secondKeyLabel.AutoSize = true;
            secondKeyLabel.Location = new Point(327, 219);
            secondKeyLabel.Name = "secondKeyLabel";
            secondKeyLabel.Size = new Size(89, 20);
            secondKeyLabel.TabIndex = 12;
            secondKeyLabel.Text = "Second Key:";
            // 
            // CypherMachine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 450);
            Controls.Add(secondKeyLabel);
            Controls.Add(secondKeyTextBox);
            Controls.Add(firstKeyTextBox);
            Controls.Add(firstKeyLabel);
            Controls.Add(optionLabel);
            Controls.Add(cypherMethodComboBox);
            Controls.Add(button1);
            Controls.Add(decipheredFileTextBox);
            Controls.Add(pathLabel3);
            Controls.Add(encryptedFileTextBox);
            Controls.Add(pathLabel2);
            Controls.Add(toCypherTextBox);
            Controls.Add(pathLabel1);
            Name = "CypherMachine";
            Text = "Cipher Machine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pathLabel1;
        private TextBox toCypherTextBox;
        private Label pathLabel2;
        private TextBox encryptedFileTextBox;
        private Label pathLabel3;
        private TextBox decipheredFileTextBox;
        private Button button1;
        private ComboBox cypherMethodComboBox;
        private Label optionLabel;
        private Label firstKeyLabel;
        private TextBox firstKeyTextBox;
        private TextBox secondKeyTextBox;
        private Label secondKeyLabel;
    }
}
