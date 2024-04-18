namespace Hajózás
{
    partial class FormÚjKérdés
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            kérdésBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)kérdésBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", kérdésBindingSource, "Szam", true));
            textBox1.Location = new Point(125, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(567, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", kérdésBindingSource, "Kerdes", true));
            textBox2.Location = new Point(125, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(567, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", kérdésBindingSource, "V2", true));
            textBox3.Location = new Point(125, 409);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(567, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", kérdésBindingSource, "V1", true));
            textBox4.Location = new Point(125, 306);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(567, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", kérdésBindingSource, "V3", true));
            textBox5.Location = new Point(125, 507);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(567, 39);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", kérdésBindingSource, "Kep", true));
            textBox6.Location = new Point(125, 612);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(567, 39);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", kérdésBindingSource, "HelyesValasz", true));
            textBox7.Location = new Point(125, 706);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(567, 39);
            textBox7.TabIndex = 6;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(739, 800);
            button1.Name = "button1";
            button1.Size = new Size(191, 59);
            button1.TabIndex = 7;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(480, 800);
            button2.Name = "button2";
            button2.Size = new Size(191, 59);
            button2.TabIndex = 8;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 50);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 9;
            label1.Text = "Szám";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 160);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 10;
            label2.Text = "Kérdés";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 460);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 11;
            label3.Text = "V3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 364);
            label4.Name = "label4";
            label4.Size = new Size(42, 32);
            label4.TabIndex = 12;
            label4.Text = "V2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 271);
            label5.Name = "label5";
            label5.Size = new Size(42, 32);
            label5.TabIndex = 13;
            label5.Text = "V1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 654);
            label6.Name = "label6";
            label6.Size = new Size(177, 32);
            label6.TabIndex = 14;
            label6.Text = "Helyes v száma";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 566);
            label7.Name = "label7";
            label7.Size = new Size(55, 32);
            label7.TabIndex = 15;
            label7.Text = "Kép";
            // 
            // kérdésBindingSource
            // 
            kérdésBindingSource.DataSource = typeof(Kérdés);
            // 
            // FormÚjKérdés
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 909);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormÚjKérdés";
            Text = "FormÚjKérdés";
            ((System.ComponentModel.ISupportInitialize)kérdésBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private BindingSource kérdésBindingSource;
    }
}