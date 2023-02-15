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
			this.endTurnButton = new System.Windows.Forms.Button();
			this.textBox = new System.Windows.Forms.TextBox();
			this.enemyNameBox = new System.Windows.Forms.TextBox();
			this.enemyLifeBar = new System.Windows.Forms.PictureBox();
			this.enemyLifeLabel = new System.Windows.Forms.Label();
			this.enemyDefenseLabel = new System.Windows.Forms.Label();
			this.enemyPowerLabel = new System.Windows.Forms.Label();
			this.enemyPowerBar = new System.Windows.Forms.TextBox();
			this.enemyDefenseBar = new System.Windows.Forms.TextBox();
			this.enemyPicture = new System.Windows.Forms.PictureBox();
			this.attackRadioButton = new System.Windows.Forms.RadioButton();
			this.dubbleAttackRadioButton = new System.Windows.Forms.RadioButton();
			this.defenseRadioButton = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.lifeBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heroPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyLifeBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyPicture)).BeginInit();
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
			this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.powerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// defenseBox
			// 
			this.defenseBox.Location = new System.Drawing.Point(81, 155);
			this.defenseBox.Name = "defenseBox";
			this.defenseBox.Size = new System.Drawing.Size(100, 23);
			this.defenseBox.TabIndex = 7;
			this.defenseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			// endTurnButton
			// 
			this.endTurnButton.Location = new System.Drawing.Point(12, 709);
			this.endTurnButton.Name = "endTurnButton";
			this.endTurnButton.Size = new System.Drawing.Size(150, 40);
			this.endTurnButton.TabIndex = 11;
			this.endTurnButton.Text = "button1";
			this.endTurnButton.UseVisualStyleBackColor = true;
			this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.SystemColors.Info;
			this.textBox.Location = new System.Drawing.Point(280, 12);
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox.Size = new System.Drawing.Size(650, 23);
			this.textBox.TabIndex = 12;
			// 
			// enemyNameBox
			// 
			this.enemyNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.enemyNameBox.Location = new System.Drawing.Point(1072, 12);
			this.enemyNameBox.Name = "enemyNameBox";
			this.enemyNameBox.ReadOnly = true;
			this.enemyNameBox.Size = new System.Drawing.Size(100, 23);
			this.enemyNameBox.TabIndex = 13;
			this.enemyNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// enemyLifeBar
			// 
			this.enemyLifeBar.Location = new System.Drawing.Point(1072, 97);
			this.enemyLifeBar.Name = "enemyLifeBar";
			this.enemyLifeBar.Size = new System.Drawing.Size(100, 23);
			this.enemyLifeBar.TabIndex = 14;
			this.enemyLifeBar.TabStop = false;
			// 
			// enemyLifeLabel
			// 
			this.enemyLifeLabel.AutoSize = true;
			this.enemyLifeLabel.Location = new System.Drawing.Point(997, 97);
			this.enemyLifeLabel.Name = "enemyLifeLabel";
			this.enemyLifeLabel.Size = new System.Drawing.Size(38, 15);
			this.enemyLifeLabel.TabIndex = 15;
			this.enemyLifeLabel.Text = "label1";
			// 
			// enemyDefenseLabel
			// 
			this.enemyDefenseLabel.AutoSize = true;
			this.enemyDefenseLabel.Location = new System.Drawing.Point(997, 155);
			this.enemyDefenseLabel.Name = "enemyDefenseLabel";
			this.enemyDefenseLabel.Size = new System.Drawing.Size(38, 15);
			this.enemyDefenseLabel.TabIndex = 16;
			this.enemyDefenseLabel.Text = "label1";
			// 
			// enemyPowerLabel
			// 
			this.enemyPowerLabel.AutoSize = true;
			this.enemyPowerLabel.Location = new System.Drawing.Point(997, 126);
			this.enemyPowerLabel.Name = "enemyPowerLabel";
			this.enemyPowerLabel.Size = new System.Drawing.Size(38, 15);
			this.enemyPowerLabel.TabIndex = 17;
			this.enemyPowerLabel.Text = "label1";
			// 
			// enemyPowerBar
			// 
			this.enemyPowerBar.Location = new System.Drawing.Point(1072, 126);
			this.enemyPowerBar.Name = "enemyPowerBar";
			this.enemyPowerBar.Size = new System.Drawing.Size(100, 23);
			this.enemyPowerBar.TabIndex = 18;
			this.enemyPowerBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// enemyDefenseBar
			// 
			this.enemyDefenseBar.Location = new System.Drawing.Point(1072, 155);
			this.enemyDefenseBar.Name = "enemyDefenseBar";
			this.enemyDefenseBar.Size = new System.Drawing.Size(100, 23);
			this.enemyDefenseBar.TabIndex = 19;
			this.enemyDefenseBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// enemyPicture
			// 
			this.enemyPicture.Location = new System.Drawing.Point(1122, 41);
			this.enemyPicture.Name = "enemyPicture";
			this.enemyPicture.Size = new System.Drawing.Size(50, 50);
			this.enemyPicture.TabIndex = 20;
			this.enemyPicture.TabStop = false;
			// 
			// attackRadioButton
			// 
			this.attackRadioButton.AutoSize = true;
			this.attackRadioButton.Location = new System.Drawing.Point(12, 228);
			this.attackRadioButton.Name = "attackRadioButton";
			this.attackRadioButton.Size = new System.Drawing.Size(94, 19);
			this.attackRadioButton.TabIndex = 21;
			this.attackRadioButton.TabStop = true;
			this.attackRadioButton.Text = "radioButton1";
			this.attackRadioButton.UseVisualStyleBackColor = true;
			// 
			// dubbleAttackRadioButton
			// 
			this.dubbleAttackRadioButton.AutoSize = true;
			this.dubbleAttackRadioButton.Location = new System.Drawing.Point(12, 278);
			this.dubbleAttackRadioButton.Name = "dubbleAttackRadioButton";
			this.dubbleAttackRadioButton.Size = new System.Drawing.Size(94, 19);
			this.dubbleAttackRadioButton.TabIndex = 23;
			this.dubbleAttackRadioButton.TabStop = true;
			this.dubbleAttackRadioButton.Text = "radioButton2";
			this.dubbleAttackRadioButton.UseVisualStyleBackColor = true;
			// 
			// defenseRadioButton
			// 
			this.defenseRadioButton.AutoSize = true;
			this.defenseRadioButton.Location = new System.Drawing.Point(12, 253);
			this.defenseRadioButton.Name = "defenseRadioButton";
			this.defenseRadioButton.Size = new System.Drawing.Size(94, 19);
			this.defenseRadioButton.TabIndex = 24;
			this.defenseRadioButton.TabStop = true;
			this.defenseRadioButton.Text = "radioButton3";
			this.defenseRadioButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 761);
			this.Controls.Add(this.defenseRadioButton);
			this.Controls.Add(this.dubbleAttackRadioButton);
			this.Controls.Add(this.attackRadioButton);
			this.Controls.Add(this.enemyPicture);
			this.Controls.Add(this.enemyDefenseBar);
			this.Controls.Add(this.enemyPowerBar);
			this.Controls.Add(this.enemyPowerLabel);
			this.Controls.Add(this.enemyDefenseLabel);
			this.Controls.Add(this.enemyLifeLabel);
			this.Controls.Add(this.enemyLifeBar);
			this.Controls.Add(this.enemyNameBox);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.endTurnButton);
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
			((System.ComponentModel.ISupportInitialize)(this.enemyLifeBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyPicture)).EndInit();
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
		private Button endTurnButton;
		private TextBox textBox;
		private TextBox enemyNameBox;
		private PictureBox enemyLifeBar;
		private Label enemyLifeLabel;
		private Label enemyDefenseLabel;
		private Label enemyPowerLabel;
		private TextBox enemyPowerBar;
		private TextBox enemyDefenseBar;
		private PictureBox enemyPicture;
		private RadioButton attackRadioButton;
		private RadioButton dubbleAttackRadioButton;
		private RadioButton defenseRadioButton;
	}
}