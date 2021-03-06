﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Controls;
using rsp6m2.HelpClass;
using rsp6m2.Manager;

namespace rsp6m2
{
    public partial class prlStack : genericForm
    {
        br009 br0091 = new br009();
        bp213 bp2131 = new bp213();
        bp135 bp1351 = new bp135();
        brn01 brn011 = new brn01();
        bost bost1 = new bost();
        buv011 buv0111 = new buv011();
        bchv021 bchv0211 = new bchv021();
        bchk011 bchk0111 = new bchk011();
        bu011 bu0111 = new bu011();
        bki011 bki0111 = new bki011();
       // bp142 bp1421 = new bp142();
        bp138 bp1381 = new bp138();
        bp127 bp1271 = new bp127();
        bksg bksg1 = new bksg();
       // bpr011sm1 bpr011sm11 = new bpr011sm1();
        bpchs bpchs1 = new bpchs();
       // bpr011sm2 bpr011sm21 = new bpr011sm2();
        sp02 sp021 = new sp02();
        bpm011 bpm0111 = new bpm011();
        bvm011 bvm0111 = new bvm011();
        bop bop1 = new bop();
        bsf bsf1 = new bsf();
        bprn021 bprn0211 = new bprn021();
        uvch uvch1 = new uvch();
        bpr021 bpr021 = new bpr021();
        bp_apch bp_apch1 = new bp_apch();
        bf02 bf021 = new bf02();
        bg021 bg0211 = new bg021();
        pun pun1 = new pun();


        ProjectManager p;
        Form1 f;
        Holder holder;

        public prlStack(ProjectManager _p, Form1 _f)
        {
            InitializeComponent();
            p = _p;
            f = _f;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bp1271.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bop1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsf1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bksg1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bchv0211.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bchk0111.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bu0111.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bki0111.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sp021.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sp021.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bprn0211.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buv0111.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bpm0111.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bvm0111.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bp1351.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buv0111.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bpm0111.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bvm0111.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            uvch1.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            uvch1.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bpr021.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            bpr021.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            bp_apch1.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bp_apch1.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            bf021.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bf021.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pun1.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            bg0211.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            bg0211.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            brn011.Show();
        }
    }
}
