using Source.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.UserControls
{
    public partial class UC_Student : UserControl
    {
        public UC_Student(Student student)
        {
            InitializeComponent();


            lbl_no.Text = student.Number.ToString();



            if (!string.IsNullOrWhiteSpace(student.PictureUrl))
                pBox_avatar.Load(@$".\..\..\..\Resources\{student.PictureUrl}");
            else
                pBox_avatar.Load(@$".\..\..\..\Resources\avatar.png");



            lbl_fullname.Text = student.FullName;
            lbl_lastIn.Text = student.LastIn.ToShortDateString();
        }

        private void UC_Student_Load(object sender, EventArgs e)
        {
            cBox_lab.SelectedIndex = 0;
            cBox_classwork.SelectedIndex = 0;
        }
    }
}
