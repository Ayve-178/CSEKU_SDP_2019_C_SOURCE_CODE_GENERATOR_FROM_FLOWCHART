using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Test
{
    public partial class MainForm : Form
    {
        string str;
        string[] fcn = new string[200];
        string[] code = new string[200];
        string[] codeC = new string[200];
        string[] sss = new string[200];

        int cc = 1;
        int codeField;


        int rr, ss,temp,temp1,a1,b1,c1;
        int fc = 1 ;
        //int sfc = 0;
        int qq = 1;
        int index;
        int bi = 0, ti = 0, li = 0, bti = 0, tti = 0, lti = 0;
        int xx = 0, yy = 0, ww = 0, hh = 0, pp = 0;
        int z = 0, x = 0, y = 0;

        int[] X = new int[200];
        int[] Y = new int[200];
        int[] W = new int[200];
        int[] H = new int[200];
        int[] P = new int[200];

        //int xx = 0, yy = 0, ww = 0, hh = 0, pp=0;
    

        private ArrayList pointsCircle = new ArrayList();
        private ArrayList pointsECircle = new ArrayList();
        private ArrayList pointsRect = new ArrayList();
        private ArrayList pointsConnect = new ArrayList();
        private ArrayList pointsPargram = new ArrayList();
        private ArrayList pointsCondition = new ArrayList();
        private ArrayList writeVar  = new ArrayList();
        private ArrayList pointsForLoop = new ArrayList();

        private bool isCircleClickd = false;
        private bool isRectClicked = false;
        private bool isConnectClicked = false;
        private bool isEndCircleClickd = false;
        private bool isPargramClickedVar = false;
        private bool isPargramClickedScan = false;
        private bool isPargramClickedPrint = false;
        private bool isCondition = false;
        private bool isForLoop = false;

        public MainForm()
        {
            InitializeComponent();
        }

        //int z = 0, x=0, y=0;


        //For flowchart shapes and popup boxes..
        //int bi = 0, ti = 0, li=0 , bti = 0, tti = 0, lti = 0;
        Button[] b = new Button[200];
        TextBox[] t = new TextBox[200];
        Label[] l = new Label[200];

        //For inserting the input values into the flowchart..
        //int bti = 0, tti = 0, lti = 0;
        Button[] b2 = new Button[200];
        TextBox[] t2 = new TextBox[200];
        Label[] l2 = new Label[200];

        //For FlowChart Number..
        Label[] fn = new Label[500];

        int p, q,pt,qt, pf, qf , pcon, qcon , pind , qind, pins, qins;

        private void button_circle_Click(object sender, EventArgs e)
        {
            isRectClicked = false;
            isCircleClickd = true;
            isConnectClicked = false;
            isEndCircleClickd = false;
            isPargramClickedVar = false;
            isPargramClickedScan = false;
            isPargramClickedPrint = false;
            isCondition = false;
            isForLoop = false;
        }

        private void button_Rect_Click(object sender, EventArgs e)
        {
            isRectClicked = true;
            isCircleClickd = false;
            isConnectClicked = false;
            isEndCircleClickd = false;
            isPargramClickedVar = false;
            isPargramClickedScan = false;
            isPargramClickedPrint = false;
            isCondition = false;
            isForLoop = false;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            isCircleClickd = false;
            isRectClicked = false;
            isConnectClicked = true;
            isEndCircleClickd = false;
            isPargramClickedVar = false;
            isPargramClickedScan = false;
            isPargramClickedPrint = false;
            isCondition = false;
            isForLoop = false;
        }


        private void button_EndCircle_Click(object sender, EventArgs e)
        {
            isCircleClickd = false;
            isRectClicked = false;
            isConnectClicked = false;
            isEndCircleClickd = true;
            isPargramClickedVar = false;
            isPargramClickedScan = false;
            isPargramClickedPrint = false;
            isCondition = false;
            isForLoop = false;
        }

        private void button_Pargram_Click(object sender, EventArgs e)
        {
            isCircleClickd = false;
            isRectClicked = false;
            isConnectClicked = false;
            isEndCircleClickd = false;
            isPargramClickedVar = true;
            isPargramClickedScan = false;
            isPargramClickedPrint = false;
            isCondition = false;
            isForLoop = false;
        }


        private void button_PargramScan_Click(object sender, EventArgs e)
        {
            isCircleClickd = false;
            isRectClicked = false;
            isConnectClicked = false;
            isEndCircleClickd = false;
            isPargramClickedVar = false;
            isPargramClickedScan = true;
            isPargramClickedPrint = false;
            isCondition = false;
            isForLoop = false;
        }

        private void PargramPrint_Click(object sender, EventArgs e)
        {
            isCircleClickd = false;
            isRectClicked = false;
            isConnectClicked = false;
            isEndCircleClickd = false;
            isPargramClickedVar = false;
            isPargramClickedScan = false;
            isPargramClickedPrint = true;
            isCondition = false;
            isForLoop = false;
        }

        private void Condition_Click(object sender, EventArgs e)
        {
            isCircleClickd = false;
            isRectClicked = false;
            isConnectClicked = false;
            isEndCircleClickd = false;
            isPargramClickedVar = false;
            isPargramClickedScan = false;
            isPargramClickedPrint = false;
            isCondition = true;
            isForLoop = false;
        }

        private void forLoop_Click(object sender, EventArgs e)
        {
            isCircleClickd = false;
            isRectClicked = false;
            isConnectClicked = false;
            isEndCircleClickd = false;
            isPargramClickedVar = false;
            isPargramClickedScan = false;
            isPargramClickedPrint = false;
            isCondition = false;
            isForLoop = true;

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
           // Graphics g = Graphics.FromHwnd(this.Handle);

            // Add to points collection.

            //Start Program Button..
            if (isCircleClickd == true)         
            {
                pointsCircle.Add(new Point(e.X, e.Y));

                isCircleClickd = false;

                Label l = new Label();
                l.Location = new Point(e.X + 30, e.Y + 15);
                l.Size = new Size(60, 20);
                // l.BackColor = Color.Blue;
                l.Text = "Start";
                l.Font = new Font("Arial", 12);
                l.ForeColor = Color.Black;
                Controls.Add(l);

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 15, e.Y - 10);
                fn[fc].Size = new Size(30, 15);
                string qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "start";

                fc++;
                qq++;

                code[cc] = "#include<stdio.h> \n\nint main() \n{";
                codeC[cc] = "#include<stdio.h> \n\nint main() \n{";
                cc++;

                Invalidate();
            }


            //End Program Button..
            else if (isEndCircleClickd == true)
            {
                pointsECircle.Add(new Point(e.X, e.Y));

                isEndCircleClickd = false;

                Label l = new Label();
                l.Location = new Point(e.X - 25, e.Y + 46);
                l.Size = new Size(60, 20);
                l.Text = "End";
                l.Font = new Font("Arial", 12);
                l.ForeColor = Color.Black;
                Controls.Add(l);

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 55, e.Y + 10);
                fn[fc].Size = new Size(30, 15);
                string qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "end";

                fc++;
                qq++;

                code[cc] = "return 0; \n}";
                codeC[cc] = "return 0; \n}";
                cc++;

                Invalidate();
            }


            //Processes Button..
            else if (isRectClicked == true)
            {
                pointsRect.Add(new Point(e.X, e.Y));

                isRectClicked = false;

                //TextBox t = new TextBox();
                l[li] = new Label();
                l[li].Location = new Point(350, 200);
                l[li].Size = new Size(300, 100);
                l[li].BackColor = Color.Bisque;
                l[li].Text = "Process : ";
                l[li].Font = new Font("Ariel", 12);

                t[ti] = new TextBox();
                t[ti].Location = new Point(380, 250);
                t[ti].BackColor = Color.AntiqueWhite;

                b[bi] = new Button();
                b[bi].Parent = this;
                b[bi].Location = new System.Drawing.Point(580, 255);
                b[bi].Size = new System.Drawing.Size(60, 30);
                b[bi].Name = "New_b";
                b[bi].Text = "Ok";

                z = ti;
                x = li;
                y = bi;

                pp = fc; 

                b[bi].Click += (sender1, ex) => this.DisplayProcess();

                Controls.Add(b[bi]);
                Controls.Add(t[ti]);
                Controls.Add(l[li]);

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 55, e.Y + 10);
                fn[fc].Size = new Size(30, 15);
                string qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "process";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;
                //pp = fc;

                fc++;
                qq++;

                str = t[ti].Text;

                p = e.X - 45;
                q = e.Y + 40;

                X[xx] = p;
                Y[yy] = q;
                W[ww] = 60;
                H[hh] = 20;

                li++;
                bi++;
                ti++;

                Invalidate();
            }

            //Connector Button (need to change)
            //else if (isConnectClicked == true)
            //{
            //    pointsConnect.Add(new Point(e.X, e.Y));
            //    Invalidate();
            //}
            //Taking Variables Button..
            else if(isPargramClickedVar == true)
            {
                pointsPargram.Add(new Point(e.X, e.Y));

                isPargramClickedVar = false;

                //TextBox t = new TextBox();

                l[li] = new Label();
                l[li].Location = new Point(350, 200);
                l[li].Size = new Size(300, 100);
                l[li].BackColor = Color.Bisque;
                l[li].Text = "Take Variables";
                l[li].Font = new Font("Ariel", 12);

                t[ti] = new TextBox();
                t[ti].Location = new Point(380, 250);
                t[ti].BackColor = Color.AntiqueWhite;

                b[bi] = new Button();
                b[bi].Parent = this;
                b[bi].Location = new System.Drawing.Point(580, 255);
                b[bi].Size = new System.Drawing.Size(60, 30);
                b[bi].Name = "New_b";
                b[bi].Text = "Ok";

                z = ti;
                x = li;
                y = bi;

                pp = fc; 

                b[bi].Click += (sender1, ex) => this.DisplayTakeVar();

                Controls.Add(b[bi]);
                Controls.Add(t[ti]);
                Controls.Add(l[li]);

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 55, e.Y + 10);
                fn[fc].Size = new Size(30, 15);
                string qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "tVar";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                Label ll = new Label();
                ll.Location = new Point(e.X - 60, e.Y + 40);
                ll.Size = new Size(35, 20);
                ll.Text = "int";
                ll.Font = new Font("Arial", 14);
                ll.ForeColor = Color.Black;
                Controls.Add(ll);

                p = e.X - 27;
                q = e.Y + 40;

                X[xx] = p;
                Y[yy] = q;
                W[ww] = 60;
                H[hh] = 20;

                li++;
                bi++;
                ti++;

                Invalidate();
            }
            else if(isPargramClickedScan == true)
            {
                pointsPargram.Add(new Point(e.X, e.Y));

                isPargramClickedScan = false;

                //Label ls = new Label();
                l[li] = new Label();
                l[li].Location = new Point(350, 200);
                l[li].Size = new Size(300, 100);
                l[li].BackColor = Color.Bisque;
                l[li].Text = "Read Variables";
                l[li].Font = new Font("Ariel", 12);

                //TextBox ts = new TextBox();
                t[ti] = new TextBox();
                t[ti].Location = new Point(380, 250);
                t[ti].BackColor = Color.AntiqueWhite;

                // Button bs = new Button();
                b[bi] = new Button();
                b[bi].Parent = this;
                b[bi].Location = new System.Drawing.Point(580, 255);
                b[bi].Size = new System.Drawing.Size(35, 20);
                b[bi].Name = "New_bs";
                b[bi].Text = "Ok";

                z = ti;
                x = li;
                y = bi;

                pp = fc; 

                b[bi].Click += (sender1, ex) => this.DisplayReadVar();

                Controls.Add(b[bi]);
                Controls.Add(t[ti]);
                Controls.Add(l[li]);

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 55, e.Y + 10);
                fn[fc].Size = new Size(30, 15);
                string qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "rVar";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                Label ll = new Label();
                ll.Location = new Point(e.X - 54, e.Y + 40);
                ll.Size = new Size(50, 20);
                ll.Text = "Read";
                ll.Font = new Font("Arial", 12);
                ll.ForeColor = Color.Black;
                Controls.Add(ll);

                p = e.X - 5;
                q = e.Y + 40;

                X[xx] = p;
                Y[yy] = q;
                W[ww] = 60;
                H[hh] = 20;

                li++;
                bi++;
                ti++;

                Invalidate();
            }
            else if(isPargramClickedPrint == true)
            {
                pointsPargram.Add(new Point(e.X, e.Y));

                isPargramClickedPrint = false;

                l[li] = new Label(); 
                l[li].Location = new Point(350, 200);
                l[li].Size = new Size(300, 100);
                l[li].BackColor = Color.Bisque;
                l[li].Text = "Print Output";
                l[li].Font = new Font("Ariel", 12);

                t[ti] = new TextBox();
                t[ti].Location = new Point(380, 250);
                t[ti].BackColor = Color.AntiqueWhite;

                b[bi] = new Button();
                b[bi].Parent = this;
                b[bi].Location = new System.Drawing.Point(580, 255);
                b[bi].Size = new System.Drawing.Size(35, 20);
                b[bi].Text = "Ok";

                z = ti;
                x = li;
                y = bi;

                pp = fc;

                b[bi].Click += (sender1, ex) => this.DisplayPrintVar();

                Controls.Add(b[bi]);
                Controls.Add(t[ti]);
                Controls.Add(l[li]);

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 55, e.Y + 10);
                fn[fc].Size = new Size(30, 15);
                string qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "pVar";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                Label ll = new Label();
                ll.Location = new Point(e.X - 54, e.Y + 40);
                ll.Size = new Size(50, 20);
                ll.Text = "Print ";
                ll.Font = new Font("Arial", 12);
                ll.ForeColor = Color.Black;
                Controls.Add(ll);

                p = e.X-5;
                q = e.Y + 40;

                X[xx] = p;
                Y[yy] = q;
                W[ww] = 60;
                H[hh] = 20;

                li++;
                ti++;
                bi++;

                Invalidate();
            }
            else if(isCondition==true)
            {
                pointsCondition.Add(new Point(e.X, e.Y));

                isCondition = false;

                //Label ls = new Label();
                l[li] = new Label();
                l[li].Location = new Point(350, 200);
                l[li].Size = new Size(300, 100);
                l[li].BackColor = Color.Bisque;
                l[li].Text = "Condition?";
                l[li].Font = new Font("Ariel", 12);

                //TextBox ts = new TextBox();
                t[ti] = new TextBox();
                t[ti].Location = new Point(380, 250);
                t[ti].BackColor = Color.AntiqueWhite;

                //Button bs = new Button();
                b[bi] = new Button();
                b[bi].Parent = this;
                b[bi].Location = new System.Drawing.Point(580, 255);
                b[bi].Size = new System.Drawing.Size(35, 20);
                b[bi].Name = "New_bs";
                b[bi].Text = "Ok";

                z = ti;
                x = li;
                y = bi;

                pp = fc;

                Console.WriteLine("Hey There!!\n");

                b[bi].Click += (sender1, ex) => this.DisplayCondition();

                Controls.Add(b[bi]);
                Controls.Add(t[ti]);
                Controls.Add(l[li]);

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 45, e.Y + 10);
                fn[fc].Size = new Size(30, 15);
                string qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "condition";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                rr = fc;

                p = e.X - 48;
                q = e.Y + 90;

                X[xx] = p;
                Y[yy] = q;
                W[ww] = 75;
                H[hh] = 20;


                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X + 140, e.Y + 145);
                fn[fc].Size = new Size(30, 15);
                qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "conditionT";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                Console.WriteLine("Hey There!! 2 \n");

                ss = fc;

                pt = e.X + 87;
                qt = e.Y + 180;

                X[xx] = pt;
                Y[yy] = qt;
                W[ww] = 60;
                H[hh] = 20;

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 160, e.Y + 145);
                fn[fc].Size = new Size(30, 15);
                qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "conditionF";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                Console.WriteLine("Hey There!!  3 \n");

                Console.WriteLine("rr = " +rr + "\nss = "+ss);

                pf = e.X - 152;
                qf = e.Y + 180;

                X[xx] = pf;
                Y[yy] = qf;
                W[ww] = 60;
                H[hh] = 20;      

                li++;
                ti++;
                bi++;

                l[li] = new Label();
                l[li].Location = new Point(e.X + 80, e.Y + 70);
                l[li].Size = new Size(60, 20);
                l[li].Text = "Yes";
                l[li].Font = new Font("Ariel", 12);
                

                Controls.Add(l[li]);

                li++;

                l[li] = new Label();
                l[li].Location = new Point(e.X - 115, e.Y + 70);
                l[li].Size = new Size(45, 20);
                l[li].Text = "No";
                l[li].Font = new Font("Ariel", 12);

                Controls.Add(l[li]);

                li++;

                Invalidate();
            }
            else if(isForLoop==true)
            {
                pointsForLoop.Add(new Point(e.X, e.Y));

                isForLoop = false;

                //Label ls = new Label();
                l[li] = new Label();
                l[li].Location = new Point(350, 200);
                l[li].Size = new Size(300, 100);
                l[li].BackColor = Color.Bisque;
                l[li].Text = "Initialize ";
                l[li].Font = new Font("Ariel", 12);

                //TextBox ts = new TextBox();
                t[ti] = new TextBox();
                t[ti].Location = new Point(380, 250);
                t[ti].BackColor = Color.AntiqueWhite;

                // Button bs = new Button();
                b[bi] = new Button();
                b[bi].Parent = this;
                b[bi].Location = new System.Drawing.Point(580, 255);
                b[bi].Size = new System.Drawing.Size(30, 20);
                b[bi].Name = "New_bs";
                b[bi].Text = "Ok";

                z = ti;
                x = li;
                y = bi;

                pp = fc;

                b[bi].Click += (sender1, ex) => this.DisplayForLoop();

                Controls.Add(b[bi]);
                Controls.Add(t[ti]);
                Controls.Add(l[li]);

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 35, e.Y + 10);
                fn[fc].Size = new Size(30, 15);
                string qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "loopIn";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                p = e.X - 15;
                q = e.Y + 40;

                X[xx] = p;
                Y[yy] = q;
                W[ww] = 52;
                H[hh] = 20;

                a1 = fc;

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 45, e.Y + 95);
                fn[fc].Size = new Size(30, 15);
                qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "loopCon";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;
                
                fc++;
                qq++;

                pcon = e.X - 48;
                qcon = e.Y + 160;

                X[xx] = pcon;
                Y[yy] = qcon;
                W[ww] = 75;
                H[hh] = 20;

                b1 = fc;

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 130, e.Y + 190);
                fn[fc].Size = new Size(30, 15);
                qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "loopID";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                pind = e.X - 118;
                qind = e.Y + 222;

                X[xx] = pind;
                Y[yy] = qind;
                W[ww] = 52;
                H[hh] = 20;

                c1 = fc;

                fn[fc] = new Label();
                fn[fc].Location = new Point(e.X - 56, e.Y + 250);
                fn[fc].Size = new Size(30, 15);
                qs = qq.ToString();
                fn[fc].Text = qs;
                fn[fc].Font = new Font("Arial", 12);
                fn[fc].ForeColor = Color.Black;
                Controls.Add(fn[fc]);

                fcn[fc] = "loopState";

                xx = fc;
                yy = fc;
                ww = fc;
                hh = fc;

                fc++;
                qq++;

                pins = e.X - 48;
                qins = e.Y + 285;

                X[xx] = pins;
                Y[yy] = qins;
                W[ww] = 60;
                H[hh] = 20;

                li++;
                ti++;
                bi++;

                Invalidate();
            }
        }

        private void DisplayCondition()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(p, q);
            l2[lti].Size = new Size(75, 20);
            //lp.BackColor = Color.Red;
            l2[lti].Text = t[z].Text;
            P[pp] = lti;

            code[cc] = "if(" + t[z].Text + ")\n    {";
            codeC[cc] = "if(" + t[z].Text + ")\n    {";
            cc++;

            /*Console.WriteLine("Hey There!! 4 \n");
            Console.WriteLine(pp);
            Console.WriteLine(lti);
            Console.WriteLine(P[pp]);
            Console.WriteLine("I Got Condition\n");*/
            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l[x].Dispose();
            t[z].Dispose();
            b[y].Dispose();

            lti++;

            l2[lti] = new Label();
            l2[lti].Location = new Point(350, 200);
            l2[lti].Size = new Size(300, 100);
            l2[lti].BackColor = Color.Bisque;
            l2[lti].Text = "If yes?";
            l2[lti].Font = new Font("Ariel", 12);

            t2[tti] = new TextBox();
            t2[tti].Location = new Point(380, 250);
            t2[tti].BackColor = Color.AntiqueWhite;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(580, 255);
            b2[bti].Size = new System.Drawing.Size(35, 20);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Ok";

            Controls.Add(b2[bti]);
            Controls.Add(t2[tti]);
            Controls.Add(l2[lti]);

            x = lti;
            y = bti;
            z = tti;


            b2[bti].Click += (sender1, ex) => this.DisplayConditionTrue();

            Console.WriteLine("Hey There!! 5 \n");

            lti++;
            bti++;
            tti++;

            Invalidate();
        }

        private void DisplayConditionTrue()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(pt, qt);
            l2[lti].Size = new Size(60, 20);
            //lp.BackColor = Color.Red;
            l2[lti].Text = t2[z].Text;

            P[rr] = lti;

            code[cc] = "    " + t2[z].Text + ";\n    }";
            codeC[cc] = "    " + t2[z].Text + ";\n    }";
            cc++;

            temp = lti;

            /*Console.WriteLine("Hey There!!  6 \n");
            Console.WriteLine(pp);
            Console.WriteLine(lti);
            Console.WriteLine(P[pp]);
            Console.WriteLine("I Got ConditionTrue\n");*/

            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l2[x].Dispose();
            t2[z].Dispose();
            b2[y].Dispose();

            lti++;

            l2[lti] = new Label();
            l2[lti].Location = new Point(350, 200);
            l2[lti].Size = new Size(300, 100);
            l2[lti].BackColor = Color.Bisque;
            l2[lti].Text = "If no??";
            l2[lti].Font = new Font("Ariel", 12);

            t2[tti] = new TextBox();
            t2[tti].Location = new Point(380, 250);
            t2[tti].BackColor = Color.AntiqueWhite;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(580, 255);
            b2[bti].Size = new System.Drawing.Size(35, 20);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Ok";

            Controls.Add(b2[bti]);
            Controls.Add(t2[tti]);
            Controls.Add(l2[lti]);

            x = lti;
            y = bti;
            z = tti;


            Console.WriteLine("Hey There!! 7 \n");

            b2[bti].Click += (sender1, ex) => this.DisplayConditionFalse();

            Console.WriteLine("Hey There!!  8 \n");

            lti++;
            bti++;
            tti++;

            Invalidate();
        }

        private void DisplayConditionFalse()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(pf, qf);
            l2[lti].Size = new Size(60, 20);
            //lp.BackColor = Color.Red;
            l2[lti].Text = t2[z].Text;

            code[cc] = "else\n    {\n        " + t2[z].Text + ";\n    }";
            codeC[cc] = "else\n    {\n        " + t2[z].Text + ";\n    }";
            cc++;

            P[ss] = P[rr]+2;
            temp1 = lti;

            /*Console.WriteLine(pp);
            Console.WriteLine(lti);
            Console.WriteLine(P[pp]);
            Console.WriteLine("I Got ConditionFalse");
            Console.WriteLine("\n");

            Console.WriteLine("Hey There!!  9 \n");

            Console.WriteLine("I Got here!");
            Console.WriteLine(lti);
            Console.WriteLine(pp);
            Console.WriteLine(P[pp]);
            Console.WriteLine("\n");*/

            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            lti++;

            l2[x].Dispose();
            t2[z].Dispose();
            b2[y].Dispose();
        }

        private void DisplayForLoop()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(p, q);
            l2[lti].Size = new Size(52, 20);
            //lp.BackColor = Color.Red;
            l2[lti].Text = t[z].Text;

            P[pp] = lti;

            sss[0] = t[z].Text;

            //code[cc] = "for(" + t[z].Text + ";";
            //codeC[cc] = "for(" + t[z].Text + ";";

            /*Console.WriteLine(pp);
            Console.WriteLine(lti);
            Console.WriteLine(P[pp]);
            Console.WriteLine("I Got Loop");*/

            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l[x].Dispose();
            t[z].Dispose();
            b[y].Dispose();

            lti++;

            l2[lti] = new Label();
            l2[lti].Location = new Point(350, 200);
            l2[lti].Size = new Size(300, 100);
            l2[lti].BackColor = Color.Bisque;
            l2[lti].Text = "Condition?";
            l2[lti].Font = new Font("Ariel", 12);
            
            t2[tti] = new TextBox();
            t2[tti].Location = new Point(380, 250);
            t2[tti].BackColor = Color.AntiqueWhite;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(580, 255);
            b2[bti].Size = new System.Drawing.Size(35, 20);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Ok";

            Controls.Add(b2[bti]);
            Controls.Add(t2[tti]);
            Controls.Add(l2[lti]);

            x = lti;
            y = bti;
            z = tti;

            pp = fc;

            b2[bti].Click += (sender1, ex) => this.DisplayForLoopCondition();

            lti++;
            bti++;
            tti++;

            Invalidate();
        }

        private void DisplayForLoopCondition()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(pcon, qcon);
            l2[lti].Size = new Size(75, 20);
            //lp.BackColor = Color.Red;
            l2[lti].Text = t2[z].Text;

            P[a1] = lti;

            sss[1] = t2[z].Text;

            //code[cc] = code[cc] + t2[z].Text + ";";
            //codeC[cc] = codeC[cc] + t2[z].Text + ";";

            /*Console.WriteLine(pp);
            Console.WriteLine(lti);
            Console.WriteLine("I Got LoopCondition");
            Console.WriteLine("\n");*/

            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l2[x].Dispose();
            t2[z].Dispose();
            b2[y].Dispose();

            lti++;

            l2[lti] = new Label();
            l2[lti].Location = new Point(350, 200);
            l2[lti].Size = new Size(300, 100);
            l2[lti].BackColor = Color.Bisque;
            l2[lti].Text = "Increament / decreament ";
            l2[lti].Font = new Font("Ariel", 12);

            t2[tti] = new TextBox();
            t2[tti].Location = new Point(380, 250);
            t2[tti].BackColor = Color.AntiqueWhite;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(580, 255);
            b2[bti].Size = new System.Drawing.Size(35, 20);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Ok";

            Controls.Add(b2[bti]);
            Controls.Add(t2[tti]);
            Controls.Add(l2[lti]);

            x = lti;
            y = bti;
            z = tti;

            pp = fc;

            b2[bti].Click += (sender1, ex) => this.DisplayForLoopIncDec();

            lti++;
            bti++;
            tti++;

            Invalidate();
        }

        private void DisplayForLoopIncDec()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(pind, qind);
            l2[lti].Size = new Size(52, 20);
            //lp.BackColor = Color.Red;
            l2[lti].Text = t2[z].Text;

            P[b1] = lti;

            sss[2] = t2[z].Text;

            //code[cc] = code[cc] + t2[z].Text + ")\n    {";
            //codeC[cc] = codeC[cc] + t2[z].Text + ")\n    {";
            code[cc] = "for(" + sss[0] + ";" + sss[1] + ";" + sss[2] + ")\n    {";
            codeC[cc] = "for(" + sss[0] + ";" + sss[1] + ";" + sss[2] + ")\n    {";

            cc++;
            code[cc] = "-1";
            codeC[cc] = "-1";
            cc++;
            code[cc] = "-1";
            codeC[cc] = "-1";
            cc++;

            /*Console.WriteLine(pp);
            Console.WriteLine(lti);
            Console.WriteLine(P[pp]);
            Console.WriteLine("I Got LoopIncr");*/

            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l2[x].Dispose();
            t2[z].Dispose();
            b2[y].Dispose();

            lti++;

            l2[lti] = new Label();
            l2[lti].Location = new Point(350, 200);
            l2[lti].Size = new Size(300, 100);
            l2[lti].BackColor = Color.Bisque;
            l2[lti].Text = "Statement";
            l2[lti].Font = new Font("Ariel", 12);

            t2[tti] = new TextBox();
            t2[tti].Location = new Point(380, 250);
            t2[tti].BackColor = Color.AntiqueWhite;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(580, 255);
            b2[bti].Size = new System.Drawing.Size(35, 20);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Ok";

            Controls.Add(b2[bti]);
            Controls.Add(t2[tti]);
            Controls.Add(l2[lti]);

            x = lti;
            y = bti;
            z = tti;

            pp = fc;

            b2[bti].Click += (sender1, ex) => this.DisplayForLoopState();

            lti++;
            bti++;
            tti++;

            Invalidate();
        }

        private void DisplayForLoopState()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(pins, qins);
            l2[lti].Size = new Size(75, 20);
            //lp.BackColor = Color.Red;
            l2[lti].Text = t2[z].Text;

            P[c1] = lti;

            code[cc] = "    " + t2[z].Text + ";\n    }";
            codeC[cc] = "    " + t2[z].Text + ";\n    }";
            cc++;

            //Console.WriteLine(c1);
            //Console.WriteLine(lti);
            //Console.WriteLine(P[pp]);
            //Console.WriteLine("I Got LoopState");

            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            lti++;

            l2[x].Dispose();
            t2[z].Dispose();
            b2[y].Dispose();

            Invalidate();
        }

        private void DisplayPrintVar()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(p, q);
            l2[lti].Size = new Size(60, 20);
            l2[lti].Text = t[z].Text;
            P[pp] = lti;

            code[cc] = @"printf(""%d""," + t[z].Text + ");";
            codeC[cc] = @"printf(""%d""," + t[z].Text + ");";
            cc++;

            //Console.WriteLine(pp);
            //Console.WriteLine(lti);
            //Console.WriteLine(P[pp]);
            //Console.WriteLine("I Got Print");
            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l[x].Dispose();
            b[y].Dispose();
            t[z].Dispose();

            lti++;

            Invalidate();
        }

        private void DisplayReadVar()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(p, q);
            l2[lti].Size = new Size(60, 20);
            l2[lti].Text = t[z].Text;
            P[pp] = lti;

            code[cc] = @"scanf(""%d""," + "&&" + t[z].Text + ");";
            codeC[cc] = @"scanf(""%d""," + "&" + t[z].Text + ");";
            cc++;

            //Console.WriteLine(pp);
            //Console.WriteLine(lti);
            //Console.WriteLine(P[pp]);
            //Console.WriteLine("I Got Scan");
            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l[x].Dispose();
            b[y].Dispose();
            t[z].Dispose();

            lti++;

            Invalidate();
        }

        private void DisplayProcess()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(p, q);
            l2[lti].Size = new Size(60, 20);
            l2[lti].Text = t[z].Text;
            P[pp] = lti;

            code[cc] = t[z].Text + " ;";
            codeC[cc] = t[z].Text + " ;";
            cc++;

            /*Console.WriteLine(pp);
            Console.WriteLine(lti);
            Console.WriteLine(P[pp]);
            Console.WriteLine("I Got Process");*/
            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l[x].Dispose();
            b[y].Dispose();
            t[z].Dispose();

            lti++;

            Invalidate();
        }

        private void DisplayTakeVar()
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(p, q);
            l2[lti].Size = new Size(60, 20);
            l2[lti].Text = t[z].Text;
            P[pp] = lti;

            code[cc] = "int " + t[z].Text + " ;" ;
            codeC[cc] = "int " + t[z].Text + " ;";
            cc++;

            //Console.WriteLine(pp);
            //Console.WriteLine(lti);
            //Console.WriteLine(P[pp]);
            //Console.WriteLine("I Got TakeVar");
            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            Controls.Add(l2[lti]);

            l[x].Dispose();
            b[y].Dispose();
            t[z].Dispose();

            lti++;

            Invalidate();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(350, 200);
            l2[lti].Size = new Size(300, 100);
            l2[lti].BackColor = Color.Bisque;
            l2[lti].Text = "Edit in no.?";
            l2[lti].Font = new Font("Ariel", 12);

            t2[tti] = new TextBox();
            t2[tti].Location = new Point(380, 250);
            t2[tti].BackColor = Color.AntiqueWhite;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(580, 255);
            b2[bti].Size = new System.Drawing.Size(35, 20);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Ok";

            Controls.Add(b2[bti]);
            Controls.Add(t2[tti]);
            Controls.Add(l2[lti]);

            x = lti;
            y = bti;
            z = tti;

            b2[bti].Click += (sender1, ex) => this.DisplayEditWith();

            lti++;
            bti++;
            tti++;

            Invalidate();
        }

        private void DisplayEditWith()
        {
            index = Int32.Parse(t2[z].Text);

            l2[lti] = new Label();
            l2[lti].Location = new Point(350, 200);
            l2[lti].Size = new Size(300, 100);
            l2[lti].BackColor = Color.Bisque;
            l2[lti].Text = "Replace with?";
            l2[lti].Font = new Font("Ariel", 12);

            t2[tti] = new TextBox();
            t2[tti].Location = new Point(380, 250);
            t2[tti].BackColor = Color.AntiqueWhite;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(580, 255);
            b2[bti].Size = new System.Drawing.Size(35, 20);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Ok";

            l2[x].Dispose();
            t2[z].Dispose();
            b2[y].Dispose();

            Controls.Add(b2[bti]);
            Controls.Add(t2[tti]);
            Controls.Add(l2[lti]);

            x = lti;
            y = bti;
            z = tti;

            b2[bti].Click += (sender1, ex) => this.DisplayReplaceWith();

            lti++;
            bti++;
            tti++;

            Invalidate();
        }

        private void DisplayReplaceWith()
        {
            /*l2[lti] = new Label();
            l2[lti].Location = new Point(X[index], Y[index]);
            l2[lti].Size = new Size(W[index], H[index]);
            l2[lti].Text = t2[z].Text;
            l2[lti].Font = new Font("Arial", 12);
            l2[lti].ForeColor = Color.Black;
            l2[lti].BackColor = Color.Red;
            Controls.Add(l2[lti]);*/

            int k = P[index];

            l2[k].Text = t2[z].Text;
            Refresh();

            string wx = t2[z].Text;

            //Console.WriteLine("index = "+index);
            //Console.WriteLine("k = "+k);
            //Console.WriteLine("temp = "+temp);
            //Console.WriteLine("rr = "+rr);
            //Console.WriteLine(P[index]);

            //Console.WriteLine("index = " + index);
            //Console.WriteLine("k = " + k);
            //Console.WriteLine("temp1 = " + temp1);
            //Console.WriteLine("rr = " + rr);
            //Console.WriteLine(P[index]);

            /*Console.WriteLine(index);
            Console.WriteLine(k);
            Console.WriteLine(l2[k]);
            Console.WriteLine(fc);
            Console.WriteLine(pp);
            Console.WriteLine(lti);

            Console.WriteLine("\n");
            Console.WriteLine(P[4]);
            Console.WriteLine(P[5]);
            Console.WriteLine("\n");

            for (int zzz = 1; zzz <= pp; zzz++)
                Console.WriteLine(P[zzz]);*/

            l2[x].Dispose();
            b2[y].Dispose();
            t2[z].Dispose();

            lti++;

            if(fcn[index]=="process")
            {
                code[index] = wx + ";";
                codeC[index] = wx + ";";
            }

            else if (fcn[index] == "tVar")
            {
                code[index] = "int " + wx + " ;";
                codeC[index] = "int " + wx + " ;";
            }

            else if (fcn[index] == "rVar")
            {
                code[index] = @"scanf(""%d""," + "&&" + wx + ");";
                codeC[index] = @"scanf(""%d""," + "&" + wx + ");";
            }

            else if (fcn[index] == "pVar")
            {
                code[index] = @"printf(""%d""," + wx + ");";
                codeC[index] = @"printf(""%d""," + wx + ");";
            }

            else if (fcn[index] == "condition")
            {
                code[index] = "if(" + wx + ")\n    {";
                codeC[index] = "if(" + wx + ")\n    {";
            }

            else if (fcn[index] == "conditionT")
            {
                code[index] = "    " + wx + ";\n    }";
                codeC[index] = "    " + wx + ";\n    }";
            }

            else if (fcn[index] == "conditionF")
            {
                code[index] = "else\n    {\n        " + wx + ";\n    }";
                codeC[index] = "else\n    {\n        " + wx + ";\n    }";
            }

            else if (fcn[index] == "loopIn")
            {
                code[index] = "for(" + wx + ";" + sss[1] + ";" + sss[2] + ")\n    {";
                codeC[index] = "for(" + wx + ";" + sss[1] + ";" + sss[2] + ")\n    {";
                sss[0] = wx;
            }

          

            else if (fcn[index] == "loopCon")
            {
                code[index-1] = "for(" + sss[0] + ";" + wx + ";" + sss[2] + ")\n    {";
                codeC[index-1] = "for(" + sss[0] + ";" + wx + ";" + sss[2] + ")\n    {";
                sss[1] = wx;
            }


            else if (fcn[index] == "loopID")
            {
                code[index-2] = "for(" + sss[0] + ";" + sss[1] + ";" + wx + ")\n    {";
                codeC[index-2] = "for(" + sss[0] + ";" + sss[1] + ";" + wx + ")\n    {";
                sss[2] = wx;
            }


            else if (fcn[index] == "loopState")
            {
                code[index] = "    " + wx + ";\n    }";
                codeC[index] = "    " + wx + ";\n    }";
            }

            Invalidate();
        }


        private void viewCode_Click(object sender, EventArgs e)
        {
            l2[lti] = new Label();
            l2[lti].Location = new Point(175, 30);
            l2[lti].Size = new Size(400, 500);
            l2[lti].BackColor = Color.Bisque;

            codeField = lti;

            //l2[lti].Text = for(int zz=0;zz<cc;zz++)

            for(int zz=1;zz<cc;zz++)
            {
                if (zz == 1)
                    l2[lti].Text += code[zz] + "\n";
                else if (code[zz] == "-1")
                    continue;
                else
                    l2[lti].Text += "    " + code[zz] + "\n";
            }
            l2[lti].Font = new Font("Ariel", 16);

            x = lti;
            y = bti;

            
            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(500, 480);
            b2[bti].Size = new System.Drawing.Size(55, 25);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Close";

            y = bti;
            Controls.Add(b2[y]);

            b2[bti].Click += (sender1, ex) => this.DisplayCloseTab();

            bti++;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(435, 480);
            b2[bti].Size = new System.Drawing.Size(55, 25);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Save";

            z = bti;
            x = lti;
            Controls.Add(b2[z]);
            Controls.Add(l2[x]);

            b2[bti].Click += (sender1, ex) => this.DisplaySave();

            bti++;
            lti++;

            Invalidate();
        }

        private void DisplaySave()
        {

            l2[lti] = new Label();
            l2[lti].Location = new Point(350, 200);
            l2[lti].Size = new Size(300, 100);
            l2[lti].BackColor = Color.Bisque;
            l2[lti].Text = "File save as..";
            l2[lti].Font = new Font("Ariel", 12);

            t2[tti] = new TextBox();
            t2[tti].Location = new Point(380, 250);
            t2[tti].BackColor = Color.AntiqueWhite;

            b2[bti] = new Button();
            b2[bti].Parent = this;
            b2[bti].Location = new System.Drawing.Point(580, 255);
            b2[bti].Size = new System.Drawing.Size(35, 20);
            b2[bti].Name = "New_bs";
            b2[bti].Text = "Ok";

            b2[bti].Click += (sender1, ex) => this.SaveInfo();

            Controls.Add(b2[bti]);
            Controls.Add(t2[tti]);
            Controls.Add(l2[lti]);

            l2[x].Dispose();
            b2[y].Dispose();
            b2[z].Dispose();
            

            x = lti;
            y = bti;
            z = tti;
            

            Invalidate();
        }

        private void SaveInfo()
        {
            if (File.Exists("F:\\3-1\\New SS\\Graphics_Test\\"+t2[z].Text+".c"))
            {
                MessageBox.Show("File already exists");
            }
            else
            {
                StreamWriter sw = new StreamWriter("F:\\3-1\\New SS\\Graphics_Test\\" + t2[z].Text + ".c");

                //sw.WriteLine("Hello World!");

                for (int zz = 1; zz < cc; zz++)
                {
                    if (zz == 1)
                        sw.WriteLine(codeC[zz]);
                    //l2[lti].Text += code[zz] + "\n";
                    else if (codeC[zz] == "-1")
                        continue;
                    else
                        sw.WriteLine("    " + codeC[zz]);
                        //l2[lti].Text += "    " + code[zz] + "\n";
                    //sw.WriteLine(l2[codeField].Text);
                }
                //sw.WriteLine(l2[codeField].Text);
                sw.Close();
            }

            l2[x].Dispose();
            b2[y].Dispose();
            t2[z].Dispose();

            Invalidate();

        }

        private void DisplayCloseTab()
        {
            l2[x].Dispose();
            b2[y].Dispose();
            b2[z].Dispose();

            Invalidate();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }



        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }


        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;

            foreach (Point p in pointsCircle)
            {
                gp.DrawEllipse(new Pen(Color.Black, 2), p.X, p.Y, 120, 50);
                // MessageBox.Show(p.ToString());
                // MessageBox.Show(p.ToString());
            }

            foreach(Point p in pointsECircle)
            {
                using (var pp = new Pen(Color.Black, 2))
                {
                    int sx = p.X;
                    int sy = p.Y;
                    int ex = p.X;
                    int ey = p.Y + 30;
                    Point p1 = new Point(sx, sy);
                    Point p2 = new Point(ex, ey);
                    gp.DrawLine(pp, p1, p2);

                    Point p3 = new Point(p.X, p.Y + 30);
                    Point p4 = new Point(p.X - 10, p.Y + 25);
                    gp.DrawLine(pp, p3, p4);

                    Point p5 = new Point(p.X, p.Y + 30);
                    Point p6 = new Point(p.X + 10, p.Y + 25);
                    gp.DrawLine(pp, p5, p6);
                    //MessageBox.Show(p.ToString());
                }
                gp.DrawEllipse(new Pen(Color.Black, 2), p.X-60, p.Y+31, 120, 50);
            }

            foreach (Point p in pointsRect)
            {

                using (var pp = new Pen(Color.Black, 2))
                {
                    int sx = p.X;
                    int sy = p.Y;
                    int ex = p.X;
                    int ey = p.Y + 30;
                    Point p1 = new Point(sx, sy);
                    Point p2 = new Point(ex, ey);
                    gp.DrawLine(pp, p1, p2);

                    Point p3 = new Point(p.X, p.Y+30);
                    Point p4 = new Point(p.X-10, p.Y+25);
                    gp.DrawLine(pp, p3, p4);

                    Point p5 = new Point(p.X, p.Y+30);
                    Point p6 = new Point(p.X + 10, p.Y + 25);
                    gp.DrawLine(pp, p5, p6);
                    //MessageBox.Show(p.ToString());
                }
                gp.DrawRectangle(new Pen(Color.Black, 2), p.X - 60, p.Y+32, 120, 50);
               // MessageBox.Show(p.ToString());
            }

            foreach (Point p in pointsConnect)
            {
               using (var pp = new Pen(Color.Black, 4))
               {
                    int sx = p.X;
                    int sy = p.Y;
                    int ex = p.X;
                    int ey = p.Y + 60;
                    Point p1 = new Point(sx, sy);
                    Point p2 = new Point(ex, ey);
                    gp.DrawLine(pp, p1, p2);
                    //MessageBox.Show(p.ToString());
                }
            }

            foreach(Point p in pointsPargram)
            {
                using (var pp = new Pen(Color.Black, 2))
                {
                    int sx = p.X;
                    int sy = p.Y;
                    int ex = p.X;
                    int ey = p.Y + 30;
                    Point p1 = new Point(sx, sy);
                    Point p2 = new Point(ex, ey);
                    gp.DrawLine(pp, p1, p2);

                    Point p3 = new Point(p.X, p.Y + 30);
                    Point p4 = new Point(p.X - 10, p.Y + 25);
                    gp.DrawLine(pp, p3, p4);

                    Point p5 = new Point(p.X, p.Y + 30);
                    Point p6 = new Point(p.X + 10, p.Y + 25);
                    gp.DrawLine(pp, p5, p6);
                    //MessageBox.Show(p.ToString());
                }
                gp.DrawLine(new Pen(Color.Black, 2), new Point(p.X - 60, p.Y + 32), new Point(p.X + 60, p.Y + 32));
                gp.DrawLine(new Pen(Color.Black, 2), new Point(p.X - 60, p.Y + 32), new Point(p.X - 70, p.Y + 75));
                gp.DrawLine(new Pen(Color.Black, 2), new Point(p.X - 70, p.Y + 75), new Point(p.X + 50, p.Y + 75));
                gp.DrawLine(new Pen(Color.Black, 2), new Point(p.X + 50, p.Y + 75), new Point(p.X + 60, p.Y + 32));

            }

            foreach (Point p in pointsCondition)
            {
                using (var pp = new Pen(Color.Black, 2))
                {
                    int sx = p.X;
                    int sy = p.Y;
                    int ex = p.X;
                    int ey = p.Y + 30;
                    Point p1 = new Point(sx, sy);
                    Point p2 = new Point(ex, ey);
                    gp.DrawLine(pp, p1, p2);

                    Point p3 = new Point(p.X, p.Y + 30);
                    Point p4 = new Point(p.X - 10, p.Y + 25);
                    gp.DrawLine(pp, p3, p4);

                    Point p5 = new Point(p.X, p.Y + 30);
                    Point p6 = new Point(p.X + 10, p.Y + 25);
                    gp.DrawLine(pp, p5, p6);
                    //MessageBox.Show(p.ToString());
                    gp.DrawLine(pp, new Point(p.X, p.Y + 30), new Point(p.X - 70, p.Y + 100));
                    gp.DrawLine(pp, new Point(p.X - 70, p.Y + 100), new Point(p.X, p.Y + 170));
                    gp.DrawLine(pp, new Point(p.X, p.Y + 170), new Point(p.X + 70, p.Y + 100));
                    gp.DrawLine(pp, new Point(p.X + 70, p.Y + 100), new Point(p.X, p.Y + 30));
                    gp.DrawLine(pp, new Point(p.X - 70, p.Y + 100), new Point(p.X - 120, p.Y + 100));
                    gp.DrawLine(pp, new Point(p.X + 70, p.Y + 100), new Point(p.X + 120, p.Y + 100));
                    gp.DrawLine(pp, new Point(p.X - 120, p.Y + 100), new Point(p.X - 120, p.Y + 170));
                    gp.DrawLine(pp, new Point(p.X + 120, p.Y + 100), new Point(p.X + 120, p.Y + 170));
                    gp.DrawRectangle(pp, p.X - 155, p.Y + 170, 70, 40);
                    gp.DrawRectangle(pp, p.X + 85, p.Y + 170, 70, 40);
                    gp.DrawLine(pp, new Point(p.X - 120, p.Y + 210), new Point(p.X - 120, p.Y + 260));
                    gp.DrawLine(pp, new Point(p.X + 120, p.Y + 210), new Point(p.X + 120, p.Y + 260));
                    gp.DrawLine(pp, new Point(p.X - 120, p.Y + 260), new Point(p.X + 120, p.Y + 260));
                }
            }

            foreach (Point p in pointsForLoop)
            {
                using (var pp = new Pen(Color.Black, 2))
                {
                    int sx = p.X;
                    int sy = p.Y;
                    int ex = p.X;
                    int ey = p.Y + 30;
                    Point p1 = new Point(sx, sy);
                    Point p2 = new Point(ex, ey);
                    gp.DrawLine(pp, p1, p2);

                    gp.DrawRectangle(pp, p.X - 40, p.Y + 30, 80, 40);

                    gp.DrawLine(pp, new Point(p.X, p.Y + 70), new Point(p.X, p.Y + 100));

                    gp.DrawLine(pp, new Point(p.X, p.Y + 100), new Point(p.X - 70, p.Y + 170));
                    gp.DrawLine(pp, new Point(p.X-70, p.Y + 170), new Point(p.X, p.Y + 240));
                    gp.DrawLine(pp, new Point(p.X, p.Y + 240), new Point(p.X + 70, p.Y + 170));
                    gp.DrawLine(pp, new Point(p.X + 70, p.Y + 170), new Point(p.X, p.Y + 100));

                    gp.DrawLine(pp, new Point(p.X, p.Y + 240), new Point(p.X, p.Y + 270));

                    gp.DrawRectangle(pp, p.X - 50, p.Y + 270, 100, 40);

                    gp.DrawLine(pp, new Point(p.X - 50, p.Y + 290), new Point(p.X - 90, p.Y + 290));
                    gp.DrawLine(pp, new Point(p.X - 90, p.Y + 290), new Point(p.X - 90, p.Y + 250));
                    gp.DrawRectangle(pp, p.X - 120, p.Y + 210, 60, 40);
                    gp.DrawLine(pp, new Point(p.X-90, p.Y + 210), new Point(p.X - 90, p.Y + 170));
                    gp.DrawLine(pp, new Point(p.X-90, p.Y + 170), new Point(p.X - 70, p.Y + 170));

                    gp.DrawLine(pp, new Point(p.X + 70, p.Y + 170), new Point(p.X + 90, p.Y + 170));
                    gp.DrawLine(pp, new Point(p.X + 90, p.Y + 170), new Point(p.X + 90, p.Y + 310));
                }
            }
        }
    }
}
