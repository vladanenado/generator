using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCheckStrength.Enabled = false;
            btnClear.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)nudPasswordLength.Value;
            bool includeSpecialChars = chkSpecialChars.Checked;

            string password = GeneratePassword(length, includeSpecialChars);
            txtPassword.Text = password;
            btnCheckStrength.Enabled = true;
        }

        private void BtnCheckStrength_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string strength = CheckPasswordStrength(password);
            lblPasswordStrength.Text = "Сила пароля: " + strength;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPasswordField(); // Вызов метода для очистки текстового поля
        }

        private void ClearPasswordField()
        {
            txtPassword.Clear(); // Очищаем текстовое поле для пароля
            lblPasswordStrength.Text = "Сила пароля:"; // Очищаем текст метки силы пароля
            btnCheckStrength.Enabled = false; // Делаем кнопку проверки силы пароля недоступной
            btnClear.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле, и в зависимости от этого включаем или отключаем кнопку очистки
            btnClear.Enabled = !string.IsNullOrWhiteSpace(txtPassword.Text);
        }
        private string GeneratePassword(int length, bool includeSpecialChars)
        { 
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            const string specialChars = "!@#$%^&*()_-+=<>?";
            string charSet = chars;

            if (includeSpecialChars)
            {
                charSet += specialChars;
            }

            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[length];
                rng.GetBytes(data);

                var result = new StringBuilder(length);
                foreach (byte b in data)
                {
                    result.Append(charSet[b % charSet.Length]);
                }

                return result.ToString();
            }
        }

        private string CheckPasswordStrength(string password)
        {
            if (password.Length < 6)
            {
                return "Слабый";
            }
                

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigits = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                if (char.IsLower(c)) hasLowerCase = true;
                if (char.IsDigit(c)) hasDigits = true;
                if (@"!@#$%^&*()_-+=<>?".Contains(c)) hasSpecialChar = true;
            }

            int criteriaMet = Convert.ToInt32(hasUpperCase) + Convert.ToInt32(hasLowerCase) +
                              Convert.ToInt32(hasDigits) + Convert.ToInt32(hasSpecialChar);

            if (criteriaMet >= 3)
            {
                return "Сильный";
            }
            else
            
                {
                    return "Средний";
                }
        }
    }
}
