using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HylosMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hylosData.hylosdata' table. You can move, or remove it, as needed.
            this.hylosdataTableAdapter1.Fill(this.hylosData.hylosdata);
            hylosdataBindingSource1.DataSource = this.hylosData.hylosdata;

        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                tbKode.Focus();
                this.hylosData.hylosdata.AddhylosdataRow(this.hylosData.hylosdata.NewhylosdataRow());
                hylosdataBindingSource1.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hylosdataBindingSource1.ResetBindings(false);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                hylosdataBindingSource1.EndEdit();
                hylosdataTableAdapter1.Update(this.hylosData.hylosdata);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hylosdataBindingSource1.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            tbKode.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            hylosdataBindingSource1.ResetBindings(false);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Ingin akan menghapus data ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    hylosdataBindingSource1.RemoveCurrent();
            }
        }
    }
}
