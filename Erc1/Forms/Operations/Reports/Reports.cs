﻿using Erc1.BAL;
using Erc1.Forms.Admin.Volunteers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erc1.Forms.Operations.Reports
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            try
            {
                centers.Items.Add("all");
                MyFunction.FillComboBox(centers, BAL.addMission.Get_centers(), "id", "centers");
                MyFunction.FillComboBox(volunteers,BAL.Employees.Get_Employees() , "الاسم", "الرمز");
                MyFunction.FillComboBox(CaseType, BAL.addMission.Get_CasesType(), "النوعية", "الرمز");
                MyFunction.FillComboBox(Patient, BAL.PatientInfo.GetPatients(), "اسم", "الرمز");
                centers.SelectedValueChanged += Centers_SelectedValueChanged;



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Centers_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                MyFunction.FillComboBox(Cars, BAL.addMission.GetCars(int.Parse(centers.SelectedValue.ToString())), "cars", "cars");


            }
            catch
            {
                Cars.DataSource = null;
            }
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            int? y = int.Parse(year.Text)
                , m = int.Parse(Months.Text)
                , c = (int?)centers.SelectedValue
                , ca = (int?)CaseType.SelectedValue
                , v = (int?)volunteers.SelectedValue
                , car = (int?)Cars.SelectedValue
                ,p= (int?)Patient.SelectedValue;
            dataGridView1.DataSource = Classes.mission.Get_Missions(y,m ,c ,ca ,v ,car ,p );
        }
    }
}
