
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ButtonBubbleSort = new System.Windows.Forms.Button();
            ButtonFast = new System.Windows.Forms.Button();
            ButtonReset = new System.Windows.Forms.Button();
            ButtonSlower = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            buttonRandomize = new System.Windows.Forms.Button();
            ButtonSelectionSort = new System.Windows.Forms.Button();
            ButtonInsertSort = new System.Windows.Forms.Button();
            ButtonquickSort = new System.Windows.Forms.Button();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            ButtonMySort = new System.Windows.Forms.Button();
            ButtonMySort2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(644, 26);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(743, 853);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ButtonBubbleSort
            // 
            ButtonBubbleSort.Location = new System.Drawing.Point(24, 26);
            ButtonBubbleSort.Margin = new System.Windows.Forms.Padding(6);
            ButtonBubbleSort.Name = "ButtonBubbleSort";
            ButtonBubbleSort.Size = new System.Drawing.Size(249, 49);
            ButtonBubbleSort.TabIndex = 1;
            ButtonBubbleSort.Text = "BubbleSort";
            ButtonBubbleSort.UseVisualStyleBackColor = true;
            ButtonBubbleSort.Click += ButtonBubbleSort_Click;
            // 
            // ButtonFast
            // 
            ButtonFast.Location = new System.Drawing.Point(444, 26);
            ButtonFast.Margin = new System.Windows.Forms.Padding(6);
            ButtonFast.Name = "ButtonFast";
            ButtonFast.Size = new System.Drawing.Size(167, 49);
            ButtonFast.TabIndex = 2;
            ButtonFast.Text = "Faster(-10 ms)";
            ButtonFast.UseVisualStyleBackColor = true;
            ButtonFast.Click += ButtonFast_Click;
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new System.Drawing.Point(444, 87);
            ButtonReset.Margin = new System.Windows.Forms.Padding(6);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new System.Drawing.Size(167, 49);
            ButtonReset.TabIndex = 2;
            ButtonReset.Text = "Reset (25ms)";
            ButtonReset.UseVisualStyleBackColor = true;
            ButtonReset.Click += ButtonMedium_Click;
            // 
            // ButtonSlower
            // 
            ButtonSlower.Location = new System.Drawing.Point(444, 149);
            ButtonSlower.Margin = new System.Windows.Forms.Padding(6);
            ButtonSlower.Name = "ButtonSlower";
            ButtonSlower.Size = new System.Drawing.Size(167, 49);
            ButtonSlower.TabIndex = 2;
            ButtonSlower.Text = "Slower(+10ms)";
            ButtonSlower.UseVisualStyleBackColor = true;
            ButtonSlower.Click += ButtonSlow_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(444, 213);
            textBox1.Margin = new System.Windows.Forms.Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(164, 39);
            textBox1.TabIndex = 3;
            // 
            // buttonRandomize
            // 
            buttonRandomize.Location = new System.Drawing.Point(24, 828);
            buttonRandomize.Margin = new System.Windows.Forms.Padding(6);
            buttonRandomize.Name = "buttonRandomize";
            buttonRandomize.Size = new System.Drawing.Size(139, 49);
            buttonRandomize.TabIndex = 4;
            buttonRandomize.Text = "Restart";
            buttonRandomize.UseVisualStyleBackColor = true;
            buttonRandomize.Click += ButtonRandomize_Click;
            // 
            // ButtonSelectionSort
            // 
            ButtonSelectionSort.Location = new System.Drawing.Point(24, 87);
            ButtonSelectionSort.Margin = new System.Windows.Forms.Padding(6);
            ButtonSelectionSort.Name = "ButtonSelectionSort";
            ButtonSelectionSort.Size = new System.Drawing.Size(249, 49);
            ButtonSelectionSort.TabIndex = 1;
            ButtonSelectionSort.Text = "SelectionSort";
            ButtonSelectionSort.UseVisualStyleBackColor = true;
            ButtonSelectionSort.Click += ButtonSelectionSort_Click;
            // 
            // ButtonInsertSort
            // 
            ButtonInsertSort.Location = new System.Drawing.Point(24, 149);
            ButtonInsertSort.Margin = new System.Windows.Forms.Padding(6);
            ButtonInsertSort.Name = "ButtonInsertSort";
            ButtonInsertSort.Size = new System.Drawing.Size(249, 49);
            ButtonInsertSort.TabIndex = 1;
            ButtonInsertSort.Text = "InsertSort";
            ButtonInsertSort.UseVisualStyleBackColor = true;
            ButtonInsertSort.Click += ButtonInsertSort_Click;
            // 
            // ButtonquickSort
            // 
            ButtonquickSort.Location = new System.Drawing.Point(22, 211);
            ButtonquickSort.Margin = new System.Windows.Forms.Padding(6);
            ButtonquickSort.Name = "ButtonquickSort";
            ButtonquickSort.Size = new System.Drawing.Size(249, 49);
            ButtonquickSort.TabIndex = 1;
            ButtonquickSort.Text = "QuickSort";
            ButtonquickSort.UseVisualStyleBackColor = true;
            ButtonquickSort.Click += ButtonQuickSort_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(435, 277);
            radioButton1.Margin = new System.Windows.Forms.Padding(6);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(155, 36);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Draw lines";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += RadioButtonDrawLines_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(435, 331);
            radioButton2.Margin = new System.Windows.Forms.Padding(6);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(172, 36);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Draw points";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += RadioButtonDrawPoints_Click;
            // 
            // ButtonMySort
            // 
            ButtonMySort.Location = new System.Drawing.Point(22, 269);
            ButtonMySort.Margin = new System.Windows.Forms.Padding(6);
            ButtonMySort.Name = "ButtonMySort";
            ButtonMySort.Size = new System.Drawing.Size(249, 49);
            ButtonMySort.TabIndex = 1;
            ButtonMySort.Text = "MySort";
            ButtonMySort.UseVisualStyleBackColor = true;
            ButtonMySort.Click += ButtonMySort_Click;
            // 
            // ButtonMySort2
            // 
            ButtonMySort2.Location = new System.Drawing.Point(22, 331);
            ButtonMySort2.Margin = new System.Windows.Forms.Padding(6);
            ButtonMySort2.Name = "ButtonMySort2";
            ButtonMySort2.Size = new System.Drawing.Size(249, 49);
            ButtonMySort2.TabIndex = 7;
            ButtonMySort2.Text = "MySort2";
            ButtonMySort2.UseVisualStyleBackColor = true;
            ButtonMySort2.Click += ButtonMySort2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1486, 960);
            Controls.Add(ButtonMySort2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(buttonRandomize);
            Controls.Add(textBox1);
            Controls.Add(ButtonSlower);
            Controls.Add(ButtonReset);
            Controls.Add(ButtonFast);
            Controls.Add(ButtonMySort);
            Controls.Add(ButtonquickSort);
            Controls.Add(ButtonInsertSort);
            Controls.Add(ButtonSelectionSort);
            Controls.Add(ButtonBubbleSort);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonBubbleSort;
        private System.Windows.Forms.Button ButtonFast;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonSlower;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button ButtonSelectionSort;
        private System.Windows.Forms.Button ButtonInsertSort;
        private System.Windows.Forms.Button ButtonquickSort;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button ButtonMySort;
        private System.Windows.Forms.Button ButtonMySort2;
    }
}

