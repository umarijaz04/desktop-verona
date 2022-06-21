using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Verona
{
    public partial class Fake : Form
    {
        Form opener;
        Decimal invoice_no, amt;
        UF.Class1 test = new UF.Class1();

        public Fake(Form form)
        {
            InitializeComponent();
            opener = form;
        }

        private void Fake_Load(object sender, EventArgs e)
        {
            opener.Enabled = false;
        }

        private void Fake_FormClosing(object sender, FormClosingEventArgs e)
        {
            opener.Enabled = true;
        }

        private void txtinvoiceno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtinvoiceno.Text != "")
                {
                    amt = 0;
                    string command = "select s.fk_id Invoice_No,s.datetime DateTime,case when c.type='FIXED' then 'Customer' else 'Stakeholder' end as AC_Type,c.c_name AC_Name,(s.total-s.discount) Amount From fake_stock s,Customer c Where s.c_id=c.c_id AND s.fk_id='" + Convert.ToDecimal(txtinvoiceno.Text) + "' UNION ALL select s.fk_id Invoice_No,s.datetime DateTime,'Manufacturer' AC_Type,m.name AC_Name,(s.total-s.discount) Amount From fake_stock s,manufacturer m Where s.m_id=m.m_id AND s.fk_id='" + Convert.ToDecimal(txtinvoiceno.Text) + "'";
                    test.bindingcode(command, dataGridView, Login.con);
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        amt += Convert.ToDecimal(dataGridView.Rows[i].Cells[4].Value);
                    }
                    lbsales.Text = amt.ToString();
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            amt = 0;
            txtinvoiceno.Clear();
            string command = "select s.fk_id Invoice_No,s.datetime DateTime, case when c.type='FIXED' then 'Customer' else 'Stakeholder' end as AC_Type,c.c_name AC_Name,(s.total-s.discount) Amount From fake_stock s,Customer c Where s.c_id=c.c_id AND (s.datetime Between '" + Convert.ToDateTime(dateTimePicker1.Text) + "' AND '" + Convert.ToDateTime(dateTimePicker2.Text).AddDays(1) + "') UNION ALL select s.fk_id Invoice_No,s.datetime DateTime,'Manufacturer' AC_Type ,m.name AC_Name,(s.total-s.discount) Amount From fake_stock s,manufacturer m Where s.m_id=m.m_id AND (s.datetime Between '" + Convert.ToDateTime(dateTimePicker1.Text) + "' AND '" + Convert.ToDateTime(dateTimePicker2.Text).AddDays(1) + "')";
            test.bindingcode(command, dataGridView, Login.con);
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                amt += Convert.ToDecimal(dataGridView.Rows[i].Cells[4].Value);
            }
            lbsales.Text = amt.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                invoice_no = Convert.ToDecimal(row.Cells["Invoice_No"].Value.ToString());
                btndetail.Enabled = true;
            }
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            Fake_Detail f = new Fake_Detail(invoice_no);
            f.Show();
        }

        private void txtinvoiceno_KeyPress(object sender, KeyPressEventArgs e)
        {
            test.digit_correction(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int i = 0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image imgPerson = Image.FromFile(@"D:\VR.png");
            e.Graphics.DrawImage(imgPerson, 100, 60);
            e.Graphics.DrawString("Verona Tiles & Sanitary", new Font("Arial", 28, FontStyle.Bold), Brushes.Black, 230, 50);
            e.Graphics.DrawString("IMPORTERS & GENERAL ORDER SUPPLIER", new Font("Arial", 10), Brushes.Black, 280, 90);
            e.Graphics.DrawString("Deals in All Kinds of Imported Sanitary Items", new Font("Arial", 9, FontStyle.Italic), Brushes.Black, 300, 105);
            e.Graphics.DrawString("Kangni Wala ByPass Near PSO Pump G.T Road Gujranwala", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 265, 125);
            e.Graphics.DrawString("Contact: ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 265, 140);
            e.Graphics.DrawString("(055) 4296080 - 4296090", new Font("Arial", 9, FontStyle.Italic), Brushes.Black, 325, 140);
            int startX = 50;
            int startY = 150;
            int Offset = 40;
            e.Graphics.DrawString("Estimated Sales Report", new Font("Calibri", 12, FontStyle.Underline), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 30;
            e.Graphics.DrawString("A/c Type:", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            e.Graphics.DrawString(Convert.ToString(dataGridView.Rows[0].Cells[2].Value), new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 60, startY + Offset);
            Offset = Offset + 20;
            e.Graphics.DrawString("A/c Name:", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            e.Graphics.DrawString(Convert.ToString(dataGridView.Rows[0].Cells[3].Value), new Font("Calibri", 10), new SolidBrush(Color.Black), startX + 65, startY + Offset);
            Offset = Offset + 20;
            e.Graphics.DrawString("From:", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            e.Graphics.DrawString(dateTimePicker1.Text, new Font("Calibri", 10), new SolidBrush(Color.Black), startX + 40, startY + Offset);
            e.Graphics.DrawString("To:", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 380, startY + Offset);
            e.Graphics.DrawString(dateTimePicker2.Text, new Font("Calibri", 10), new SolidBrush(Color.Black), startX + 405, startY + Offset);
            Offset = Offset + 20;
            string underLine = "--------------------------------------------------------------------------------";
            e.Graphics.DrawString(underLine, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            e.Graphics.DrawString("S_ID", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            e.Graphics.DrawString("Date & Time", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 120, startY + Offset);
            e.Graphics.DrawString("Amount", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 560, startY + Offset);
            Offset = Offset + 20;
            e.Graphics.DrawString(underLine, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            int a = dataGridView.Rows.Count;
            for (; i < a; i++)
            {
                e.Graphics.DrawString(Convert.ToString(dataGridView.Rows[i].Cells[0].Value), new Font("Calibri", 9), new SolidBrush(Color.Black), startX, startY + Offset);
                e.Graphics.DrawString(Convert.ToString(dataGridView.Rows[i].Cells[1].Value), new Font("Calibri", 9), new SolidBrush(Color.Black), startX + 120, startY + Offset);
                e.Graphics.DrawString(Convert.ToString(dataGridView.Rows[i].Cells[4].Value), new Font("Calibri", 9), new SolidBrush(Color.Black), startX + 560, startY + Offset);
                Offset = Offset + 20;
                if (Offset >= e.MarginBounds.Height)
                {
                    i++;
                    e.HasMorePages = true;
                    Offset = 0;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            e.Graphics.DrawString(underLine, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            e.Graphics.DrawString(amt.ToString(), new Font("Calibri", 10), new SolidBrush(Color.Black), startX + 560, startY + Offset);
            Offset = Offset + 20;
            e.Graphics.DrawString(underLine, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            e.Graphics.DrawString("Signature:  __________________", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            e.Graphics.DrawString("Date & Time:  ", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 320, startY + Offset);
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Calibri", 10), new SolidBrush(Color.Black), startX + 400, startY + Offset);
            Offset = Offset + 25;
            e.Graphics.DrawString("Developed By: Geeks IT Solutions 03126424443  ", new Font("Calibri", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX + 280, startY + Offset + 5);
            e.Graphics.PageUnit = GraphicsUnit.Inch;
        }
    }
}

