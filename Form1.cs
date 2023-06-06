using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumentum_Interview
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
      

        public Form1()
        {
            
            InitializeComponent();
            // set up the timer to run every 1000 milliseconds (1 second)
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //storage the list of the elevators
        storage1 floor1 = new storage1();
        storage2 floor2 = new storage2();
        storage3 floor3 = new storage3();
        private void button1_Click(object sender, EventArgs e)
        {
          
            
            //Person 1
            string authentication = "VIP";
            Users person1 = new Users();
            person1.FirstName = "John";
            person1.ID = 1;
            person1.Floor = 0;
            person1.auth = "VIP";
            List<Users> people = new List<Users>();
            people.Add(person1);
           


            if (authentication == "VIP")
            {
                radioButton1.Visible = true;
                radioButton4.Visible = true;
            }
            



            foreach (Users person in people)
            {
                ListViewItem item = new ListViewItem(person.FirstName);
                item.SubItems.Add(person.FirstName);
                item.SubItems.Add(person.ID.ToString());
                item.SubItems.Add(person.auth);

                listView1.Items.Add(item);
            }

        }

       
       
        public void ErrorHandling(RichTextBox rtb, String word, String word2)
        {
            rtb.Text = rtb.Text.Replace(word, word2);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elavator listHolder = new Elavator();
            Elavator1 listHolder1 = new Elavator1();
            Elavator2 listHolder2 = new Elavator2();
            /////////Data To put in the elavtor for any floors
            while (true)
            {
                if (Elavator.available == true )
                {


                    floor1.track.Add(4);
                    floor1.track.Add(6);
                    floor1.track.Add(9);
                    floor1.track.Add(11);
                    listHolder.RequestAsync(floor1);
                }
                else if (Elavator1.available == true)
                {


                    floor2.track.Add(2);
                    floor2.track.Add(4);
                    floor2.track.Add(6);
                    floor2.track.Add(8);
                    listHolder1.RequestAsync(floor2);
                }
                else if (Elavator2.available == true)
                {


                    floor3.track.Add(1);
                    floor3.track.Add(4);
                    floor3.track.Add(2);
                    floor3.track.Add(10);
                    listHolder2.RequestAsync(floor3);
                }
                else
                {
                    if (floor1.track.Count <= floor2.track.Count && floor1.track.Count <= floor3.track.Count)
                    {
                        
                        Elavator.available = true;
                    }
                    else if (floor2.track.Count <= floor1.track.Count && floor2.track.Count <= floor3.track.Count)
                    {
                        
                        Elavator1.available = true;
                    }
                    else
                    {
                        Elavator2.available = true;
                    }
                }
                break;
            }
            

            
        }
        public HashSet<int> elevatorwentby = new HashSet<int>();
        private void Timer_Tick(object sender, EventArgs e)
        {
          
            // update the list view
            listView2.Items.Clear();

            listView2.Items.Add("Elavator 1");
           
            listView2.Items.Add("Floor: " + Elavator.number.ToString());
            if(floor1.track.Count == 0)
            {
                Elavator.number = 0;
            }
            richTextBox4.Text = string.Join(Environment.NewLine, floor1.track);


            listView2.Items.Add("----------");

            listView2.Items.Add("Elavator 2");
            listView2.Items.Add("Floor: " + Elavator1.number.ToString());
            if (floor2.track.Count == 0)
            {
                Elavator1.number = 0;
            }
            richTextBox5.Text = string.Join(Environment.NewLine, floor2.track);

            listView2.Items.Add("----------");

            listView2.Items.Add("Elavator 3");
            listView2.Items.Add("Floor: "+Elavator2.number.ToString());
            if (floor3.track.Count == 0)
            {
                Elavator2.number = 0;
            }
            richTextBox6.Text = string.Join(Environment.NewLine, floor3.track);
            
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Elavator listHolder = new Elavator();
            Elavator1 listHolder1 = new Elavator1();
            Elavator2 listHolder2 = new Elavator2();
            /////////Data To put in the elavtor for any floors (goign down)
            while (true)
            {
                if (Elavator.available == true)
                {


                    floor1.track.Add(4);
                    floor1.track.Add(6);
                    floor1.track.Add(9);
                    floor1.track.Add(11);
                    listHolder.RequestAsync(floor1);
                }
                else if (Elavator1.available == true)
                {


                    floor2.track.Add(2);
                    floor2.track.Add(4);
                    floor2.track.Add(6);
                    floor2.track.Add(8);
                    listHolder1.RequestAsync(floor2);
                }
                else if (Elavator2.available == true)
                {


                    floor3.track.Add(1);
                    floor3.track.Add(4);
                    floor3.track.Add(2);
                    floor3.track.Add(10);
                    listHolder2.RequestAsync(floor3);
                }
                else
                {
                    if (floor1.track.Count <= floor2.track.Count && floor1.track.Count <= floor3.track.Count)
                    {

                        Elavator.available = true;
                    }
                    else if (floor2.track.Count <= floor1.track.Count && floor2.track.Count <= floor3.track.Count)
                    {

                        Elavator1.available = true;
                    }
                    else
                    {
                        Elavator2.available = true;
                    }
                }
                break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox3.Text = "3";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox3.Text = "1";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "1";
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox3.Text = "2";
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "2";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "3";
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Elavator listHolder = new Elavator();
            Elavator1 listHolder1 = new Elavator1();
            Elavator2 listHolder2 = new Elavator2();
            //Elavator.value = 1;




            if (floor1.track.Count <= floor2.track.Count && floor1.track.Count <= floor3.track.Count)
            {
                if (richTextBox3.Text != "3")
                {
                    Elavator.available = true;
                    floor1.track.Add(int.Parse(richTextBox3.Text));

              
                    listHolder.SCAN(floor1, Elavator.number, "left");
                }
                else
                {
                    Elavator2.available = true;
                    floor3.track.Add(int.Parse(richTextBox3.Text));

                    listHolder2.SCAN(floor3, Elavator2.number, "left");
                }

            }
            else if (floor2.track.Count <= floor1.track.Count && floor2.track.Count <= floor3.track.Count)
            {
                if (richTextBox3.Text != "3")
                {
                    Elavator1.available = true;
                    floor2.track.Add(int.Parse(richTextBox3.Text));

                 
                    listHolder1.SCAN(floor2, Elavator1.number, "left");
                }
                else
                {
                    Elavator2.available = true;
                    floor3.track.Add(int.Parse(richTextBox3.Text));

                   
                    listHolder2.SCAN(floor3, Elavator2.number, "left");
                }

            }
            else
            {
                Elavator2.available = true;
                floor3.track.Add(int.Parse(richTextBox3.Text));

                
                listHolder2.SCAN(floor3, Elavator2.number, "left");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Elavator listHolder = new Elavator();
            Elavator1 listHolder1 = new Elavator1();
            Elavator2 listHolder2 = new Elavator2();
           

            


            if (floor1.track.Count <= floor2.track.Count && floor1.track.Count <= floor3.track.Count)
            {
                if(richTextBox2.Text != "3")
                {
                    Elavator.available = true;
                    floor1.track.Add(int.Parse(richTextBox2.Text));

                  
                    listHolder.SCAN(floor1, Elavator.number, "left");
                }
                else
                {
                    Elavator2.available = true;
                    floor3.track.Add(int.Parse(richTextBox2.Text));

                   
                    listHolder2.SCAN(floor3, Elavator2.number, "left");
                }
               
            }
            else if (floor2.track.Count <= floor1.track.Count && floor2.track.Count <= floor3.track.Count)
            {
                if (richTextBox2.Text != "3")
                {
                    Elavator1.available = true;
                    floor2.track.Add(int.Parse(richTextBox2.Text));

                   
                    listHolder1.SCAN(floor2, Elavator1.number, "left");
                }
                else
                {
                    Elavator2.available = true;
                    floor3.track.Add(int.Parse(richTextBox2.Text));

                  
                    listHolder2.SCAN(floor3, Elavator2.number, "left");
                }
                   
            }
            else
            {
                Elavator2.available = true;
                floor3.track.Add(int.Parse(richTextBox2.Text));

               
                listHolder2.SCAN(floor3, Elavator2.number, "left");
            }
        }
            
           
        

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
