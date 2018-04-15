namespace Moore_And_Mealy_Makiesi
{
    partial class Mealy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.info_lbl = new System.Windows.Forms.Label();
            this.OutputsTxb = new System.Windows.Forms.TextBox();
            this.AlphabetTxb = new System.Windows.Forms.TextBox();
            this.StatesTxb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_run = new System.Windows.Forms.Panel();
            this.run_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.input_txb = new System.Windows.Forms.TextBox();
            this.outputsResult_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statesResult_lbl = new System.Windows.Forms.Label();
            this.MealyTable = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnl_run.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.info_lbl);
            this.panel2.Controls.Add(this.OutputsTxb);
            this.panel2.Controls.Add(this.AlphabetTxb);
            this.panel2.Controls.Add(this.StatesTxb);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(59, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 222);
            this.panel2.TabIndex = 4;
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.ForeColor = System.Drawing.Color.Red;
            this.info_lbl.Location = new System.Drawing.Point(10, 199);
            this.info_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(14, 20);
            this.info_lbl.TabIndex = 7;
            this.info_lbl.Text = "-";
            // 
            // OutputsTxb
            // 
            this.OutputsTxb.Location = new System.Drawing.Point(74, 90);
            this.OutputsTxb.Margin = new System.Windows.Forms.Padding(2);
            this.OutputsTxb.Name = "OutputsTxb";
            this.OutputsTxb.Size = new System.Drawing.Size(301, 26);
            this.OutputsTxb.TabIndex = 6;
            // 
            // AlphabetTxb
            // 
            this.AlphabetTxb.Location = new System.Drawing.Point(74, 51);
            this.AlphabetTxb.Margin = new System.Windows.Forms.Padding(2);
            this.AlphabetTxb.Name = "AlphabetTxb";
            this.AlphabetTxb.Size = new System.Drawing.Size(301, 26);
            this.AlphabetTxb.TabIndex = 5;
            // 
            // StatesTxb
            // 
            this.StatesTxb.Location = new System.Drawing.Point(74, 15);
            this.StatesTxb.Margin = new System.Windows.Forms.Padding(2);
            this.StatesTxb.Name = "StatesTxb";
            this.StatesTxb.Size = new System.Drawing.Size(301, 26);
            this.StatesTxb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(111, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Q,£,T for Moore Machine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "T : {                                                                            " +
    "            }";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Q : {                                                                            " +
    "           }";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "£ : {                                                                            " +
    "            }";
            // 
            // pnl_run
            // 
            this.pnl_run.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnl_run.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_run.Controls.Add(this.run_btn);
            this.pnl_run.Controls.Add(this.label4);
            this.pnl_run.Controls.Add(this.input_txb);
            this.pnl_run.Controls.Add(this.outputsResult_lbl);
            this.pnl_run.Controls.Add(this.label5);
            this.pnl_run.Controls.Add(this.label6);
            this.pnl_run.Controls.Add(this.statesResult_lbl);
            this.pnl_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_run.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_run.Location = new System.Drawing.Point(288, 590);
            this.pnl_run.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_run.Name = "pnl_run";
            this.pnl_run.Size = new System.Drawing.Size(1118, 179);
            this.pnl_run.TabIndex = 7;
            this.pnl_run.Visible = false;
            // 
            // run_btn
            // 
            this.run_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.run_btn.Location = new System.Drawing.Point(299, 135);
            this.run_btn.Margin = new System.Windows.Forms.Padding(2);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(128, 30);
            this.run_btn.TabIndex = 6;
            this.run_btn.Text = "RUN";
            this.run_btn.UseVisualStyleBackColor = false;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Input :";
            // 
            // input_txb
            // 
            this.input_txb.Location = new System.Drawing.Point(84, 21);
            this.input_txb.Margin = new System.Windows.Forms.Padding(2);
            this.input_txb.Name = "input_txb";
            this.input_txb.Size = new System.Drawing.Size(304, 26);
            this.input_txb.TabIndex = 7;
            // 
            // outputsResult_lbl
            // 
            this.outputsResult_lbl.AutoSize = true;
            this.outputsResult_lbl.Location = new System.Drawing.Point(84, 98);
            this.outputsResult_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputsResult_lbl.Name = "outputsResult_lbl";
            this.outputsResult_lbl.Size = new System.Drawing.Size(14, 20);
            this.outputsResult_lbl.TabIndex = 11;
            this.outputsResult_lbl.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "States :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Outputs :";
            // 
            // statesResult_lbl
            // 
            this.statesResult_lbl.AutoSize = true;
            this.statesResult_lbl.Location = new System.Drawing.Point(84, 61);
            this.statesResult_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statesResult_lbl.Name = "statesResult_lbl";
            this.statesResult_lbl.Size = new System.Drawing.Size(14, 20);
            this.statesResult_lbl.TabIndex = 10;
            this.statesResult_lbl.Text = "-";
            // 
            // MealyTable
            // 
            this.MealyTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MealyTable.ColumnCount = 1;
            this.MealyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MealyTable.Location = new System.Drawing.Point(520, 65);
            this.MealyTable.Name = "MealyTable";
            this.MealyTable.RowCount = 1;
            this.MealyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MealyTable.Size = new System.Drawing.Size(1074, 464);
            this.MealyTable.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1630, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 67);
            this.button2.TabIndex = 9;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mealy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1731, 803);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MealyTable);
            this.Controls.Add(this.pnl_run);
            this.Controls.Add(this.panel2);
            this.Name = "Mealy";
            this.Text = "Mealy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_run.ResumeLayout(false);
            this.pnl_run.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.TextBox OutputsTxb;
        private System.Windows.Forms.TextBox AlphabetTxb;
        private System.Windows.Forms.TextBox StatesTxb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_run;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_txb;
        private System.Windows.Forms.Label outputsResult_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statesResult_lbl;
        private System.Windows.Forms.TableLayoutPanel MealyTable;
        private System.Windows.Forms.Button button2;
    }
}