﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class Log_KH : Form
    {
        public Log_KH()
        {
            InitializeComponent();
        }

        private void Log_KH_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now.Date;
            dateTimePicker1.MaxDate = DateTime.Now.Date.AddMonths(1);
        }

        private void BtDatBan_Click(object sender, EventArgs e)
        {
            String s;
            if (dateTimePicker1.Value.CompareTo(DateTime.Now.AddHours(3)) != 1)
                MessageBox.Show("Bạn phải đặt trước ít nhất 3 tiếng!");
            else
            {
                DataSet dsb = Form1.Load_Data("Ban", "MaBan, SoNguoi, TinhTrang");
                for (int i = 0; i < dsb.Tables[0].Rows.Count; i++)
                    if (dsb.Tables[0].Rows[i].ItemArray[2].ToString() == "Trống" && int.Parse(dsb.Tables[0].Rows[i].ItemArray[2].ToString()) >= int.Parse(txtSoNg.Text))
                        s = i.ToString();
                    else if (dsb.Tables[0].Rows[i].ItemArray[2].ToString() == "Được Đặt")
                    {
                        DataSet dsd = Form1.Load_Data("DatBan", "MaBan, ThoiGian");
                        for (int j = 0; j < dsd.Tables[0].Rows.Count; j++)
                            MessageBox.Show(dsb.Tables[0].Rows[i].ItemArray[1].ToString());

                    }

                Form1.Add_Data("DatBan", "");

            }
            
        }

    }
}
