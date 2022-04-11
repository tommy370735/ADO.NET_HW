using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ADO.NET作業2_VS複習
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble( txtB_1.Text)%2 == 0)
            {
                lab_2.Text = "輸入的數字是：" + txtB_1.Text + " ，為雙數。";
            }
            else if(Convert.ToDouble(txtB_1.Text) % 2 == 1)
            {
                lab_2.Text = "輸入的數字是：" + txtB_1.Text + " ，為單數。";
            }
            else
            {
                lab_2.Text = "請輸入整數。";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 100, b = 66, c = 77;

            if (a > b && a > c)
            {
                lab_2.Text = "最大數值為：a，最大值為：" + a;
            }
            else if (b > a && b > c)
            {
                lab_2.Text = "最大數值為：b，最大值為：" + b;
            }
            else
            {
                lab_2.Text = "最大數值為：c，最大值為：" + c;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            int a =0,b = 0;
            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    b++;
                }
                else
                    a++;
            }
            lab_2.Text = "nums陣列[ 33, 4, 5, 11, 222, 34]中，" + "\n" + "奇數有：" + a + "個, 偶數有：" + b + "個。";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ksdkfjsdk","tommy","Masdy" };
            int x_長度 = 0;
            string result1 = "";
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > x_長度)
                {
                    x_長度 = names[i].Length;
                    result1 = names[i];
                }
                lab_2.Text = "names陣列[aaa, ksdkfjsdk,tommy,Masdy]中，"+"\n"+ "最長名字為：" + result1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ccc","ksdkfjsdk", "Caroylin", "Carol" };
            int c = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Contains("C") || names[i].Contains("c"))
                {
                    c++;
                }
            }
            lab_2.Text = "names陣列[aaa,ccc, ksdkfjsdk,Caroylin,Carol]中，" + "\n" + "共有：" + c + "個有C或c的名字。";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] arr_intest = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };
            Max_Params(arr_intest);
        }

        public void Max_Params(params int [] arr_params)
        {
            int max_P = arr_params[0];
            for (int i = 0; i < arr_params.Length; i++)
            {
                if (max_P < arr_params[i])
                {
                    max_P = arr_params[i];
                }
                lab_2.Text = "陣列中最大數字是：" + max_P;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };
            lab_2.Text= "scores陣列[2, 3, 46, 33, 22, 100, 150, 33, 55]中，" + "\n" + "最大值為："+ MAX(scores) +"\n" + "最小值為：" + Min(scores);
        }
        int MAX (int[] scores)
        {
            int MAX = scores[0];
            foreach (int item in scores)
            {
                MAX = MAX < item ? item : MAX;
            }
            return MAX;
        }
        int Min(int[] scores)
        {
            int Min = scores[0];
            foreach (int item in scores)
            {
                Min = Min > item ? item : Min;
            }
            return Min;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int[] rand = new int[6];
            for(int i = 0; i<6; i++)
            {
                rand[i] = rd.Next(1, 50);
                Thread.Sleep(100);
                for (int j = 0; j<i; j++)
                {
                    while(rand[j] == rand[i])
                    {
                        j = 0;
                        rand[i] = rd.Next(1, 50);
                        Thread.Sleep(100);
                    }
                }
            }
            lab_2.Text = "本期樂透彩開獎號碼為：" + "\n" + rand[0] + "號、" + rand[1] + "號、" + rand[2] + "號、" + rand[3] + "號、" + rand[4] + "號、" + rand[5] + "號。";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            lab_2.Font = new Font("標楷體", 12F);
            lab_2.Text = "";
            for (int i=1; i<10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    lab_2.Text +=$"{ i } x { j} ={ i * j,2} ";
                }
                lab_2.Text +="\n";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int X_十進位 = 100;
            int X_二進位;
            string Y_問號 = string.Empty;
            while (X_十進位 > 0)
            {
                X_二進位 = X_十進位 % 2;
                X_十進位 /= 2;
                Y_問號 = X_二進位.ToString() + Y_問號;
            }
            lab_2.Text = Y_問號;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Double Ans =0;
            Double T1 = Convert.ToDouble(textBox1.Text);
            Double T2 = Convert.ToDouble(textBox2.Text);
            Double T3 = Convert.ToDouble(textBox3.Text);
            for ( ; T1 <= T2; T1 += T3)
            {
                Ans += T1;
            }
            lab_2.Text = Ans.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Double Ans = 0;
            Double T1 = Convert.ToDouble(textBox1.Text);
            Double T2 = Convert.ToDouble(textBox2.Text);
            Double T3 = Convert.ToDouble(textBox3.Text);
            while (T1 <= T2)
            {
                Ans += T1;
                T1 += T3;
            }
            lab_2.Text = Ans.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Double Ans = 0;
            Double T1 = Convert.ToDouble(textBox1.Text);
            Double T2 = Convert.ToDouble(textBox2.Text);
            Double T3 = Convert.ToDouble(textBox3.Text);
            do
            {
                Ans += T1;
                T1 += T3;
            }
            while (T1 <= T2);
            lab_2.Text = Ans.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lab_2.Text = "";
        }
    }
}



/*


// MAX()   / Min ( int[] )
int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

int max = scores.Max();
//MessageBox.Show("Max = " + max);

//Array.Sort(scores);
//MessageBox.Show("Max =" + scores[scores.Length - 1]);

//================================

//Point[] points = new Point[3];
//points[0].X = 3;
//points[0].Y = 4;
////System.InvalidOperationException: '無法比較陣列中的兩個元素。'

//Array.Sort(points);

//=================================
int MyMinScore(int[] nums)
{
return 10;
}
//Max (params int[] )
//可輸入不固定的參數個數
*/