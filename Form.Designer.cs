namespace WindowsFormsApplication {

	partial class Calculator {

		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent() {
			this.equationTextBox = new System.Windows.Forms.TextBox();
			this.oneButton = new System.Windows.Forms.Button();
			this.twoButton = new System.Windows.Forms.Button();
			this.threeButton = new System.Windows.Forms.Button();
			this.fourButton = new System.Windows.Forms.Button();
			this.fiveButton = new System.Windows.Forms.Button();
			this.sixButton = new System.Windows.Forms.Button();
			this.sevenButton = new System.Windows.Forms.Button();
			this.eightButton = new System.Windows.Forms.Button();
			this.nineButton = new System.Windows.Forms.Button();
			this.zeroButton = new System.Windows.Forms.Button();
			this.decimalButton = new System.Windows.Forms.Button();
			this.additionButton = new System.Windows.Forms.Button();
			this.subtractButton = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.divideButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.equalsButton = new System.Windows.Forms.Button();
			this.wolframButton = new System.Windows.Forms.Button();
			this.leftPButton = new System.Windows.Forms.Button();
			this.rightPButton = new System.Windows.Forms.Button();
			this.squaredButton = new System.Windows.Forms.Button();
			this.cubedButton = new System.Windows.Forms.Button();
			this.factorialButton = new System.Windows.Forms.Button();
			this.squaredRootButton = new System.Windows.Forms.Button();
			this.logButton = new System.Windows.Forms.Button();
			this.powerButton = new System.Windows.Forms.Button();
			this.SuspendLayout();

			// equationTextBox
			this.equationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equationTextBox.Location = new System.Drawing.Point(13, 12);
			this.equationTextBox.Name = "equationTextBox";
			this.equationTextBox.Size = new System.Drawing.Size(283, 40);
			this.equationTextBox.TabIndex = 1;
			this.equationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.equationTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			//this.equationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			this.equationTextBox.ReadOnly = true;
			this.equationTextBox.BackColor = System.Drawing.SystemColors.Window;

			// oneButton
			this.oneButton.BackColor = System.Drawing.Color.Silver;
			this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.oneButton.Location = new System.Drawing.Point(118, 204);
			this.oneButton.Name = "oneButton";
			this.oneButton.Size = new System.Drawing.Size(40, 40);
			this.oneButton.TabIndex = 2;
			this.oneButton.Text = "1";
			this.oneButton.UseVisualStyleBackColor = true;
			this.oneButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oneButton_MouseClick);
			this.oneButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.oneButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// twoButton
			this.twoButton.BackColor = System.Drawing.Color.Silver;
			this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.twoButton.Location = new System.Drawing.Point(165, 204);
			this.twoButton.Name = "twoButton";
			this.twoButton.Size = new System.Drawing.Size(40, 40);
			this.twoButton.TabIndex = 3;
			this.twoButton.Text = "2";
			this.twoButton.UseVisualStyleBackColor = true;
			this.twoButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.twoButton_MouseClick);
			this.twoButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.twoButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// threeButton
			this.threeButton.BackColor = System.Drawing.Color.Silver;
			this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.threeButton.Location = new System.Drawing.Point(210, 204);
			this.threeButton.Name = "threeButton";
			this.threeButton.Size = new System.Drawing.Size(40, 40);
			this.threeButton.TabIndex = 4;
			this.threeButton.Text = "3";
			this.threeButton.UseVisualStyleBackColor = true;
			this.threeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.threeButton_MouseClick);
			this.threeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.threeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// fourButton
			this.fourButton.BackColor = System.Drawing.Color.Silver;
			this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fourButton.Location = new System.Drawing.Point(117, 157);
			this.fourButton.Name = "fourButton";
			this.fourButton.Size = new System.Drawing.Size(40, 40);
			this.fourButton.TabIndex = 5;
			this.fourButton.Text = "4";
			this.fourButton.UseVisualStyleBackColor = true;
			this.fourButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fourButton_MouseClick);
			this.fourButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.fourButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// fiveButton
			this.fiveButton.BackColor = System.Drawing.Color.Silver;
			this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fiveButton.Location = new System.Drawing.Point(163, 157);
			this.fiveButton.Name = "fiveButton";
			this.fiveButton.Size = new System.Drawing.Size(40, 40);
			this.fiveButton.TabIndex = 6;
			this.fiveButton.Text = "5";
			this.fiveButton.UseVisualStyleBackColor = true;
			this.fiveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fiveButton_MouseClick);
			this.fiveButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.fiveButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// sixButton
			this.sixButton.BackColor = System.Drawing.Color.Silver;
			this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sixButton.Location = new System.Drawing.Point(210, 157);
			this.sixButton.Name = "sixButton";
			this.sixButton.Size = new System.Drawing.Size(40, 40);
			this.sixButton.TabIndex = 7;
			this.sixButton.Text = "6";
			this.sixButton.UseVisualStyleBackColor = true;
			this.sixButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sixButton_MouseClick);
			this.sixButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.sixButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// sevenButton
			this.sevenButton.BackColor = System.Drawing.Color.Silver;
			this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sevenButton.Location = new System.Drawing.Point(117, 111);
			this.sevenButton.Name = "sevenButton";
			this.sevenButton.Size = new System.Drawing.Size(40, 40);
			this.sevenButton.TabIndex = 8;
			this.sevenButton.Text = "7";
			this.sevenButton.UseVisualStyleBackColor = true;
			this.sevenButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sevenButton_MouseClick);
			this.sevenButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.sevenButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// eightButton
			this.eightButton.BackColor = System.Drawing.Color.Silver;
			this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eightButton.Location = new System.Drawing.Point(163, 110);
			this.eightButton.Name = "eightButton";
			this.eightButton.Size = new System.Drawing.Size(40, 40);
			this.eightButton.TabIndex = 9;
			this.eightButton.Text = "8";
			this.eightButton.UseVisualStyleBackColor = true;
			this.eightButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eightButton_MouseClick);
			this.eightButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.eightButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// nineButton
			this.nineButton.BackColor = System.Drawing.Color.Silver;
			this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nineButton.Location = new System.Drawing.Point(209, 111);
			this.nineButton.Name = "nineButton";
			this.nineButton.Size = new System.Drawing.Size(40, 40);
			this.nineButton.TabIndex = 10;
			this.nineButton.Text = "9";
			this.nineButton.UseVisualStyleBackColor = true;
			this.nineButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nineButton_MouseClick);
			this.nineButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.nineButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// zeroButton
			this.zeroButton.BackColor = System.Drawing.Color.Silver;
			this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zeroButton.Location = new System.Drawing.Point(118, 250);
			this.zeroButton.Name = "zeroButton";
			this.zeroButton.Size = new System.Drawing.Size(85, 40);
			this.zeroButton.TabIndex = 11;
			this.zeroButton.Text = "0";
			this.zeroButton.UseVisualStyleBackColor = true;
			this.zeroButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zeroButton_MouseClick);
			this.zeroButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.zeroButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// decimalButton
			this.decimalButton.BackColor = System.Drawing.Color.Silver;
			this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decimalButton.Location = new System.Drawing.Point(210, 250);
			this.decimalButton.Name = "decimalButton";
			this.decimalButton.Size = new System.Drawing.Size(40, 40);
			this.decimalButton.TabIndex = 12;
			this.decimalButton.Text = ".";
			this.decimalButton.UseVisualStyleBackColor = true;
			this.decimalButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.decimalButton_MouseClick);
			this.decimalButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.decimalButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// additionButton
			this.additionButton.BackColor = System.Drawing.Color.Silver;
			this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.additionButton.Location = new System.Drawing.Point(255, 157);
			this.additionButton.Name = "additionButton";
			this.additionButton.Size = new System.Drawing.Size(40, 40);
			this.additionButton.TabIndex = 14;
			this.additionButton.Text = "+";
			this.additionButton.UseVisualStyleBackColor = true;
			this.additionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.additionButton_MouseClick);
			this.additionButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.additionButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// subtractButton
			this.subtractButton.BackColor = System.Drawing.Color.Silver;
			this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subtractButton.Location = new System.Drawing.Point(255, 111);
			this.subtractButton.Name = "subtractButton";
			this.subtractButton.Size = new System.Drawing.Size(40, 40);
			this.subtractButton.TabIndex = 15;
			this.subtractButton.Text = "-";
			this.subtractButton.UseVisualStyleBackColor = true;
			this.subtractButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subtractButton_MouseClick);
			this.subtractButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.subtractButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// multiplyButton
			this.multiplyButton.BackColor = System.Drawing.Color.Silver;
			this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multiplyButton.Location = new System.Drawing.Point(165, 64);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(40, 40);
			this.multiplyButton.TabIndex = 16;
			this.multiplyButton.Text = "x";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.multiplyButton_MouseClick);
			this.multiplyButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.multiplyButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// divideButton
			this.divideButton.BackColor = System.Drawing.Color.Silver;
			this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.divideButton.Location = new System.Drawing.Point(210, 65);
			this.divideButton.Name = "divideButton";
			this.divideButton.Size = new System.Drawing.Size(40, 40);
			this.divideButton.TabIndex = 17;
			this.divideButton.Text = "÷";
			this.divideButton.UseVisualStyleBackColor = true;
			this.divideButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.divideButton_MouseClick);
			this.divideButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.divideButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// clearButton
			this.clearButton.BackColor = System.Drawing.Color.Silver;
			this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearButton.Location = new System.Drawing.Point(118, 64);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(40, 40);
			this.clearButton.TabIndex = 18;
			this.clearButton.Text = "C";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearButton_MouseClick);
			this.clearButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.clearButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);

			// backButton
			this.backButton.BackColor = System.Drawing.Color.Silver;
			this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backButton.Location = new System.Drawing.Point(255, 65);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(40, 40);
			this.backButton.TabIndex = 19;
			this.backButton.Text = "←";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseClick);
			this.backButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.backButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// equalsButton
			this.equalsButton.BackColor = System.Drawing.Color.Silver;
			this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equalsButton.Location = new System.Drawing.Point(255, 203);
			this.equalsButton.Name = "equalsButton";
			this.equalsButton.Size = new System.Drawing.Size(40, 85);
			this.equalsButton.TabIndex = 20;
			this.equalsButton.Text = "=";
			this.equalsButton.UseVisualStyleBackColor = true;
			this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
			this.equalsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.equalsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// wolframButton
			this.wolframButton.BackColor = System.Drawing.Color.Silver;
			this.wolframButton.Location = new System.Drawing.Point(12, 65);
			this.wolframButton.Name = "wolframButton";
			this.wolframButton.Size = new System.Drawing.Size(85, 39);
			this.wolframButton.TabIndex = 21;
			this.wolframButton.Text = "Wolfram Alpha";
			this.wolframButton.UseVisualStyleBackColor = true;
			this.wolframButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wolframButton_MouseClick);
			this.wolframButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.wolframButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// leftPButton
			this.leftPButton.BackColor = System.Drawing.Color.Silver;
			this.leftPButton.Location = new System.Drawing.Point(12, 110);
			this.leftPButton.Name = "leftPButton";
			this.leftPButton.Size = new System.Drawing.Size(40, 40);
			this.leftPButton.TabIndex = 22;
			this.leftPButton.Text = "(";
			this.leftPButton.UseVisualStyleBackColor = true;
			this.leftPButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leftPButton_MouseClick);
			this.leftPButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.leftPButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// rightPButton
			this.rightPButton.BackColor = System.Drawing.Color.Silver;
			this.rightPButton.Location = new System.Drawing.Point(57, 111);
			this.rightPButton.Name = "rightPButton";
			this.rightPButton.Size = new System.Drawing.Size(40, 40);
			this.rightPButton.TabIndex = 23;
			this.rightPButton.Text = ")";
			this.rightPButton.UseVisualStyleBackColor = true;
			this.rightPButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rightPButton_MouseClick);
			this.rightPButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.rightPButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// squaredButton
			this.squaredButton.BackColor = System.Drawing.Color.Silver;
			this.squaredButton.Location = new System.Drawing.Point(12, 156);
			this.squaredButton.Name = "squaredButton";
			this.squaredButton.Size = new System.Drawing.Size(40, 40);
			this.squaredButton.TabIndex = 24;
			this.squaredButton.Text = "x^2";
			this.squaredButton.UseVisualStyleBackColor = true;
			this.squaredButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.squaredButton_MouseClick);
			this.squaredButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.squaredButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// cubedButton
			this.cubedButton.BackColor = System.Drawing.Color.Silver;
			this.cubedButton.Location = new System.Drawing.Point(57, 156);
			this.cubedButton.Name = "cubedButton";
			this.cubedButton.Size = new System.Drawing.Size(40, 40);
			this.cubedButton.TabIndex = 25;
			this.cubedButton.Text = "x^3";
			this.cubedButton.UseVisualStyleBackColor = true;
			this.cubedButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cubedButton_MouseClick);
			this.cubedButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.cubedButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// factorialButton
			this.factorialButton.BackColor = System.Drawing.Color.Silver;
			this.factorialButton.Location = new System.Drawing.Point(12, 251);
			this.factorialButton.Name = "factorialButton";
			this.factorialButton.Size = new System.Drawing.Size(40, 40);
			this.factorialButton.TabIndex = 26;
			this.factorialButton.Text = "n!";
			this.factorialButton.UseVisualStyleBackColor = true;
			this.factorialButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.factorialButton_MouseClick);
			this.factorialButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.factorialButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// squaredRootButton
			this.squaredRootButton.BackColor = System.Drawing.Color.Silver;
			this.squaredRootButton.Location = new System.Drawing.Point(58, 202);
			this.squaredRootButton.Name = "squaredRootButton";
			this.squaredRootButton.Size = new System.Drawing.Size(40, 40);
			this.squaredRootButton.TabIndex = 27;
			this.squaredRootButton.Text = "√";
			this.squaredRootButton.UseVisualStyleBackColor = true;
			this.squaredRootButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.squaredRootButton_MouseClick);
			this.squaredRootButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.squaredRootButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// logButton
			this.logButton.BackColor = System.Drawing.Color.Silver;
			this.logButton.Location = new System.Drawing.Point(57, 251);
			this.logButton.Name = "logButton";
			this.logButton.Size = new System.Drawing.Size(40, 40);
			this.logButton.TabIndex = 28;
			this.logButton.Text = "log";
			this.logButton.UseVisualStyleBackColor = true;
			this.logButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logButton_MouseClick);
			this.logButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.logButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// powerButton
			this.powerButton.BackColor = System.Drawing.Color.Silver;
			this.powerButton.Location = new System.Drawing.Point(13, 202);
			this.powerButton.Name = "powerButton";
			this.powerButton.Size = new System.Drawing.Size(40, 40);
			this.powerButton.TabIndex = 29;
			this.powerButton.Text = "x^y";
			this.powerButton.UseVisualStyleBackColor = true;
			this.powerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.powerButton_MouseClick);
			this.powerButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.powerButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// Calculator
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(305, 297);
			this.Controls.Add(this.powerButton);
			this.Controls.Add(this.logButton);
			this.Controls.Add(this.squaredRootButton);
			this.Controls.Add(this.factorialButton);
			this.Controls.Add(this.cubedButton);
			this.Controls.Add(this.squaredButton);
			this.Controls.Add(this.rightPButton);
			this.Controls.Add(this.leftPButton);
			this.Controls.Add(this.wolframButton);
			this.Controls.Add(this.equalsButton);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.divideButton);
			this.Controls.Add(this.multiplyButton);
			this.Controls.Add(this.subtractButton);
			this.Controls.Add(this.additionButton);
			this.Controls.Add(this.decimalButton);
			this.Controls.Add(this.zeroButton);
			this.Controls.Add(this.nineButton);
			this.Controls.Add(this.eightButton);
			this.Controls.Add(this.sevenButton);
			this.Controls.Add(this.sixButton);
			this.Controls.Add(this.fiveButton);
			this.Controls.Add(this.fourButton);
			this.Controls.Add(this.threeButton);
			this.Controls.Add(this.twoButton);
			this.Controls.Add(this.oneButton);
			this.Controls.Add(this.equationTextBox);
			this.Name = "Calculator";
			this.Text = "Calculator";
			this.AcceptButton = this.equalsButton;
			this.Load += new System.EventHandler(this.Calculator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox equationTextBox;
		private System.Windows.Forms.Button oneButton;
		private System.Windows.Forms.Button twoButton;
		private System.Windows.Forms.Button threeButton;
		private System.Windows.Forms.Button fourButton;
		private System.Windows.Forms.Button fiveButton;
		private System.Windows.Forms.Button sixButton;
		private System.Windows.Forms.Button sevenButton;
		private System.Windows.Forms.Button eightButton;
		private System.Windows.Forms.Button nineButton;
		private System.Windows.Forms.Button zeroButton;
		private System.Windows.Forms.Button decimalButton;
		private System.Windows.Forms.Button additionButton;
		private System.Windows.Forms.Button subtractButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.Button divideButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button equalsButton;
		private System.Windows.Forms.Button wolframButton;
		private System.Windows.Forms.Button leftPButton;
		private System.Windows.Forms.Button rightPButton;
		private System.Windows.Forms.Button squaredButton;
		private System.Windows.Forms.Button cubedButton;
		private System.Windows.Forms.Button factorialButton;
		private System.Windows.Forms.Button squaredRootButton;
		private System.Windows.Forms.Button logButton;
		private System.Windows.Forms.Button powerButton;
	}
}