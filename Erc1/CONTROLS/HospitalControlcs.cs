﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erc1.CONTROLS
{
    public enum HosStatus
    {
        Available,
        Busy,
        AvailBusy,
        None

    }
    public partial class HospitalControlcs : UserControl
    {
        public event EventHandler HosStatusChanged, HosIDChanged;


        private int hosID;
        public int HosID
        {
            get 
            {
                return hosID; 
            }
            set 
            {
                hosID = value;
                HosIDChanged += HospitalControlcs_HosIDChanged;
                HosIDChanged.Invoke(this, EventArgs.Empty);

            }
        }
        private void HospitalControlcs_HosIDChanged(object sender, EventArgs e)
        {
            label1.Text = "H" + HosID;
        }
        public HospitalControlcs()
        {
            InitializeComponent();

        }
        private HosStatus hosstatus = HosStatus.Available;
        public HosStatus Hosstatus
        {
            get 
            {
                return hosstatus; 
            }
            set 
            {
                hosstatus = value;
                HosStatusChanged += HospitalControlcs_HosStatusChanged;
                HosStatusChanged.Invoke(this, EventArgs.Empty);
                 
            }
        }
        public void HospitalControlcs_HosStatusChanged(object sender, EventArgs e)
        {
            //GetHos(int ID) we should get id/name/number/available or not/Notes/Departements/ext/
            //add info into this user control and into this HopitalsInfo Form
            
            switch (Hosstatus)
            {
                case HosStatus.Available:
                    {
                        
                        textBox1.Text = "";
                        textBox1.ReadOnly = true;
                        textBox1.BackColor = Color.FromArgb(109, 184, 127);
                        HospitalName.Enabled = true;
                        break;
                    }
                case HosStatus.Busy:
                    {
                        textBox1.Text = "";
                        textBox1.ReadOnly = true;
                        textBox1.BackColor = Color.FromArgb(222, 54, 67);
                        HospitalName.Enabled = true;
                        break;
                    }
                case HosStatus.AvailBusy:
                    {
                        textBox1.ReadOnly = false;
                        textBox1.BackColor = Color.FromArgb(241, 149, 98);
                        HospitalName.Enabled = true;
                        break;
                    }
                case HosStatus.None:
                    {
                        label1.Text = "H";
                        textBox1.Text = "";
                        textBox1.BackColor = Color.White;
                        HospitalName.Text = "";
                        HospitalName.Enabled = false;

                        break;
                    }
                default:
                    {
                        break;
                    }
            }


            HosStatusChanged -= HospitalControlcs_HosStatusChanged;
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {

                switch (Hosstatus)
                {
                    case HosStatus.Available:
                        {
                            Hosstatus = HosStatus.Busy;
                            break;
                        }
                    case HosStatus.Busy:
                        {
                            Hosstatus = HosStatus.AvailBusy;
                            break;
                        }
                    case HosStatus.AvailBusy:
                        {
                            Hosstatus = HosStatus.Available;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            }
        }
        private void HospitalName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hospital Form");
        }
    }
}
