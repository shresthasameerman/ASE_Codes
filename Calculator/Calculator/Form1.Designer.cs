namespace Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(320, 44);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNegate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPercent, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDiv, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMul, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSub, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimal, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 396);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.TabIndex = 1;
            this.btnNegate.Text = "\u00B1";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.Negate_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.TabIndex = 2;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "\u00F7";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn7.Name = "btn7";
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn8.Name = "btn8";
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn9.Name = "btn9";
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btnMul
            // 
            this.btnMul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMul.Name = "btnMul";
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "\u00D7";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn4.Name = "btn4";
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn5.Name = "btn5";
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn6.Name = "btn6";
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btnSub
            // 
            this.btnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSub.Name = "btnSub";
            this.btnSub.TabIndex = 11;
            this.btnSub.Text = "\u2212";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn1.Name = "btn1";
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn2.Name = "btn2";
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn3.Name = "btn3";
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn0
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn0, 2);
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn0.Name = "btn0";
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.TabIndex = 18;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
    }
}