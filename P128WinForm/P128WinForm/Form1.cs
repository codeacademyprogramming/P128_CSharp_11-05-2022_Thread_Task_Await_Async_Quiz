using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P128WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_1_Click(object sender, EventArgs e)
        {
            ulong result = await Loop1();

            lbl_1.Text = result.ToString();
        }

        private async Task<ulong> Loop1()
        {
            ulong result = 0;

            Task task = Task.Run(() =>
            {
                for (ulong i = 0; i < 9999999999; i++)
                {
                    result += i;
                }
            });

            await task;

            return result;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("P128 Code Academy");
        }
    }
}
