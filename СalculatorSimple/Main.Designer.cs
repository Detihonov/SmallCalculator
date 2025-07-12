namespace СalculatorSimple
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRun = new Button();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            selectAction = new ComboBox();
            label3 = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRun.Location = new Point(12, 120);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(339, 29);
            btnRun.TabIndex = 0;
            btnRun.Text = "Выполнить";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Location = new Point(12, 12);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(155, 23);
            txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new Point(12, 41);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(155, 23);
            txtSecondNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(173, 14);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 2;
            label1.Text = "Первое число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(173, 43);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 2;
            label2.Text = "Второе число";
            // 
            // selectAction
            // 
            selectAction.FormattingEnabled = true;
            selectAction.Location = new Point(12, 70);
            selectAction.Name = "selectAction";
            selectAction.Size = new Size(155, 23);
            selectAction.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(173, 72);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 2;
            label3.Text = "Выбрать действие";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(12, 96);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(83, 21);
            labelResult.TabIndex = 4;
            labelResult.Text = "Результат:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 163);
            Controls.Add(labelResult);
            Controls.Add(selectAction);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(btnRun);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Label label1;
        private Label label2;
        private ComboBox selectAction;
        private Label label3;
        private Label labelResult;
    }
}
