using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int X;
        int Z;

        public Form1()
        {
            InitializeComponent();
        }

        private void addAddandPopulateButton_Click(object sender, EventArgs e)
        {
            X++;
            addAddandPopulateButton.Text = X.ToString();
            int y, z = 0;



            while (z < addCheckedListBox.Items.Count)
            {

                addListBox.Items.Add((double)addCheckedListBox.CheckedItems.IndexOf(z) * X + 29.8);
                z++;
            }
        }
        private void addNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Z++;
            if (char.IsDigit(e.KeyChar))
            {
                addCheckedListBox.Items.Add((int)e.KeyChar - X + Z);
            }

            if (char.IsLetter(e.KeyChar))
            {
                double x;
                x = 15 * X / Z + addListBox.Items.Count;
                addCheckedListBox.Items.Add(x);
            }
        }

        private void addCheckedItemOnCheckBox(object sender, ItemCheckEventArgs e)
        {
            int x = 0;
            double y = 0;
            while (x < addCheckedListBox.Items.Count)
            {
                if (addCheckedListBox.GetItemChecked(x) == true)
                {
                    y = y * 38.9278 + (double)addCheckedListBox.Items.IndexOf(x);
                    addListBox.Items.Add(y);

                }
                x++;

            }

        }

        private void addCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addClear_Click(object sender, EventArgs e)
        {
            addCheckedListBox.Items.Clear();
            addListBox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Z = 7;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            addCheckedListBox.Sorted = true;
            addListBox.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label3.Text = "azimuth: " + addCheckedListBox.Items.Count + ", " + " location" + addListBox.Items.Count;
         }
    }
}
