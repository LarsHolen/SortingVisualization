﻿
namespace SortingVisualization
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonBubbleSort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.ButtonSelectionSort = new System.Windows.Forms.Button();
            this.ButtonInsertSort = new System.Windows.Forms.Button();
            this.ButtonquickSort = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(347, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Location = new System.Drawing.Point(13, 12);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(134, 23);
            this.ButtonBubbleSort.TabIndex = 1;
            this.ButtonBubbleSort.Text = "BubbleSort";
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            this.ButtonBubbleSort.Click += new System.EventHandler(this.ButtonBubbleSort_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Faster(-10 ms)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonFast_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reset (25ms)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonMedium_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Slower(+10ms)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonSlow_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 23);
            this.textBox1.TabIndex = 3;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(13, 388);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomize.TabIndex = 4;
            this.buttonRandomize.Text = "Restart";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.ButtonRandomize_Click);
            // 
            // ButtonSelectionSort
            // 
            this.ButtonSelectionSort.Location = new System.Drawing.Point(13, 41);
            this.ButtonSelectionSort.Name = "ButtonSelectionSort";
            this.ButtonSelectionSort.Size = new System.Drawing.Size(134, 23);
            this.ButtonSelectionSort.TabIndex = 1;
            this.ButtonSelectionSort.Text = "SelectionSort";
            this.ButtonSelectionSort.UseVisualStyleBackColor = true;
            this.ButtonSelectionSort.Click += new System.EventHandler(this.ButtonSelectionSort_Click);
            // 
            // ButtonInsertSort
            // 
            this.ButtonInsertSort.Location = new System.Drawing.Point(13, 70);
            this.ButtonInsertSort.Name = "ButtonInsertSort";
            this.ButtonInsertSort.Size = new System.Drawing.Size(134, 23);
            this.ButtonInsertSort.TabIndex = 1;
            this.ButtonInsertSort.Text = "InsertSort";
            this.ButtonInsertSort.UseVisualStyleBackColor = true;
            this.ButtonInsertSort.Click += new System.EventHandler(this.ButtonInsertSort_Click);
            // 
            // ButtonquickSort
            // 
            this.ButtonquickSort.Location = new System.Drawing.Point(12, 99);
            this.ButtonquickSort.Name = "ButtonquickSort";
            this.ButtonquickSort.Size = new System.Drawing.Size(134, 23);
            this.ButtonquickSort.TabIndex = 1;
            this.ButtonquickSort.Text = "QuickSort";
            this.ButtonquickSort.UseVisualStyleBackColor = true;
            this.ButtonquickSort.Click += new System.EventHandler(this.ButtonQuickSort_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(234, 130);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 19);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Draw lines";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.RadioButtonDrawLines_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(234, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 19);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Draw points";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.RadioButtonDrawPoints_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonquickSort);
            this.Controls.Add(this.ButtonInsertSort);
            this.Controls.Add(this.ButtonSelectionSort);
            this.Controls.Add(this.ButtonBubbleSort);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonBubbleSort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button ButtonSelectionSort;
        private System.Windows.Forms.Button ButtonInsertSort;
        private System.Windows.Forms.Button ButtonquickSort;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

