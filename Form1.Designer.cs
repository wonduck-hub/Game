namespace Game
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
			this.lifeBar = new System.Windows.Forms.PictureBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.lifeLabel = new System.Windows.Forms.Label();
			this.powerBox = new System.Windows.Forms.TextBox();
			this.defenseBox = new System.Windows.Forms.TextBox();
			this.powerLabel = new System.Windows.Forms.Label();
			this.defenseLabel = new System.Windows.Forms.Label();
			this.heroPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.lifeBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heroPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// lifeBar
			// 
			this.lifeBar.Location = new System.Drawing.Point(81, 97);
			this.lifeBar.Name = "lifeBar";
			this.lifeBar.Size = new System.Drawing.Size(100, 23);
			this.lifeBar.TabIndex = 3;
			this.lifeBar.TabStop = false;
			this.lifeBar.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// nameBox
			// 
			this.nameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.nameBox.Location = new System.Drawing.Point(12, 12);
			this.nameBox.Name = "nameBox";
			this.nameBox.ReadOnly = true;
			this.nameBox.Size = new System.Drawing.Size(100, 23);
			this.nameBox.TabIndex = 4;
			// 
			// lifeLabel
			// 
			this.lifeLabel.AutoSize = true;
			this.lifeLabel.Location = new System.Drawing.Point(12, 97);
			this.lifeLabel.Name = "lifeLabel";
			this.lifeLabel.Size = new System.Drawing.Size(38, 15);
			this.lifeLabel.TabIndex = 5;
			this.lifeLabel.Text = "label1";
			// 
			// powerBox
			// 
			this.powerBox.Location = new System.Drawing.Point(81, 126);
			this.powerBox.Name = "powerBox";
			this.powerBox.Size = new System.Drawing.Size(100, 23);
			this.powerBox.TabIndex = 6;
			// 
			// defenseBox
			// 
			this.defenseBox.Location = new System.Drawing.Point(81, 155);
			this.defenseBox.Name = "defenseBox";
			this.defenseBox.Size = new System.Drawing.Size(100, 23);
			this.defenseBox.TabIndex = 7;
			// 
			// powerLabel
			// 
			this.powerLabel.AutoSize = true;
			this.powerLabel.Location = new System.Drawing.Point(12, 126);
			this.powerLabel.Name = "powerLabel";
			this.powerLabel.Size = new System.Drawing.Size(38, 15);
			this.powerLabel.TabIndex = 8;
			this.powerLabel.Text = "label1";
			// 
			// defenseLabel
			// 
			this.defenseLabel.AutoSize = true;
			this.defenseLabel.Location = new System.Drawing.Point(12, 155);
			this.defenseLabel.Name = "defenseLabel";
			this.defenseLabel.Size = new System.Drawing.Size(38, 15);
			this.defenseLabel.TabIndex = 9;
			this.defenseLabel.Text = "label1";
			// 
			// heroPicture
			// 
			this.heroPicture.Location = new System.Drawing.Point(12, 41);
			this.heroPicture.Name = "heroPicture";
			this.heroPicture.Size = new System.Drawing.Size(50, 50);
			this.heroPicture.TabIndex = 10;
			this.heroPicture.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 761);
			this.Controls.Add(this.heroPicture);
			this.Controls.Add(this.defenseLabel);
			this.Controls.Add(this.powerLabel);
			this.Controls.Add(this.defenseBox);
			this.Controls.Add(this.powerBox);
			this.Controls.Add(this.lifeLabel);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.lifeBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.lifeBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heroPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private PictureBox lifeBar;
		private TextBox nameBox;
		private Label lifeLabel;
		private TextBox powerBox;
		private TextBox defenseBox;
		private Label powerLabel;
		private Label defenseLabel;
		private PictureBox heroPicture;
	}
}