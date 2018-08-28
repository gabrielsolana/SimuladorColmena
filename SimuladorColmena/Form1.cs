using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorColmena
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Queen queen;
        private Worker[] workers;

        public Form()
        {
            InitializeComponent();

            workers = new Worker[4];
            CreateWorkers();

            queen = new Queen(workers, 275);

            workSelectorComboBox.SelectedIndex = 0;
        }

        private void Form_Load(object sender, EventArgs e) { }

        private void assignJobToABeeButton_Click(object sender, EventArgs e)
        {
            
            if (queen.AssignWork(workSelectorComboBox.Text, (int)shiftsNumericUpDown.Value))
                MessageBox.Show($"The job '{workSelectorComboBox.Text}' will be done in {(int)shiftsNumericUpDown.Value} Shifts", "The Bee Queen says...");
            else
                MessageBox.Show($"There is no available bees to do the job" , "The Bee Queen says...");
        }

        private void nextShiftButton_Click(object sender, EventArgs e)
        {
            reportTextBox.Text += queen.WorkTheNextShift();
        }

        private void CreateWorkers()
        {
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Baby bee tutoring", "Egg care", "Hive maintenance", "Honey manufacturing", "Nectar collector", "Sting patrol" }, 155);
        }

        private void clearReportWindowButton_Click(object sender, EventArgs e)
        {
            reportTextBox.ResetText();
        }
    }
}
