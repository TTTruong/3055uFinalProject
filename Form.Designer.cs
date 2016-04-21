using System;
using System.Windows.Forms;
using System.Drawing;

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
			this.equationTextBox = new RichTextBox();
			this.oneButton = new Button();
			this.twoButton = new Button();
			this.threeButton = new Button();
			this.fourButton = new Button();
			this.fiveButton = new Button();
			this.sixButton = new Button();
			this.sevenButton = new Button();
			this.eightButton = new Button();
			this.nineButton = new Button();
			this.zeroButton = new Button();
			this.decimalButton = new Button();
			this.additionButton = new Button();
			this.subtractButton = new Button();
			this.multiplyButton = new Button();
			this.divideButton = new Button();
			this.clearButton = new Button();
			this.backButton = new Button();
			this.equalsButton = new Button();
			this.wolframButton = new Button();
			this.leftPButton = new Button();
			this.rightPButton = new Button();
			this.squareRootButton = new Button();
			this.logButton = new Button();
			this.piButton = new Button();
			this.eulerButton = new Button();
			this.SuspendLayout();

			// equationTextBox
			this.equationTextBox.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.equationTextBox.Location = new Point(13, 12);
			this.equationTextBox.Name = "equationTextBox";
			this.equationTextBox.Size = new Size(283, 40);
			this.equationTextBox.TabIndex = 1;
			this.equationTextBox.SelectionAlignment = HorizontalAlignment.Right;
			this.equationTextBox.SelectionChanged += new System.EventHandler(this.equationTextBox_SelectionChanged);
			this.equationTextBox.TextChanged += new System.EventHandler(this.equationTextBox_TextChanged);
			this.equationTextBox.ReadOnly = true;
			this.equationTextBox.BackColor = SystemColors.Window;
			this.equationTextBox.Multiline = false;
			this.equationTextBox.WordWrap = false;

			// oneButton
			this.oneButton.BackColor = Color.Silver;
			this.oneButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.oneButton.Location = new Point(117, 204);
			this.oneButton.Name = "oneButton";
			this.oneButton.Size = new Size(40, 40);
			this.oneButton.TabIndex = 2;
			this.oneButton.Text = "1";
			this.oneButton.UseVisualStyleBackColor = true;
			this.oneButton.MouseClick += new MouseEventHandler(this.oneButton_MouseClick);
			this.oneButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.oneButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// twoButton
			this.twoButton.BackColor = Color.Silver;
			this.twoButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.twoButton.Location = new Point(163, 204);
			this.twoButton.Name = "twoButton";
			this.twoButton.Size = new Size(40, 40);
			this.twoButton.TabIndex = 3;
			this.twoButton.Text = "2";
			this.twoButton.UseVisualStyleBackColor = true;
			this.twoButton.MouseClick += new MouseEventHandler(this.twoButton_MouseClick);
			this.twoButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.twoButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// threeButton
			this.threeButton.BackColor = Color.Silver;
			this.threeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.threeButton.Location = new Point(210, 204);
			this.threeButton.Name = "threeButton";
			this.threeButton.Size = new Size(40, 40);
			this.threeButton.TabIndex = 4;
			this.threeButton.Text = "3";
			this.threeButton.UseVisualStyleBackColor = true;
			this.threeButton.MouseClick += new MouseEventHandler(this.threeButton_MouseClick);
			this.threeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.threeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// fourButton
			this.fourButton.BackColor = Color.Silver;
			this.fourButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.fourButton.Location = new Point(117, 157);
			this.fourButton.Name = "fourButton";
			this.fourButton.Size = new Size(40, 40);
			this.fourButton.TabIndex = 5;
			this.fourButton.Text = "4";
			this.fourButton.UseVisualStyleBackColor = true;
			this.fourButton.MouseClick += new MouseEventHandler(this.fourButton_MouseClick);
			this.fourButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.fourButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// fiveButton
			this.fiveButton.BackColor = Color.Silver;
			this.fiveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.fiveButton.Location = new Point(163, 157);
			this.fiveButton.Name = "fiveButton";
			this.fiveButton.Size = new Size(40, 40);
			this.fiveButton.TabIndex = 6;
			this.fiveButton.Text = "5";
			this.fiveButton.UseVisualStyleBackColor = true;
			this.fiveButton.MouseClick += new MouseEventHandler(this.fiveButton_MouseClick);
			this.fiveButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.fiveButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// sixButton
			this.sixButton.BackColor = Color.Silver;
			this.sixButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.sixButton.Location = new Point(209, 157);
			this.sixButton.Name = "sixButton";
			this.sixButton.Size = new Size(40, 40);
			this.sixButton.TabIndex = 7;
			this.sixButton.Text = "6";
			this.sixButton.UseVisualStyleBackColor = true;
			this.sixButton.MouseClick += new MouseEventHandler(this.sixButton_MouseClick);
			this.sixButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.sixButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// sevenButton
			this.sevenButton.BackColor = Color.Silver;
			this.sevenButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.sevenButton.Location = new Point(117, 111);
			this.sevenButton.Name = "sevenButton";
			this.sevenButton.Size = new Size(40, 40);
			this.sevenButton.TabIndex = 8;
			this.sevenButton.Text = "7";
			this.sevenButton.UseVisualStyleBackColor = true;
			this.sevenButton.MouseClick += new MouseEventHandler(this.sevenButton_MouseClick);
			this.sevenButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.sevenButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// eightButton
			this.eightButton.BackColor = Color.Silver;
			this.eightButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.eightButton.Location = new Point(163, 111);
			this.eightButton.Name = "eightButton";
			this.eightButton.Size = new Size(40, 40);
			this.eightButton.TabIndex = 9;
			this.eightButton.Text = "8";
			this.eightButton.UseVisualStyleBackColor = true;
			this.eightButton.MouseClick += new MouseEventHandler(this.eightButton_MouseClick);
			this.eightButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.eightButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// nineButton
			this.nineButton.BackColor = Color.Silver;
			this.nineButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.nineButton.Location = new Point(209, 111);
			this.nineButton.Name = "nineButton";
			this.nineButton.Size = new Size(40, 40);
			this.nineButton.TabIndex = 10;
			this.nineButton.Text = "9";
			this.nineButton.UseVisualStyleBackColor = true;
			this.nineButton.MouseClick += new MouseEventHandler(this.nineButton_MouseClick);
			this.nineButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.nineButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// zeroButton
			this.zeroButton.BackColor = Color.Silver;
			this.zeroButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.zeroButton.Location = new Point(117, 250);
			this.zeroButton.Name = "zeroButton";
			this.zeroButton.Size = new Size(87, 40);
			this.zeroButton.TabIndex = 11;
			this.zeroButton.Text = "0";
			this.zeroButton.UseVisualStyleBackColor = true;
			this.zeroButton.MouseClick += new MouseEventHandler(this.zeroButton_MouseClick);
			this.zeroButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.zeroButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// decimalButton
			this.decimalButton.BackColor = Color.Silver;
			this.decimalButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.decimalButton.Location = new Point(210, 250);
			this.decimalButton.Name = "decimalButton";
			this.decimalButton.Size = new Size(40, 40);
			this.decimalButton.TabIndex = 12;
			this.decimalButton.Text = ".";
			this.decimalButton.UseVisualStyleBackColor = true;
			this.decimalButton.MouseClick += new MouseEventHandler(this.decimalButton_MouseClick);
			this.decimalButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.decimalButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// additionButton
			this.additionButton.BackColor = Color.Silver;
			this.additionButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.additionButton.Location = new Point(255, 157);
			this.additionButton.Name = "additionButton";
			this.additionButton.Size = new Size(40, 40);
			this.additionButton.TabIndex = 14;
			this.additionButton.Text = "+";
			this.additionButton.UseVisualStyleBackColor = true;
			this.additionButton.MouseClick += new MouseEventHandler(this.additionButton_MouseClick);
			this.additionButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.additionButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// subtractButton
			this.subtractButton.BackColor = Color.Silver;
			this.subtractButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.subtractButton.Location = new Point(255, 111);
			this.subtractButton.Name = "subtractButton";
			this.subtractButton.Size = new Size(40, 40);
			this.subtractButton.TabIndex = 15;
			this.subtractButton.Text = "-";
			this.subtractButton.UseVisualStyleBackColor = true;
			this.subtractButton.MouseClick += new MouseEventHandler(this.subtractButton_MouseClick);
			this.subtractButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.subtractButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// multiplyButton
			this.multiplyButton.BackColor = Color.Silver;
			this.multiplyButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.multiplyButton.Location = new Point(163, 65);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new Size(40, 40);
			this.multiplyButton.TabIndex = 16;
			this.multiplyButton.Text = "x";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.MouseClick += new MouseEventHandler(this.multiplyButton_MouseClick);
			this.multiplyButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.multiplyButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// divideButton
			this.divideButton.BackColor = Color.Silver;
			this.divideButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.divideButton.Location = new Point(209, 65);
			this.divideButton.Name = "divideButton";
			this.divideButton.Size = new Size(40, 40);
			this.divideButton.TabIndex = 17;
			this.divideButton.Text = "÷";
			this.divideButton.UseVisualStyleBackColor = true;
			this.divideButton.MouseClick += new MouseEventHandler(this.divideButton_MouseClick);
			this.divideButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.divideButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// clearButton
			this.clearButton.BackColor = Color.Silver;
			this.clearButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.clearButton.Location = new Point(117, 65);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new Size(40, 40);
			this.clearButton.TabIndex = 18;
			this.clearButton.Text = "C";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.MouseClick += new MouseEventHandler(this.clearButton_MouseClick);
			this.clearButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.clearButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);

			// backButton
			this.backButton.BackColor = Color.Silver;
			this.backButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
			this.backButton.Location = new Point(255, 65);
			this.backButton.Name = "backButton";
			this.backButton.Size = new Size(40, 40);
			this.backButton.TabIndex = 19;
			this.backButton.Text = "←";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.MouseClick += new MouseEventHandler(this.backButton_MouseClick);
			this.backButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.backButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// equalsButton
			this.equalsButton.BackColor = Color.Silver;
			this.equalsButton.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.equalsButton.Location = new Point(255, 204);
			this.equalsButton.Name = "equalsButton";
			this.equalsButton.Size = new Size(40, 85);
			this.equalsButton.TabIndex = 20;
			this.equalsButton.Text = "=";
			this.equalsButton.UseVisualStyleBackColor = true;
			this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
			this.equalsButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.equalsButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// wolframButton
			this.wolframButton.BackColor = Color.Silver;
			this.wolframButton.Location = new Point(12, 65);
			this.wolframButton.Name = "wolframButton";
			this.wolframButton.Size = new Size(85, 40);
			this.wolframButton.TabIndex = 21;
			this.wolframButton.Text = "Wolfram Alpha";
			this.wolframButton.UseVisualStyleBackColor = true;
			this.wolframButton.MouseClick += new MouseEventHandler(this.wolframButton_MouseClick);
			this.wolframButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.wolframButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// leftPButton
			this.leftPButton.BackColor = Color.Silver;
			this.leftPButton.Location = new Point(12, 158);
			this.leftPButton.Name = "leftPButton";
			this.leftPButton.Size = new Size(40, 40);
			this.leftPButton.TabIndex = 22;
			this.leftPButton.Text = "(";
			this.leftPButton.UseVisualStyleBackColor = true;
			this.leftPButton.MouseClick += new MouseEventHandler(this.leftPButton_MouseClick);
			this.leftPButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.leftPButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// rightPButton
			this.rightPButton.BackColor = Color.Silver;
			this.rightPButton.Location = new Point(57, 157);
			this.rightPButton.Name = "rightPButton";
			this.rightPButton.Size = new Size(40, 40);
			this.rightPButton.TabIndex = 23;
			this.rightPButton.Text = ")";
			this.rightPButton.UseVisualStyleBackColor = true;
			this.rightPButton.MouseClick += new MouseEventHandler(this.rightPButton_MouseClick);
			this.rightPButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.rightPButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);

			// squareRootButton
			this.squareRootButton.BackColor = Color.Silver;
			this.squareRootButton.Location = new Point(12, 251);
			this.squareRootButton.Name = "squareRootButton";
			this.squareRootButton.Size = new Size(40, 40);
			this.squareRootButton.TabIndex = 27;
			this.squareRootButton.Text = "√";
			this.squareRootButton.UseVisualStyleBackColor = true;
			this.squareRootButton.MouseClick += new MouseEventHandler(this.squareRootButton_MouseClick);
			this.squareRootButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.squareRootButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// logButton
			this.logButton.BackColor = Color.Silver;
			this.logButton.Location = new Point(57, 251);
			this.logButton.Name = "logButton";
			this.logButton.Size = new Size(40, 40);
			this.logButton.TabIndex = 28;
			this.logButton.Text = "log10";
			this.logButton.UseVisualStyleBackColor = true;
			this.logButton.MouseClick += new MouseEventHandler(this.logButton_MouseClick);
			this.logButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.logButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// piButton
			this.piButton.BackColor = Color.Silver;
			this.piButton.Location = new Point(12, 204);
			this.piButton.Name = "piButton";
			this.piButton.Size = new Size(40, 40);
			this.piButton.TabIndex = 29;
			this.piButton.Text = "Pi";
			this.piButton.UseVisualStyleBackColor = true;
			this.piButton.MouseClick += new MouseEventHandler(this.piButton_MouseClick);
			this.piButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.piButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			
			// eulerButton
			this.eulerButton.BackColor = Color.Silver;
			this.eulerButton.Location = new Point(57, 204);
			this.eulerButton.Name = "eulerButton";
			this.eulerButton.Size = new Size(40, 40);
			this.eulerButton.TabIndex = 29;
			this.eulerButton.Text = "e";
			this.eulerButton.UseVisualStyleBackColor = true;
			this.eulerButton.MouseClick += new MouseEventHandler(this.eulerButton_MouseClick);
			this.eulerButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.eulerButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);

			// Calculator
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.DimGray;
			this.ClientSize = new Size(305, 297);
			this.Controls.Add(this.eulerButton);
			this.Controls.Add(this.piButton);
			this.Controls.Add(this.logButton);
			this.Controls.Add(this.squareRootButton);
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
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.AcceptButton = this.equalsButton;
			this.Load += new System.EventHandler(this.Calculator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion
		private RichTextBox equationTextBox;
		private Button oneButton;
		private Button twoButton;
		private Button threeButton;
		private Button fourButton;
		private Button fiveButton;
		private Button sixButton;
		private Button sevenButton;
		private Button eightButton;
		private Button nineButton;
		private Button zeroButton;
		private Button decimalButton;
		private Button additionButton;
		private Button subtractButton;
		private Button multiplyButton;
		private Button divideButton;
		private Button clearButton;
		private Button backButton;
		private Button equalsButton;
		private Button wolframButton;
		private Button leftPButton;
		private Button rightPButton;
		private Button squareRootButton;
		private Button logButton;
		private Button piButton;
		private Button eulerButton;
	}
}