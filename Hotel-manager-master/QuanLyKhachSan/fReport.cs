﻿using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void fReport_Activated(object sender, EventArgs e)
        {
           
        }

        private void btViewReport_Click(object sender, EventArgs e)
        {
            int _month = dtp.Value.Month, _year = dtp.Value.Year;

            dtgvReport.DataSource = ReportDAO.Instance.LoadReport(_year,_month);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
