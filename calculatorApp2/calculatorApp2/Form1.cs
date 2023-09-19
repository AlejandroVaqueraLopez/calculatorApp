using System.Diagnostics.Metrics;

namespace calculatorApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Calculator instance = new Calculator();
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {

            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 9;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (instance.IsClean == true)
            {
                txtNumber.Text = "";
                instance.IsClean = false;
            }
            txtNumber.Text += 0;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            lblAuxNumber.Text += txtNumber.Text + " + ";
            instance.Result += float.Parse(txtNumber.Text);

            txtNumber.Text = "0.00";
            instance.IsClean = true;

            instance.Point = false;
            instance.BlankSpace = true;

            instance.LastOp = 1;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblAuxNumber.Text = "";

            switch (instance.LastOp)
            {
                case 1:
                    instance.Result += float.Parse(txtNumber.Text);
                    break;
                case 2:
                    instance.Result -= float.Parse(txtNumber.Text);
                    break;
                case 3:
                    instance.Result *= float.Parse(txtNumber.Text);
                    break;
                case 4:
                    instance.Result /= float.Parse(txtNumber.Text);
                    break;
                case 0:

                    break;

            }
            txtNumber.Text = instance.Result.ToString();
            instance.Point = false;
            instance.IsClean = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lblAuxNumber.Text = "";

            txtNumber.Text = "0.00";
            instance.Result = 0;
            instance.IsClean = true;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSustraction_Click(object sender, EventArgs e)
        {
            lblAuxNumber.Text += txtNumber.Text + " - ";
            instance.Result = float.Parse(txtNumber.Text);
            txtNumber.Text = "0.00";
            instance.IsClean = true;

            instance.Point = false;
            instance.BlankSpace = true;

            instance.LastOp = 2;
            instance.Sustraction = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblAuxNumber.Text += txtNumber.Text + " x ";
            instance.Result = float.Parse(txtNumber.Text);
            txtNumber.Text = "0.00";
            instance.IsClean = true;

            instance.Point = false;
            instance.BlankSpace = true;

            instance.LastOp = 3;
            instance.Plus = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblAuxNumber.Text += txtNumber.Text + " / ";
            instance.Result = float.Parse(txtNumber.Text);
            txtNumber.Text = "0.00";
            instance.IsClean = true;

            instance.Point = false;
            instance.BlankSpace = true;

            instance.LastOp = 4;
            instance.Plus = true;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (instance.Point == false)
            {
                txtNumber.Text += ".";
                instance.Point = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text != "0.00")
            {
                if (txtNumber.Text.Length > 0)
                {
                    txtNumber.Text = txtNumber.Text.Remove(txtNumber.Text.Length - 1, 1);
                }
                else
                {
                    
                    //instance.BlankSpace = true;
                }
            }
        }
    }
}