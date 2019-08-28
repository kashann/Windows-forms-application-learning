using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class EditEmployeeJob : Form
    {
        public EditEmployeeJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hours, rate,bonus;
            double grossPay, fedTax, stateTax, netPay;
            if (cb_departament.Text == "") errorProvider1.SetError(cb_departament, "Selectati un departament!");
            else
                if (tb_rate.Text == "") errorProvider1.SetError(tb_rate, "Introduceti castigul pe ora!");
                else
                    if (tb_hours.Text == "") errorProvider1.SetError(tb_hours, "Introduceti numarul de ore lucrate!");
                    else
                    {

                        bonus = Convert.ToDouble(tb_bonus.Text);
                        hours = Convert.ToDouble(tb_hours.Text);
                        rate = Convert.ToDouble(tb_rate.Text);

                        grossPay = hours * rate + Convert.ToInt32(tb_bonus.Text);
                        fedTax = grossPay * 0.15;
                        stateTax = grossPay * 0.05;
                        netPay = grossPay - (fedTax + stateTax);
                        textBox4.Text = grossPay.ToString("c");
                        textBox3.Text = fedTax.ToString("c");
                        textBox5.Text = stateTax.ToString("c");
                        textBox1.Text = netPay.ToString("c");
                    }
        }
        //cand selectez un departament sa mi apara bonusul setat in textbox
        //private void tb_bonus_TextChanged(object sender, EventArgs e)
        //{
        //    double bonus;
        //    bonus = Convert.ToDouble(tb_bonus.Text);

        //    if (cb_departament.Text == "IT") bonus.ToString("0.7");
        //    else
        //    {
        //        if (cb_departament.Text == "HR") bonus.ToString("0.2");
        //        else
        //        {
        //            if (cb_departament.Text == "Vanzari") bonus.ToString("0.1");
        //            else
        //            {
        //                if (cb_departament.Text == "Marketing") bonus.ToString("0.3");
        //                else
        //                {
        //                    if (cb_departament.Text == "Relatii clienti") bonus.ToString("0.0");


        //                }
        //            }
        //        }

        //    }
        //}

        //private void cb_departament_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    double bonus;
        //    bonus = Convert.ToDouble(lb_value.Text);
        //    if (lb_value.Text == cb_departament.Text)
        //        bonus = 0.7;

        //}

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tb_bonus.Text = hScrollBar1.Value.ToString();
        }

        private void tb_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
        
    }
}
