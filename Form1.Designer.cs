namespace светофор {
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
            if(disposing && (components != null)) {
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
            components = new System.ComponentModel.Container();
            StartButton = new Button();
            StopBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.ForeColor = SystemColors.ControlText;
            StartButton.Location = new Point(576, 47);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(169, 63);
            StartButton.TabIndex = 0;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopBtn
            // 
            StopBtn.ForeColor = SystemColors.ControlText;
            StopBtn.Location = new Point(576, 136);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(169, 63);
            StopBtn.TabIndex = 1;
            StopBtn.Text = "Стоп";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // timer1
            // 
            timer1.Tick += Changer;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(620, 226);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(StopBtn);
            Controls.Add(StartButton);
            Name = "Form1";
            Text = "Form1";
            Paint += TrafficlightCreater;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button StopBtn;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
