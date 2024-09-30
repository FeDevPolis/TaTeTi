namespace WinFormsApp1
{
    partial class Form1
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
            btn1 = new Button();
            btn2 = new Button();            
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn3
            // 
            btn3.Location = new Point(429, 118);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 75);
            btn3.TabIndex = 0;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Button_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(348, 118);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 75);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Button_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(267, 118);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 75);
            btn1.TabIndex = 2;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Button_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(429, 199);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 75);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Button_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(348, 199);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 75);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Button_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(267, 199);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 75);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Button_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(429, 280);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 75);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Button_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(348, 280);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 75);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Button_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(267, 280);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 75);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "TA-TE-TI";
            //
            // Añadir el botón de reinicio
            //
            Button restartButton = new Button();
            restartButton.Text = "Replay";
            restartButton.Location = new Point(600, 100);
            restartButton.Click += (sender, e) => ResetGame();
            Controls.Add(restartButton);
            //
            // Añadir el botón de salida 
            //
            Button exitButton = new Button();
            exitButton.Text = "Exit";
            exitButton.Location = new Point(600, 150);
            exitButton.Click += (sender, e) => ExitGame();
            Controls.Add(exitButton);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Label label1;
    }
}
