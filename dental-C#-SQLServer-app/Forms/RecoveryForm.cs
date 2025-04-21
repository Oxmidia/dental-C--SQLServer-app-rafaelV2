using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace dental_C__SQLServer_app.Forms
{
    public partial class RecoveryForm : Form
    {
        private readonly string _username;

        public RecoveryForm(string username)
        {
            InitializeComponent();
            _username = username;
            GenerateAndSendCode();
        }

        private void GenerateAndSendCode()
        {
            var (code, expiration) = RecoveryService.GenerateRecoveryCode();
            RecoveryService.SaveRecoveryCode(_username, code, expiration);
            MessageBox.Show($"Código enviado. Válido hasta: {expiration:HH:mm}");
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (RecoveryService.VerifyAndConsumeCode(_username, txtCode.Text))
            {
                new NewPasswordForm(_username).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Código inválido o expirado");
            }
        }
    }
}
