using Source.Repository;
using Source.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var students = FakeRepo.GetStudents();


            for (int i = students.Count - 1; i >= 0; i--)
            {
                UC_Student uc = new(students[i]);
                uc.Dock = DockStyle.Top;
                pnl_content.Controls.Add(uc);
            }

        }
    }
}
