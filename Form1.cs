using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janshi_Separate
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            string[] members = Member_Box.Text.TrimEnd().Split('\n') ;
            List<string> member_lst = members.ToList();
            member_lst.ForEach(x => x.TrimEnd());
            List<List<string>> sepalate;

            if (Seed_box.Text != "")
            {
                int seed = StrToInt(Seed_box.Text);
                sepalate = janshi_gen.separate_member(member_lst,seed);
            }
            else
            {
                sepalate = janshi_gen.separate_member(member_lst);
            }

            string display = "";
            if (member_lst.Count < 3)
            {
                display = "3人以上を指定してください";
            }
            else
            {
                foreach (var (item, index) in sepalate.Select((item, index) => (item, index)))
                {
                    display += string.Format("第{0}卓({1}人)\r\n", index + 1, item.Count());
                    foreach (var (s, j) in item.Select((s, j) => (s, j)))
                    {
                        display += s;
                        if (item.Count != (j + 1))
                        {
                            display += "，";
                        }
                        else
                        {
                            display += "\r\n";
                        }
                    }

                    display += "\r\n";
                }
            }

            Result_box.Text = display;
        }

        private int StrToInt(string str)
        {
            int output;
            if (int.TryParse(str, out output))
            {
                return output;
            }
            else
            {
                byte[] strByte = Encoding.UTF8.GetBytes(str);
                byte[] byte4arr = new byte[4];
                List<int> intList = new List<int>();
                for(int i = 0; i<strByte.Length; i++)
                {
                    byte4arr[i % 4] = strByte[i];

                    if((i+1) % 4 == 0)
                    {
                        intList.Add(BitConverter.ToInt32(byte4arr, 0));
                    }
                }

                long max_seed = 0;
                intList.ForEach(x => max_seed += x);
                return (int)(max_seed % int.MaxValue);
            }
        }
    }
}
