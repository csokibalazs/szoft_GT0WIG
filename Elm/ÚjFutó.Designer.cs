﻿namespace Elm
{
    partial class FormÚjFutó
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            futókBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)futókBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(641, 755);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(474, 755);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futókBindingSource, "Nev", true));
            textBox1.Location = new Point(161, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", futókBindingSource, "Nemzetiseg", true));
            textBox2.Location = new Point(161, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(415, 39);
            textBox2.TabIndex = 3;
            // 
            // futókBindingSource
            // 
            futókBindingSource.DataSource = typeof(Futók);
            // 
            // ÚjFutó
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 836);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ÚjFutó";
            Text = "Form2";
            Load += this.ÚjFutó_Load;
            ((System.ComponentModel.ISupportInitialize)futókBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private BindingSource futókBindingSource;
    }
}