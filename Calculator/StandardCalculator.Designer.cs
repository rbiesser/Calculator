namespace Calculator
{
    partial class StandardCalculator
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.pHistory = new System.Windows.Forms.Panel();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.lvHistory = new System.Windows.Forms.ListView();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblOperand = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOperation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Calculator.Properties.Resources.ecpi_moorefield;
            this.pbLogo.Location = new System.Drawing.Point(18, 20);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(584, 98);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(18, 424);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(123, 62);
            this.btn1.TabIndex = 1;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pHistory
            // 
            this.pHistory.Controls.Add(this.btnClearHistory);
            this.pHistory.Controls.Add(this.lvHistory);
            this.pHistory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHistory.Location = new System.Drawing.Point(526, 112);
            this.pHistory.Name = "pHistory";
            this.pHistory.Size = new System.Drawing.Size(346, 442);
            this.pHistory.TabIndex = 2;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(256, 404);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 23);
            this.btnClearHistory.TabIndex = 3;
            this.btnClearHistory.Text = "clear";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // lvHistory
            // 
            this.lvHistory.FullRowSelect = true;
            this.lvHistory.HideSelection = false;
            this.lvHistory.Location = new System.Drawing.Point(13, 11);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(318, 383);
            this.lvHistory.TabIndex = 2;
            this.lvHistory.TabStop = false;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.List;
            this.lvHistory.Click += new System.EventHandler(this.lvHistory_Click);
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemory.Location = new System.Drawing.Point(712, 48);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(105, 32);
            this.lblMemory.TabIndex = 1;
            this.lblMemory.Text = "Memory";
            this.lblMemory.Click += new System.EventHandler(this.lblMemory_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(552, 48);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(90, 32);
            this.lblHistory.TabIndex = 0;
            this.lblHistory.Text = "History";
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // lblOperand
            // 
            this.lblOperand.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand.Location = new System.Drawing.Point(15, 135);
            this.lblOperand.Name = "lblOperand";
            this.lblOperand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOperand.Size = new System.Drawing.Size(490, 82);
            this.lblOperand.TabIndex = 3;
            this.lblOperand.Text = "0";
            this.lblOperand.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(276, 424);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(123, 62);
            this.btn3.TabIndex = 4;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(147, 424);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(123, 62);
            this.btn2.TabIndex = 5;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(147, 356);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(123, 62);
            this.btn5.TabIndex = 8;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(276, 356);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(123, 62);
            this.btn6.TabIndex = 7;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(18, 356);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(123, 62);
            this.btn4.TabIndex = 6;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(147, 288);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(123, 62);
            this.btn8.TabIndex = 11;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(276, 288);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(123, 62);
            this.btn9.TabIndex = 10;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(18, 288);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(123, 62);
            this.btn7.TabIndex = 9;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(18, 492);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(252, 62);
            this.btn0.TabIndex = 14;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.Location = new System.Drawing.Point(276, 492);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(123, 62);
            this.btnPeriod.TabIndex = 13;
            this.btnPeriod.TabStop = false;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.Location = new System.Drawing.Point(147, 220);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(123, 62);
            this.btnPlusMinus.TabIndex = 12;
            this.btnPlusMinus.TabStop = false;
            this.btnPlusMinus.Text = "pm";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(405, 424);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(103, 130);
            this.btnEquals.TabIndex = 15;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(405, 288);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(103, 62);
            this.btnSubtract.TabIndex = 19;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "sub";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(405, 220);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(103, 62);
            this.btnMultiply.TabIndex = 18;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "mul";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(276, 220);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(123, 62);
            this.btnDivide.TabIndex = 17;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "div";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(405, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 62);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(18, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 62);
            this.btnClear.TabIndex = 21;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(15, 112);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOperation.Size = new System.Drawing.Size(490, 23);
            this.lblOperation.TabIndex = 22;
            this.lblOperation.Text = "lblOperation";
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StandardCalculator
            // 
            this.AcceptButton = this.btnEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(884, 573);
            this.Controls.Add(this.pHistory);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.lblOperand);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StandardCalculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StandardCalculator_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblOperand;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.ListView lvHistory;


        private bool isNewOperation = true;
        private bool isNewOperand = true;
    }
}

