using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moore_And_Mealy_Makiesi
{
    public partial class Mealy : Form
    {
        public Mealy()
        {
            InitializeComponent();
        }

        public static String[] states;
        public static String[] alphabet;
        public static String[] outputs;
        public TextBox[,] RelationMatris;//new TextBox[alphabet.Count()*2,states.Count()] ornek : a,b - q0,q1,q2 ise [4,3]
        private List<State> stateList;

        private void button1_Click(object sender, EventArgs e)
        {
            info_lbl.Text = "";
            if (setQET())                                               //state, alfabe ve çıktılar dizilerine yerleştirildi
            {
                MealyTable.Visible = true;                              // gerekli toollar görünür yapıldı
                pnl_run.Visible = true;
                setMealyTable();                                        //mealy tablosunu çizer
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

        public List<String> setMealySecondHeaderList()                  //mealy tablosunun başlıklarının 2.satırını ayarlar listeye çevirir
        {
            List<String> list = new List<string>();
            list.Add("Old State");
            foreach (var i in alphabet)
            {
                list.Add("New State ");
                list.Add("Output");
            }
            return list;
        }

        public List<String> setInputHeaderList()                        //mealy tablosuunn en ust başlığını liste olarak ayarlar
        {
            List<String> list = new List<string>();

            foreach (var item in alphabet)
            {
                list.Add("");
                list.Add("After Input " + item);
            }
            return list;
        }

        public Boolean setMealyTable()                                  //uygun mealy tablosunu ekrana çizer
        {
            int columnCount = (alphabet.Count() * 2) + 1;                  //gelen inputlar * onların new state ve outputları + ilk statelerin yazıldığı kolon
            int rowCount = states.Count() + 2;                          //stateler + 2 satır başlık 
            List<String> MealyInputHeader = setInputHeaderList();
            List<String> MealySecondHeader = setMealySecondHeaderList();
            RelationMatris = new TextBox[states.Count(), alphabet.Count() * 2]; // girilen değerleri almak için textbox matrisi

            //table clean
            MealyTable.Controls.Clear();
            MealyTable.ColumnStyles.Clear();
            MealyTable.RowStyles.Clear();

            //row and column set
            MealyTable.ColumnCount = columnCount;
            MealyTable.RowCount = rowCount;



            for (int i = 0; i < rowCount; i++)                                   //alfabenin 2 katı + 1(old state kolonu) kadar  ör : q0,q1,q2 - a,b - 0,1.. = 5  
            {
                MealyTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
                for (int j = 0; j < columnCount; j++)                                  //state sayısı+başlık sayısı kadar dön          ör : 3 + 2 = 5
                {
                    if (i == 0)                                                       //ilk başlık satırı
                    {
                        MealyTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        Label lbl = new Label();
                        if (j < MealyInputHeader.Count)
                            lbl.Text = MealyInputHeader.ElementAt(j);
                        else
                            lbl.Text = "";
                        MealyTable.Controls.Add(lbl, j, i);
                    }
                    else if (i == 1)                                                //ikinci başlık satırı
                    {
                        Label new_lbl = new Label();
                        new_lbl.Text = MealySecondHeader.ElementAt(j);
                        MealyTable.Controls.Add(new_lbl, j, i);
                    }
                    else                                                            //başlık satırlarını geçtiyse
                    {
                        if (j == 0)                                                 //ilk sütuna old stateleri çiz
                        {
                            Label lbl = new Label();
                            if (i <= states.Count() + 2)
                                lbl.Text = states[i - 2];
                            else
                                lbl.Text = "";
                            MealyTable.Controls.Add(lbl, j, i);
                        }
                        else                                                        //text yazılacak yerlerden geriye kalan her yere textbox koy 
                        {
                            TextBox txb = new TextBox();
                            txb.Name = (i - 1) + "_" + (j);
                            //txb.Text = (i - 1) + "-" + (j);
                            MealyTable.Controls.Add(txb);
                            RelationMatris[i - 2, j - 1] = txb;
                        }

                    }
                }
            }
            return true;
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            setStateList();
            setEdgeOfStates();
            showOutput();
        }

        private void showOutput()
        {
            State gecici = stateList.ElementAt(0);
            String outputLine = "";
            String statesLine = "";
            foreach (var item in input_txb.Text)
            {
                outputLine += gecici.edgeMap[item + ""].output+"_";
                statesLine += "| " + gecici.edgeMap[item + ""].OldState.Name + " => " + gecici.edgeMap[item + ""].NewState.Name+"|";
                gecici = gecici.edgeMap[item + ""].NewState;
            }
            statesResult_lbl.Text = statesLine;
            outputsResult_lbl.Text = outputLine;
        }                                   //çıktıları ayarlar

        private void setEdgeOfStates()
        {
            int inputFinder = 0;
            string newState = "";
            for (int i = 0; i < states.Count(); i++)
            {
                for (int j = 0; j < alphabet.Count() * 2; j++)
                {
                    string[] info = RelationMatris[i, j].Name.Split('_');

                    if (Convert.ToInt32(info[1]) % 2 == 0) //output ise
                    {
                        Edge ed = new Edge();
                        ed.OldState = getStateByName(states[i]);
                        ed.NewState = getStateByName(newState);
                        ed.input = alphabet[inputFinder];
                        ed.output = RelationMatris[i, j].Text;
                        stateList.ElementAt(i).edgeMap.Add(ed.input, ed);
                        Console.WriteLine("Old Stade :" + ed.OldState.Name + " New Stade :" + ed.NewState.Name + " input :" + ed.input + " output :" + ed.output);
                        inputFinder++;
                    }
                    else                                //newstate ise
                    {
                        newState = RelationMatris[i, j].Text;
                    }
                }
                inputFinder = 0;
            }

        }                              //statelerin edgelerini ayarlar

        private void setStateList()                                    //alınan string state adlarıyla gerçek stateler olusturur ve listeler
        {
            stateList = new List<State>();
            foreach (var item in states)
            {
                State st = new State(item);
                stateList.Add(st);
            }
        }                                                                   

        private State getStateByName(string name)
        {
            State st = null;
            foreach (var item in this.stateList)
            {
                if (item.Name == name) { st = item; }

            }
            return st;
        }                   //state isminden state in kendisini bulup getirir

        private void button2_Click(object sender, EventArgs e)
        {
            Form hello = new Hello();
            hello.Show();
            this.Hide();
        }
    }
}        