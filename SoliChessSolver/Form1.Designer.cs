namespace SoliChessSolver {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSolve = new Button();
            this.lstResults = new ListBox();
            this.A1 = new ComboBox();
            this.A2 = new ComboBox();
            this.A4 = new ComboBox();
            this.A3 = new ComboBox();
            this.B4 = new ComboBox();
            this.B3 = new ComboBox();
            this.B2 = new ComboBox();
            this.B1 = new ComboBox();
            this.C4 = new ComboBox();
            this.C3 = new ComboBox();
            this.C2 = new ComboBox();
            this.C1 = new ComboBox();
            this.D4 = new ComboBox();
            this.D3 = new ComboBox();
            this.D2 = new ComboBox();
            this.D1 = new ComboBox();
            this.lblHelp = new Label();
            this.btnClear = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new Point(114, 131);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new Size(87, 23);
            this.btnSolve.TabIndex = 0;
            this.btnSolve.Text = "&Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += this.btnSolve_Click;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 15;
            this.lstResults.Location = new Point(205, 4);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new Size(116, 229);
            this.lstResults.TabIndex = 1;
            // 
            // A1
            // 
            this.A1.FormattingEnabled = true;
            this.A1.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.A1.Location = new Point(24, 27);
            this.A1.Name = "A1";
            this.A1.Size = new Size(42, 23);
            this.A1.TabIndex = 2;
            this.A1.Tag = "0;0";
            // 
            // A2
            // 
            this.A2.FormattingEnabled = true;
            this.A2.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.A2.Location = new Point(69, 27);
            this.A2.Name = "A2";
            this.A2.Size = new Size(42, 23);
            this.A2.TabIndex = 3;
            this.A2.Tag = "1;0";
            // 
            // A4
            // 
            this.A4.FormattingEnabled = true;
            this.A4.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.A4.Location = new Point(159, 27);
            this.A4.Name = "A4";
            this.A4.Size = new Size(42, 23);
            this.A4.TabIndex = 5;
            this.A4.Tag = "3;0";
            // 
            // A3
            // 
            this.A3.FormattingEnabled = true;
            this.A3.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.A3.Location = new Point(114, 27);
            this.A3.Name = "A3";
            this.A3.Size = new Size(42, 23);
            this.A3.TabIndex = 4;
            this.A3.Tag = "2;0";
            // 
            // B4
            // 
            this.B4.FormattingEnabled = true;
            this.B4.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.B4.Location = new Point(159, 53);
            this.B4.Name = "B4";
            this.B4.Size = new Size(42, 23);
            this.B4.TabIndex = 9;
            this.B4.Tag = "3;1";
            // 
            // B3
            // 
            this.B3.FormattingEnabled = true;
            this.B3.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.B3.Location = new Point(114, 53);
            this.B3.Name = "B3";
            this.B3.Size = new Size(42, 23);
            this.B3.TabIndex = 8;
            this.B3.Tag = "2;1";
            // 
            // B2
            // 
            this.B2.FormattingEnabled = true;
            this.B2.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.B2.Location = new Point(69, 53);
            this.B2.Name = "B2";
            this.B2.Size = new Size(42, 23);
            this.B2.TabIndex = 7;
            this.B2.Tag = "1;1";
            // 
            // B1
            // 
            this.B1.FormattingEnabled = true;
            this.B1.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.B1.Location = new Point(24, 53);
            this.B1.Name = "B1";
            this.B1.Size = new Size(42, 23);
            this.B1.TabIndex = 6;
            this.B1.Tag = "0;1";
            // 
            // C4
            // 
            this.C4.FormattingEnabled = true;
            this.C4.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.C4.Location = new Point(159, 79);
            this.C4.Name = "C4";
            this.C4.Size = new Size(42, 23);
            this.C4.TabIndex = 13;
            this.C4.Tag = "3;2";
            // 
            // C3
            // 
            this.C3.FormattingEnabled = true;
            this.C3.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.C3.Location = new Point(114, 79);
            this.C3.Name = "C3";
            this.C3.Size = new Size(42, 23);
            this.C3.TabIndex = 12;
            this.C3.Tag = "2;2";
            // 
            // C2
            // 
            this.C2.FormattingEnabled = true;
            this.C2.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.C2.Location = new Point(69, 79);
            this.C2.Name = "C2";
            this.C2.Size = new Size(42, 23);
            this.C2.TabIndex = 11;
            this.C2.Tag = "1;2";
            // 
            // C1
            // 
            this.C1.FormattingEnabled = true;
            this.C1.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.C1.Location = new Point(24, 79);
            this.C1.Name = "C1";
            this.C1.Size = new Size(42, 23);
            this.C1.TabIndex = 10;
            this.C1.Tag = "0;2";
            // 
            // D4
            // 
            this.D4.FormattingEnabled = true;
            this.D4.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.D4.Location = new Point(159, 105);
            this.D4.Name = "D4";
            this.D4.Size = new Size(42, 23);
            this.D4.TabIndex = 17;
            this.D4.Tag = "3;3";
            // 
            // D3
            // 
            this.D3.FormattingEnabled = true;
            this.D3.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.D3.Location = new Point(114, 105);
            this.D3.Name = "D3";
            this.D3.Size = new Size(42, 23);
            this.D3.TabIndex = 16;
            this.D3.Tag = "2;3";
            // 
            // D2
            // 
            this.D2.FormattingEnabled = true;
            this.D2.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.D2.Location = new Point(69, 105);
            this.D2.Name = "D2";
            this.D2.Size = new Size(42, 23);
            this.D2.TabIndex = 15;
            this.D2.Tag = "1;3";
            // 
            // D1
            // 
            this.D1.FormattingEnabled = true;
            this.D1.Items.AddRange(new object[] { "K", "Q", "B", "N", "R", "P" });
            this.D1.Location = new Point(24, 105);
            this.D1.Name = "D1";
            this.D1.Size = new Size(42, 23);
            this.D1.TabIndex = 14;
            this.D1.Tag = "0;3";
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new Font("Segoe UI", 8F);
            this.lblHelp.Location = new Point(4, 157);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new Size(100, 79);
            this.lblHelp.TabIndex = 18;
            this.lblHelp.Text = "K = King\r\nQ = Queen\r\nB = Bishop\r\nN = Knight\r\nR = Rook\r\nP = Pawn";
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(24, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(87, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += this.btnClear_Click;
            // 
            // label1
            // 
            this.label1.Location = new Point(24, 7);
            this.label1.Name = "label1";
            this.label1.Size = new Size(42, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "A";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new Size(14, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "4";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new Size(14, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "3";
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new Size(14, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "2";
            this.label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new Size(14, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "1";
            this.label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new Point(69, 7);
            this.label6.Name = "label6";
            this.label6.Size = new Size(42, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "B";
            this.label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new Point(114, 7);
            this.label7.Name = "label7";
            this.label7.Size = new Size(42, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "C";
            this.label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new Point(159, 7);
            this.label8.Name = "label8";
            this.label8.Size = new Size(42, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "D";
            this.label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(325, 238);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnSolve);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Soli Chess Solver";
            this.ResumeLayout(false);
        }

        #endregion

        private Button btnSolve;
        private ListBox lstResults;
        private ComboBox A1;
        private ComboBox A2;
        private ComboBox A4;
        private ComboBox A3;
        private ComboBox B4;
        private ComboBox B3;
        private ComboBox B2;
        private ComboBox B1;
        private ComboBox C4;
        private ComboBox C3;
        private ComboBox C2;
        private ComboBox C1;
        private ComboBox D4;
        private ComboBox D3;
        private ComboBox D2;
        private ComboBox D1;
        private Label lblHelp;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
