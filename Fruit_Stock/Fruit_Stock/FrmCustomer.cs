﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fruit_Stock.static_classes;
using System.Data;
using System.Data.OleDb;

namespace Fruit_Stock
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        bool IsFind = false;
        DataSet ds = new DataSet();
        string sSql = "";
        oCenter ocn = new oCenter();

        private void prvShowAllCustomer()
        {
            IsFind = false;
            sSql = "select * from tb_customer";
            ds = ocn.pudsLoadData(sSql, "tb_customer", ds);
            
            if (IsFind == true)
            {
                ds.Tables["tb_customer"].Clear();
            }

            if (ds.Tables["tb_customer"].Rows.Count != 0)
            {
                IsFind = true;
                dgvAllCustomer.ReadOnly = true;
                dgvAllCustomer.DataSource = ds.Tables["tb_customer"];
            }
            else
            {
                IsFind = false;
            }

            // ----------------------------------------------------------------------------------- //
        }

        // Method for format datagridview
        private void prvFormatDataGrid()
        {
            dgvAllCustomer.Update();
            dgvAllCustomer.Refresh();

            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllCustomer.ColumnHeadersDefaultCellStyle = cs;
            dgvAllCustomer.Columns[0].HeaderText = "รหัสลูกค้า";
            dgvAllCustomer.Columns[1].HeaderText = "ชื่อ";
            dgvAllCustomer.Columns[2].HeaderText = "นามสกุล";
            dgvAllCustomer.Columns[3].HeaderText = "เบอร์โทร";

            dgvAllCustomer.Columns[0].Width = 140;
            dgvAllCustomer.Columns[1].Width = 280;
            dgvAllCustomer.Columns[2].Width = 280;
            dgvAllCustomer.Columns[3].Width = 140;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            prvSearch();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            prvShowAllCustomer();
            txtSearch.Text = "";
            btnSearch.Enabled = true;
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            prvShowAllCustomer();
            prvFormatDataGrid();
            // AutoID                     Field Name        Table Name Head  Last      
            txtCusID.Text = ocn.pusAutoID("cus_id", "tb_customer", "C"+ DateTime.Now.ToString("MMyy"), "00000"); // PID001
           
        }

        private void dgvAllCustomer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dgvAllCustomer.Rows.Count)
            {
                return;
            }
            try
            {
                txtCusID.Text = dgvAllCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCusName.Text = dgvAllCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCusLastName.Text = dgvAllCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCusPhone.Text = dgvAllCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (btnSearch.Enabled == true)
                {
                    prvSearch();
                }
                else
                {
                    prvShowAllCustomer();
                    //txtSearch.Text = "";
                    btnSearch.Enabled = true;
                }
            }
        }
        private void prvSearch()
        {
            bool bCheck = false;

            if (txtSearch.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อความที่ต้องการค้นหา", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataSet dsSearchProduct = new DataSet();
            string sSqlSelect = " SELECT * FROM tb_customer WHERE cus_id+cus_name+cus_lastname+cus_phone LIKE '%" + txtSearch.Text.Trim() + "%' ORDER BY cus_id DESC;";

            if (bCheck == true)
            {
                dsSearchProduct.Tables["tb_customer"].Clear();
            }

            OleDbDataAdapter da = new OleDbDataAdapter(sSqlSelect, oCenter.conn);
            da.Fill(dsSearchProduct, "tb_customer");

            if (dsSearchProduct.Tables["tb_customer"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllCustomer.ReadOnly = true;
                dgvAllCustomer.DataSource = dsSearchProduct.Tables["tb_customer"];
            }
            else
            {
                bCheck = false;
            }
            dgvAllCustomer.Refresh();
            btnSearch.Enabled = false;
        }
        private void prvClearAll()
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            txtCusLastName.Text = "";
            txtCusPhone.Text = "";
        }

        private void prvAdd()
        {
            if (txtCusID.Text == "")
            {
                MessageBox.Show("กรุณากรอกรหัสลูกค้า", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCusID.Focus();
                return;
            }
            if (txtCusName.Text == "" || txtCusLastName.Text == "" || txtCusPhone.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            string sSqlInsert = "";
            sSqlInsert = " INSERT INTO tb_customer(cus_id,cus_name,cus_lastname,cus_phone) VALUES(@id,@name,@lastname,@phone)";
            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();
            OleDbCommand cmdInsert = new OleDbCommand();
            cmdInsert.Parameters.Clear();

            cmdInsert.Parameters.AddWithValue("@id", txtCusID.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@name", txtCusName.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@lastname", txtCusLastName.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@phone", txtCusPhone.Text.Trim().ToString());

            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = sSqlInsert;
            cmdInsert.Connection = oCenter.conn;
            cmdInsert.ExecuteNonQuery();

            prvClearAll();
            prvShowAllCustomer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            prvAdd();
        }

        private void prvDelete()
        {
            try
            {
                if (txtCusID.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกข้อมูลที่จะลบ", "ผิดพลาด");
                    return;
                }
                String sqlDelProduct = "DELETE FROM tb_customer WHERE cus_id='" + txtCusID.Text + "'";
                oCenter.pusvOpenConnection();

                OleDbCommand comDelProduct = new OleDbCommand(sqlDelProduct, oCenter.conn);

                if (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    comDelProduct.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการดำเนินการ");
                    prvClearAll();
                    prvShowAllCustomer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error btnDelete_Click" + ex.Message.ToString(), "โปรดลองอีกครั้ง",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            prvDelete();
        }

        private void prvEdit()
        {
            try
            {
                if (MessageBox.Show("คุณต้องการแก้ข้อมูลนี้ใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlEdit;

                    sqlEdit = " UPDATE tb_customer SET cus_name='" + txtCusName.Text
                        + "',cus_lastname='" + txtCusLastName.Text
                        + "',cus_phone='" + txtCusPhone.Text
                        + "'WHERE cus_id='" + txtCusID.Text + "'";

                    oCenter.pusvCloseConnection();
                    oCenter.pusvOpenConnection();
                    OleDbCommand cmdEdit = new OleDbCommand();
                    cmdEdit.CommandType = CommandType.Text;
                    cmdEdit.CommandText = sqlEdit;
                    cmdEdit.Connection = oCenter.conn;
                    cmdEdit.ExecuteNonQuery();

                    MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                    prvClearAll();
                    prvShowAllCustomer();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro EDIT:" + ex.Message, "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            prvEdit();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            prvClearAll();
            // AutoID                     Field Name        Table Name Head  Last      
            txtCusID.Text = ocn.pusAutoID("cus_id", "tb_customer", "C" + DateTime.Now.ToString("MMyy"), "00000"); // PID001
        }
    }
}
