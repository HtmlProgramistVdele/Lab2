using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    partial class Form1
    {
      protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.timer1 = new Timer(this.components);
      this.btnOk = new Button();
      this.btnCancel = new Button();
      this.timer2 = new Timer(this.components);
      this.SuspendLayout();
      this.timer1.Enabled = true;
      this.timer1.Interval = 3000;
      this.timer1.Tick += new EventHandler(this.timer_Tick);
      this.btnOk.Font = new Font("Old English Text MT", 15.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.btnOk.ForeColor = Color.Red;
      this.btnOk.Location = new Point(313, 215);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(90, 36);
      this.btnOk.TabIndex = 1;
      this.btnOk.TabStop = false;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.LocationChanged += new EventHandler(this.btnOk_LocationChanged);
      this.btnOk.Click += new EventHandler(this.btnOk_Click);
      this.btnOk.MouseEnter += new EventHandler(this.btnOk_MouseEnter);
      this.btnCancel.Font = new Font("Algerian", 14.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(313, 257);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(90, 36);
      this.btnCancel.TabIndex = 0;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnCancel.KeyDown += new KeyEventHandler(this.btnCancel_KeyDown);
      this.btnCancel.KeyUp += new KeyEventHandler(this.btnCancel_KeyUp);
      this.timer2.Interval = 1000;
      this.timer2.Tick += new EventHandler(this.timer2_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(720, 518);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.btnCancel);
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      this.MouseMove += new MouseEventHandler(this.Form1_MouseMove);
      this.ResumeLayout(false);
    }
  }
}