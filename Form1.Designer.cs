using System;

namespace Exercise8
{
    partial class Form1
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
            this.fatGrams = new System.Windows.Forms.Label();
            this.carbsGrams = new System.Windows.Forms.Label();
            this.textFatGrams = new System.Windows.Forms.TextBox();
            this.textCarbsGrams = new System.Windows.Forms.TextBox();
            this.buttonCalcFat = new System.Windows.Forms.Button();
            this.buttonCalcCarbs = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textFatCalories = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCarbCalories = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fatGrams
            // 
            this.fatGrams.AutoSize = true;
            this.fatGrams.Location = new System.Drawing.Point(12, 9);
            this.fatGrams.Name = "fatGrams";
            this.fatGrams.Size = new System.Drawing.Size(55, 13);
            this.fatGrams.TabIndex = 0;
            this.fatGrams.Text = "Fat Grams";
            // 
            // carbsGrams
            // 
            this.carbsGrams.AutoSize = true;
            this.carbsGrams.Location = new System.Drawing.Point(12, 63);
            this.carbsGrams.Name = "carbsGrams";
            this.carbsGrams.Size = new System.Drawing.Size(67, 13);
            this.carbsGrams.TabIndex = 1;
            this.carbsGrams.Text = "Carbs Grams";
            // 
            // textFatGrams
            // 
            this.textFatGrams.Location = new System.Drawing.Point(128, 9);
            this.textFatGrams.Name = "textFatGrams";
            this.textFatGrams.Size = new System.Drawing.Size(100, 20);
            this.textFatGrams.TabIndex = 2;
            // 
            // textCarbsGrams
            // 
            this.textCarbsGrams.Location = new System.Drawing.Point(128, 63);
            this.textCarbsGrams.Name = "textCarbsGrams";
            this.textCarbsGrams.Size = new System.Drawing.Size(100, 20);
            this.textCarbsGrams.TabIndex = 3;
            // 
            // buttonCalcFat
            // 
            this.buttonCalcFat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCalcFat.Location = new System.Drawing.Point(234, 9);
            this.buttonCalcFat.Name = "buttonCalcFat";
            this.buttonCalcFat.Size = new System.Drawing.Size(119, 23);
            this.buttonCalcFat.TabIndex = 4;
            this.buttonCalcFat.Text = "Calculate";
            this.buttonCalcFat.UseVisualStyleBackColor = false;
            this.buttonCalcFat.Click += new System.EventHandler(this.buttonCalcFat_Click);
            // 
            // buttonCalcCarbs
            // 
            this.buttonCalcCarbs.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCalcCarbs.Location = new System.Drawing.Point(234, 61);
            this.buttonCalcCarbs.Name = "buttonCalcCarbs";
            this.buttonCalcCarbs.Size = new System.Drawing.Size(119, 23);
            this.buttonCalcCarbs.TabIndex = 5;
            this.buttonCalcCarbs.Text = "Calculate";
            this.buttonCalcCarbs.UseVisualStyleBackColor = false;
            this.buttonCalcCarbs.Click += new System.EventHandler(this.buttonCalcCarbs_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(12, 123);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(341, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textFatCalories
            // 
            this.textFatCalories.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textFatCalories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textFatCalories.ForeColor = System.Drawing.Color.Red;
            this.textFatCalories.Location = new System.Drawing.Point(128, 35);
            this.textFatCalories.Name = "textFatCalories";
            this.textFatCalories.Size = new System.Drawing.Size(100, 15);
            this.textFatCalories.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calories From Fat";
            // 
            // textCarbCalories
            // 
            this.textCarbCalories.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textCarbCalories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCarbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textCarbCalories.ForeColor = System.Drawing.Color.Red;
            this.textCarbCalories.Location = new System.Drawing.Point(128, 89);
            this.textCarbCalories.Name = "textCarbCalories";
            this.textCarbCalories.Size = new System.Drawing.Size(100, 15);
            this.textCarbCalories.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Calories From Carbs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 158);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCarbCalories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFatCalories);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCalcCarbs);
            this.Controls.Add(this.buttonCalcFat);
            this.Controls.Add(this.textCarbsGrams);
            this.Controls.Add(this.textFatGrams);
            this.Controls.Add(this.carbsGrams);
            this.Controls.Add(this.fatGrams);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbohydrates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatGrams;
        private System.Windows.Forms.Label carbsGrams;
        private System.Windows.Forms.TextBox textFatGrams;
        private System.Windows.Forms.TextBox textCarbsGrams;
        private System.Windows.Forms.Button buttonCalcFat;
        private System.Windows.Forms.Button buttonCalcCarbs;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textFatCalories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCarbCalories;
        private System.Windows.Forms.Label label2;
    }
}

