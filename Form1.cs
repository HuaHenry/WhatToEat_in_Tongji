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
            "����Էһ¥���", 
            "����Է��¥���",
            "����Էһ¥����",
            "����Է��¥����",
            "����Է��¥��ʳ",
            "���Էһ¥���",
            "���Է��¥��ʳ�㳡",
            "����",
            "KFC",
            "������",
            "�߹�����",
            "ϣʳ��",
            "��ʵ��¥���˼�",
            "�ȸ��ȸ�",
            "�������",
            "����",
            "С��",
            "���",
            "������",
            "ȫ��FamilyMart",
            "��ɭ"
        };
        private void button1_Click(object sender, EventArgs e)
        {
            //���������
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