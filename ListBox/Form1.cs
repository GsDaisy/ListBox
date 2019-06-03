using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {

        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckText();
        }

        private void CheckText()
        {
            if (this.txtList.Text != "")
                this.lbView.Items.Add(this.txtList.Text);

            else
                MessageBox.Show("항목을 입력", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            this.txtList.Focus();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CheckText();
                e.Handled = true;
            }
        }

        private void LbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.lbView.Text;
        }
    }
}
