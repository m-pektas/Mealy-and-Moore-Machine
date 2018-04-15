using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Moore_And_Mealy_Makiesi
{
    public partial class Moore : Form
    {
       public static String[] states;
       public static String[] alphabet;
       public static String[] outputs;
       public TextBox[,] RelationMatris;
       public List<string> outputList = new List<string>();
       bool isSetQET=false;
       
        public Moore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            info_lbl.Text = "";
            isSetQET = setQET();

            if (isSetQET)
            {
                MooreTable.Visible = true;
                pnl_run.Visible = true;
                setMooreTable();
            }
            else
            {
                info_lbl.Text = "Please, Enter again data carefully..";
            }

        }

        public Boolean setQET()
        {
            if (StatesTxb.Text != "" && AlphabetTxb.Text != "" && OutputsTxb.Text != "")
            {
                states = StatesTxb.Text.Split(',');
                alphabet = AlphabetTxb.Text.Split(',');
                outputs = OutputsTxb.Text.Split(',');
                return true;
            }
            else
                return false;
        }

        public Boolean setMooreTable()
        {
            int columnCount = 2 + alphabet.Count();
            int rowCount = states.Count()+1;
            List<String> MooreHeader = setMooreHeaderList();
            RelationMatris = new TextBox[columnCount,rowCount];

            MooreTable.Controls.Clear();
            MooreTable.ColumnStyles.Clear();
            MooreTable.RowStyles.Clear();
            
            //row and column set
            MooreTable.ColumnCount = columnCount;
            MooreTable.RowCount = rowCount;

            int stateCounter = 0;
            for (int i=0; i < columnCount; i++)
            {
                MooreTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                for (int j = 0; j < rowCount; j++)
                {
                    if (j == 0)
                    {
                            MooreTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                            Label lbl = new Label();
                            lbl.Text = MooreHeader.ElementAt(i);
                            MooreTable.Controls.Add(lbl,i,0);
                    }
                    else
                    {
                        if (i == 0)
                        {
                            Label lbl = new Label();
                            lbl.Text = states[stateCounter];
                            MooreTable.Controls.Add(lbl,0, j);
                            stateCounter++;
                        }
                        else
                        {
                            TextBox txb = new TextBox();
                            txb.Name = (i-1) + "_" + (j-1);
                           // Console.WriteLine(txb.Name);
                            MooreTable.Controls.Add(txb, i, j);
                            RelationMatris[i-1, j - 1] = txb;
                        }
                    }
                }
            }
                return true;
        }

        public List<String> setMooreHeaderList()
        {
            List<String> list = new List<string>();
            list.Add("Old State");
            foreach(var i in alphabet)
            {
                list.Add("After input " + i);
            }
            list.Add("Outputs");

            return list;
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            List<State> stateList = new List<State>();
            for (int i = 0; i < states.Count(); i++)
            {
                State st = new State(states[i]);
                stateList.Add(st);
            }
            
            for (int i=0;i< states.Count(); i++)//ornek : 4
            {
                for (int j = 0; j < alphabet.Count(); j++)//ornek : 2  içeri de =>j,i yaptım ki .. 0,0-1,0-0,1-1,1 gitsin
                {
                    
                        string[] split = RelationMatris[j,i].Name.Split('_');//[0] nereye gideceği [1] ne geldiğinde 
                        string state = states[Convert.ToInt32(split[1])];
                        string input = alphabet[Convert.ToInt32(split[0])];

                        if (stateList.ElementAt(i).Name == state)
                        {
                            State findState = null;
                            foreach (var st in stateList)//sonraki state in hangi state olacagını buluyor
                            {
                                if (st.Name == RelationMatris[j,i].Text) { findState = st; }
                            }

                            if (findState != null)
                                stateList.ElementAt(i).map.Add(input, findState);
                        }
                }
            }

            for(int i = 0; i < stateList.Count; i++)
            {
                stateList.ElementAt(i).output = RelationMatris[alphabet.Count(), i].Text;
            }

            State gecici = stateList.ElementAt(0);
            String inputLine = "  "+gecici.output+"    ";
            String stateLine = "  " + gecici.Name+"    ";
            foreach(var ch in input_txb.Text)
            {
                gecici = gecici.map[ch + ""];
                inputLine += "  - " + gecici.output;
                stateLine += " - " + gecici.Name;
            }
            statesResult_lbl.Text = stateLine;
            outputsResult_lbl.Text = inputLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Hello();
            frm.Show();
            this.Hide();
        }
    }
}
