using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addExe
{

    public class Entry
    {
        static void Main()
        {
            Test m = new Test();
            m.Message();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
    public class Test
    {
        public void Message()
        {

            MessageBox.Show("Hello World");
        }
    }
    /* public static void Main(string[] args)
     {
        // MessageBox.Show("Hello World");
         UserControl p = new UserControl();
         Test m = new Test();
         m.Message();
         p.Invalidate() ;
     }*/

    partial class Form1
    {
        // <summary>
        // Required designer variable.
        // </summary>
        private System.ComponentModel.IContainer components = null;
        // <summary>
        // Clean up any resources being used.
        // </summary>
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        // <summary>
        // Required method for Designer support - do not modify 
        // the contents of this method with the code editor.
        // </summary>

        public void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.totalSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lets Summate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(116, 30);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 20);
            this.Num1.TabIndex = 1;
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(116, 67);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 20);
            this.Num2.TabIndex = 2;
            // 
            // totalSum
            // 
            this.totalSum.Location = new System.Drawing.Point(116, 103);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(100, 20);
            this.totalSum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Num2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Sum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalSum);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(310, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox totalSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}