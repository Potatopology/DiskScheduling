using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskScheduling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAlgo.SelectedIndex = 0;

            List<int> sorted = new List<int>(new int[] { 1,2,3,4,5 });
            Algorithm.Solution(sorted);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ClearStuff();

            if (IsIncomplete())
                MessageBox.Show("Please complete input");
            else if (!IsEnteredInt())
                MessageBox.Show("Invalid Input");
            else if (Convert.ToInt32(txtSize.Text) <= Convert.ToInt32(txtStart.Text))
            {
                MessageBox.Show("Start cannot be higher than or equal to size");
            }
            else
            {
                try
                {
                    MainProcess();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                
            }
        }

        private void MainProcess()
        {
            int size = Convert.ToInt32(txtSize.Text);
            int start = Convert.ToInt32(txtStart.Text);
            String numString = txtQue.Text;
            List<int> workQue = numString.Split(',').Select(Int32.Parse).ToList();

            bool isSeq = false;
            List<int> createdList = Algorithm.CreateList(isSeq, size, start, workQue);
            List<int> sorted = new List<int>();

            switch (cmbAlgo.SelectedItem.ToString())
            {
                case "FCFS":
                    isSeq = true;
                    sorted = Algorithm.CreateList(true, size, start, workQue);
                    break;

                case "SSTF":
                    sorted = Algorithm.SortSSTF(createdList);
                    break;

                case "SCAN":
                    sorted = Algorithm.SortScan(start, createdList);
                    break;

                case "LOOK":
                    sorted = Algorithm.SortLook(start, createdList);
                    break;

                case "CSCAN":
                    sorted = Algorithm.SortCScan(start, size, createdList);
                    break;

                case "CLOOK":
                    sorted = Algorithm.SortCLook(start, createdList);
                    break;

                default:
                    MessageBox.Show("Please choose an algorithm");
                    break;
            }

            lblSol.Text = Algorithm.Differences(sorted);

            lblAbs.Text = Algorithm.Solution(sorted);

            int THM = Algorithm.CalculateTHM(sorted);
            txtTHM.Text = THM.ToString();

            foreach (int item in sorted)
            {
                chrtSched.Series["Work Que"].Points.AddY(item);
            }
        }

        private void ClearStuff()
        {
            foreach (var series in chrtSched.Series)
            {
                series.Points.Clear();
            }
            lblSol.Text = "";
        }

        private bool IsIncomplete()
        {
            return txtSize.Text == null || txtSize.Text == "" || txtStart.Text == null || txtStart.Text == "" || txtQue.Text == null || txtQue.Text == "";
        }

        private bool IsEnteredInt()
        {
            return IsInt(txtSize.Text) && IsInt(txtStart.Text);
        }

        public static void OnlyNumber(object sender, KeyPressEventArgs e, Boolean isDecimal)
        {
            //accepts decimal
            if (isDecimal)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > 0))
                {
                    e.Handled = true;
                }
            }
            //only accepts unsigned int
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        public bool IsInt(string number)
        {
            return !string.IsNullOrEmpty(number) && number.All(Char.IsDigit);
        }
    }
}
