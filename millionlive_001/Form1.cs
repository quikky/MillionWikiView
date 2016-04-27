using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace millionlive_001
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.millionlive.com");

            this.checkBox1.Checked = true;
            this.checkBox2.Checked = true;
            this.checkBox3.Checked = true;

            dataGridView1.Font = new Font("メイリオ", 10);
            this.dataGridView1.DefaultCellStyle.Font = new Font("メイリオ", 10);
            this.dataGridView1.Rows.Add("馬場このみ", "Dance", "24");
            this.dataGridView1.Rows.Add("馬場このみ", "Visual", "24");
            this.dataGridView1.Rows.Add("馬場このみ", "Vocal", "24");

            //dataTable1.DefaultView.RowFilter = "属性 = 'Dance'";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.millionlive.com/index.php?ボーカル");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.millionlive.com/index.php?ダンス");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.millionlive.com/index.php?ビジュアル");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
    
            }
            else
            {
                //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("属性 = 'Dance'");
                //DataGridView dgv = new DataView();
                //DataView dv = new DataView();
                //dgv.RowFilter = "属性 = 'Dance'";
                //dataGridView1.DataSource = dgv;
                // (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "属性 = 'Dance'";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex].Name == "Column1")
            {
                webBrowser2.Navigate("http://www.millionlive.com/index.php?" + dataGridView1.CurrentRow.Cells[0].Value);
            }

        }

        private void webBrowser2_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string strDocumentTitle;
            strDocumentTitle = webBrowser2.DocumentTitle;
            label1.Text = (strDocumentTitle);

        }
    }
}
