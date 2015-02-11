namespace ShapeClasses
{
    partial class q506
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
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.FrontButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.AddLineButton = new System.Windows.Forms.Button();
            this.AddEllipseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.Location = new System.Drawing.Point(12, 12);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(90, 23);
            this.AddRectangleButton.TabIndex = 1;
            this.AddRectangleButton.Text = "Add Rectangle";
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // FrontButton
            // 
            this.FrontButton.Location = new System.Drawing.Point(285, 12);
            this.FrontButton.Name = "FrontButton";
            this.FrontButton.Size = new System.Drawing.Size(92, 23);
            this.FrontButton.TabIndex = 3;
            this.FrontButton.Text = "Bring To Front";
            this.FrontButton.UseVisualStyleBackColor = true;
            this.FrontButton.Click += new System.EventHandler(this.FrontButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(392, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Send To Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(492, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(30, 46);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(282, 20);
            this.MessageLabel.TabIndex = 6;
            this.MessageLabel.Text = "Welcome to the Shape Classes Demo!";
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.White;
            this.DrawingPanel.Location = new System.Drawing.Point(12, 72);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(555, 244);
            this.DrawingPanel.TabIndex = 7;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(352, 43);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(82, 23);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Change Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Location = new System.Drawing.Point(451, 43);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(48, 23);
            this.ColorPanel.TabIndex = 8;
            // 
            // AddLineButton
            // 
            this.AddLineButton.Location = new System.Drawing.Point(109, 12);
            this.AddLineButton.Name = "AddLineButton";
            this.AddLineButton.Size = new System.Drawing.Size(75, 23);
            this.AddLineButton.TabIndex = 9;
            this.AddLineButton.Text = "Add Line";
            this.AddLineButton.UseVisualStyleBackColor = true;
            this.AddLineButton.Click += new System.EventHandler(this.AddLineButton_Click);
            // 
            // AddEllipseButton
            // 
            this.AddEllipseButton.Location = new System.Drawing.Point(191, 12);
            this.AddEllipseButton.Name = "AddEllipseButton";
            this.AddEllipseButton.Size = new System.Drawing.Size(75, 23);
            this.AddEllipseButton.TabIndex = 10;
            this.AddEllipseButton.Text = "Add Ellipse";
            this.AddEllipseButton.UseVisualStyleBackColor = true;
            this.AddEllipseButton.Click += new System.EventHandler(this.AddEllipseButton_Click);
            // 
            // q506
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 328);
            this.Controls.Add(this.AddEllipseButton);
            this.Controls.Add(this.AddLineButton);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FrontButton);
            this.Controls.Add(this.AddRectangleButton);
            this.DoubleBuffered = true;
            this.Name = "q506";
            this.Text = "Quest 506 -- Patrick Xie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Button FrontButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button AddLineButton;
        private System.Windows.Forms.Button AddEllipseButton;
    }
}

