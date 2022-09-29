using System.Text.RegularExpressions;

//Shashank M
//Student ID: 801026182
namespace CateringApplication // using namespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // init Component default
        }

        public void button1_Click(object sender, EventArgs e) // by clicking submit
        {
            int dish_count = 0, cost = 0, guest = 0; // dishcount, cost, and guest are eqld = 0
            String name, 
                phoneNumber,  // string for name, phnNumber, and chekcboxed
                checkB = "";
            if (Regex.IsMatch(textBox3.Text, @"[a-zA-Z]")) // if they enter a non-numerical
            {
                cost = 0;
                MessageBox.Show("Not a numerical value: " +
                "Enter a numerical Value");

            }
            else // else guest * 35 a person
            {
                guest = Int32.Parse(textBox3.Text);
                cost = guest * 35;
            }
            String dessert = comboBox1.Text; // comboxes for deserts
            if (checkBox1.Checked) // if box is checked and count is plus one
            {
                dish_count++;
                checkB = checkB + " Baked Pork Chops";
            }
            if (checkBox2.Checked) // if box is checked and count is plus one
            {
                dish_count++;
                checkB = checkB + " Garlic Chicken";
            }
            if (checkBox3.Checked) // if box is checked and count is plus one
            {
                dish_count++;
                checkB = checkB + " Best Lasagna";
            }
            if (checkBox4.Checked)// if box is checked and count is plus one
            {
                dish_count++;
                checkB = checkB + "Maple Salmon";
            }
            if (dish_count > 2) // if dishcount is more than 2 redo it again
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

                MessageBox.Show("::Please select only two dishes from the list::");

            }
            else // write to a textfile 
            {
                TextWriter toFile = new StreamWriter(@"C:\Users\sudha\source\repos\CateringApplication\Event.txt", true);
                toFile.Write("Name:[ " + textBox1.Text + "]\n" + " Phone Number:[ " + textBox2.Text + "]\n"
                + " Guests: " + textBox3.Text + "\n" + "Desserts:[ " + comboBox2.Text + "]\n Dishes:[ " + checkB + "] \n Cost:$ " + cost + "\n -------------");
                toFile.Close();
                //Name: textBox1.txt + \n + Phone Number: textBox2.text + \n + Number of Guests
                // + textBox3.txt + Desserts: comboBox2.txt + combo1box.txt + Cost + cost
                MessageBox.Show("Note: Event has been added succesfully");
            }
        }
    }
}