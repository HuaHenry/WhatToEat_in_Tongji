using System;

namespace _20230224_3_WhatToEat
{

    public partial class Form1 : Form
    {
        //private string[] choice;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string[] choices = new string[21] {
            "春禾苑一楼快餐", 
            "春禾苑二楼快餐",
            "春禾苑一楼川菜",
            "春禾苑二楼西点",
            "春禾苑二楼面食",
            "秋谷苑一楼快餐",
            "秋谷苑二楼美食广场",
            "麦当劳",
            "KFC",
            "塔可星",
            "瓦罐煨汤",
            "希食东",
            "嘉实二楼黄焖鸡",
            "呷脯呷脯",
            "吉祥馄饨",
            "梦飨",
            "小样",
            "面霸",
            "萨莉亚",
            "全家FamilyMart",
            "罗森"
        };
        private void button1_Click(object sender, EventArgs e)
        {
            //生成随机数
            Random r = new Random();
            int number = r.Next(0, 21);
            MessageBox.Show("\n\tYou're Suggested:\t\t\t\n\n\t" + choices[number]+"\n\n");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string output = "EATJ_Pro_Win64 v1.00\n\n";
            output += "Current version is only available at Tongji University Jiading Campus in Shanghai, China\n";
            output += "\nDining options:\n";
            for (int i = 0; i < 21; i++)
            {
                output += '\t' + choices[i] + '\n';
            }
            output += "\nDevelopers: HzzzQ, CEIE in Tongji University\n";
            output += "If you have suggestions or other dining options, it will be welcome to CONTACT ME!\n";
            output += "Email: henryhua0721@foxmail.com";
            MessageBox.Show(output);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}