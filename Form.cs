using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication {

	public partial class Calculator : Form {

		bool recEquals;
		bool recOp;
		int leftPCount;
		int rightPCount;

		public Calculator() {
			InitializeComponent();
			recEquals = false;
			recOp = false;
			leftPCount = 0;
			rightPCount = 0;
		}

		private void Calculator_Load(object sender, EventArgs e) {

		}

		private void zeroButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "0";
				recEquals = false;
			} else {
				equationTextBox.Text += "0";
			}
			recOp = false;
		}

		private void oneButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "1";
				recEquals = false;
			} else {
				equationTextBox.Text += "1";
			}
			recOp = false;
		}

		private void twoButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "2";
				recEquals = false;
			} else {
				equationTextBox.Text += "2";
			}
			recOp = false;
		}

		private void threeButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "3";
				recEquals = false;
			} else {
				equationTextBox.Text += "3";
			}
			recOp = false;
		}

		private void fourButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "4";
				recEquals = false;
			} else {
				equationTextBox.Text += "4";
			}
			recOp = false;
		}

		private void fiveButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "5";
				recEquals = false;
			} else {
				equationTextBox.Text += "5";
			}
			recOp = false;
		}

		private void sixButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "6";
				recEquals = false;
			} else {
				equationTextBox.Text += "6";
			}
			recOp = false;
		}

		private void sevenButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "7";
				recEquals = false;
			} else {
				equationTextBox.Text += "7";
			}
			recOp = false;
		}

		private void eightButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "8";
				recEquals = false;
			} else {
				equationTextBox.Text += "8";
			}
			recOp = false;
		}

		private void nineButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "9";
				recEquals = false;
			} else {
				equationTextBox.Text += "9";
			}
			recOp = false;
		}

		private void decimalButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "0.";
				recEquals = false;
			} else {
				if (equationTextBox.Text == "" || equationTextBox.Text[equationTextBox.Text.Length-1] == '(') {
					equationTextBox.Text += "0.";
				} else {

					int prevCounter = equationTextBox.Text.Length-1;
					bool validDec = true;

					while (prevCounter >= 0) {
						if (System.Text.RegularExpressions.Regex.IsMatch(equationTextBox.Text[prevCounter].ToString(), "[.]+")) {
							validDec = false;
							break;
						} else if (!System.Text.RegularExpressions.Regex.IsMatch(equationTextBox.Text[prevCounter].ToString(), "[0123456789]+")) {
							break;
						}

						prevCounter--;
					}

					if (validDec) {
						equationTextBox.Text += ".";
					}
				}
			}
			recOp = false;
		}

		private void equationTextBox_TextChanged(object sender, EventArgs e) {
			
		}

		private void equationTextBox_SelectionChanged(Object sender, EventArgs e) {

			equationTextBox.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;
		}

		/* Commented out for now.
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
     		if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[\\d+()\\-+x/.^\\b]+")) {
          		e.Handled = true;
     		}
		}*/

		private void clearButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text = "";
			recEquals = false;
			recOp = false;
			leftPCount = 0;
			rightPCount = 0;
		}

		private void equalsButton_Click(object sender, EventArgs e) {
			
			try {
				if (equationTextBox.Text != "") {
					if (System.Text.RegularExpressions.Regex.IsMatch(equationTextBox.Text[equationTextBox.Text.Length-1].ToString(), "[+-/*(]+")) {
						equationTextBox.Text += "0";
					}
	
					for (int i=rightPCount; i < leftPCount; i++) {
						equationTextBox.Text += ")";
					}
	
					NCalc.Expression exp = new NCalc.Expression(equationTextBox.Text);
					var v = exp.Evaluate();
	
					if (v.ToString() == "Infinity") {
						equationTextBox.Text = "Undefined";
					} else {
						equationTextBox.Text = v.ToString();
					}
				}
			} catch (Exception except) {
				equationTextBox.Text = "Overflow";
			}

			recEquals = true;
			recOp = false;
			leftPCount = 0;
			rightPCount = 0;
		}

		private void backButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "Undefined" || equationTextBox.Text == "Overflow") {
				equationTextBox.Text = "";
			} else {
				if (equationTextBox.Text != "") {

					if (equationTextBox.Text[equationTextBox.Text.Length-1] == '(') {
						leftPCount--;
					} else if (equationTextBox.Text[equationTextBox.Text.Length-1] == ')') {
						rightPCount--;
					}

					equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);

					if (equationTextBox.Text != "") {
						if (!System.Text.RegularExpressions.Regex.IsMatch(equationTextBox.Text[equationTextBox.Text.Length-1].ToString(), "[+-/*]+")) {
	          				recOp = true;
     					} else {
     						recOp = false;
     					}
     				}
				}
			}
		}

		private void additionButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "" || equationTextBox.Text == "Undefined" || equationTextBox.Text == "Overflow") {
				equationTextBox.Text = "0+";
				recEquals = false;
				recOp = true;
			} else {
				if (recOp) {
					equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
				}
				if (equationTextBox.Text[equationTextBox.Text.Length-1] != '(') {
					equationTextBox.Text += "+";
					recEquals = false;
					recOp = true;
				}
			}
		}

		private void subtractButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "" || equationTextBox.Text == "Undefined" || equationTextBox.Text == "Overflow") {
				equationTextBox.Text = "0-";
				recEquals = false;
				recOp = true;
			} else {
				if (recOp) {
					equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
				}
				if (equationTextBox.Text[equationTextBox.Text.Length-1] != '(') {
					equationTextBox.Text += "-";
					recEquals = false;
					recOp = true;
				}
			}
		}

		private void multiplyButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "" || equationTextBox.Text == "Undefined" || equationTextBox.Text == "Overflow") {
				equationTextBox.Text = "0*";
				recEquals = false;
				recOp = true;
			} else {
				if (recOp) {
					equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
				}
				if (equationTextBox.Text[equationTextBox.Text.Length-1] != '(') {
					equationTextBox.Text += "*";
					recEquals = false;
					recOp = true;
				}
			}
		}

		private void divideButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "" || equationTextBox.Text == "Undefined" || equationTextBox.Text == "Overflow") {
				equationTextBox.Text = "0/";
				recEquals = false;
				recOp = true;
			} else {
				if (recOp) {
					equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
				}
				if (equationTextBox.Text[equationTextBox.Text.Length-1] != '(') {
					equationTextBox.Text += "/";
					recEquals = false;
					recOp = true;
				}
			}
		}

		private void wolframButton_MouseClick(object sender, MouseEventArgs e) {
			string wolframUrl = "http://www.wolframalpha.com/input?i=";

			foreach(char c in equationTextBox.Text) {
				if (c == '+') {
					wolframUrl += "%2B";
				} else {
					wolframUrl += c.ToString();
				}
			}

			System.Diagnostics.Process.Start(wolframUrl);
		}

		private void leftPButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "(";
			} else {
				if (equationTextBox.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(equationTextBox.Text[equationTextBox.Text.Length-1].ToString(), "[+-/*(]+")) {
					equationTextBox.Text += "*";
				}

				equationTextBox.Text += "(";
			}

			leftPCount++;
			recEquals = false;
			recOp = false;
		}

		private void rightPButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text != "" && rightPCount < leftPCount) {

				if (System.Text.RegularExpressions.Regex.IsMatch(equationTextBox.Text[equationTextBox.Text.Length-1].ToString(), "[+-/*(]+")) {
					equationTextBox.Text += "0";
				}

				equationTextBox.Text += ")";

				rightPCount++;
				recEquals = false;
				recOp = false;
			}
		}

		private void squaredButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0^2";
			} else {
				equationTextBox.Text += "^2";
			}
			recEquals = false;
			recOp = false;
		}

		private void cubedButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0^3";
			} else {
				equationTextBox.Text += "^3";
			}
			recEquals = false;
			recOp = false;
		}

		private void powerButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "Pow(";
			} else {
				if (recOp) {
					equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
				}
				equationTextBox.Text += "Pow(";
			}
			recEquals = false;
			recOp = true;
		}

		private void factorialButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "Fact(";
			} else {
				equationTextBox.Text += "Fact(";
			}
			recEquals = false;
			recOp = false;
		}

		private void squareRootButton_MouseClick(object sender, MouseEventArgs e) {
			
			if (equationTextBox.Text != "") {
				if (equationTextBox.Text[equationTextBox.Text.Length-1] == '.') {
					equationTextBox.Text += "0*Sqrt(";
				} else {
					if (System.Text.RegularExpressions.Regex.IsMatch(equationTextBox.Text[equationTextBox.Text.Length-1].ToString(), "[+-/*(]+")) {
						equationTextBox.Text += "Sqrt(";
					} else {
						equationTextBox.Text += "*Sqrt(";
					}
				}
			} else {
				equationTextBox.Text += "Sqrt(";
			}

			leftPCount++;
			recEquals = false;
			recOp = false;
		}

		private void logButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text != "") {
				if (equationTextBox.Text[equationTextBox.Text.Length-1] == '.') {
					equationTextBox.Text += "0*Log10(";
				} else {
					if (System.Text.RegularExpressions.Regex.IsMatch(equationTextBox.Text[equationTextBox.Text.Length-1].ToString(), "[+-/*(]+")) {
						equationTextBox.Text += "Log10(";
					} else {
						equationTextBox.Text += "*Log10(";
					}
				}
			} else {
				equationTextBox.Text += "Log10(";
			}

			leftPCount++;
			recEquals = false;
			recOp = false;
		}

		private void button_MouseEnter(object sender, EventArgs e) {
			Button btn = sender as Button;
    		btn.BackColor = System.Drawing.Color.Red;
		}

		private void button_MouseLeave(object sender, EventArgs e) {
			Button btn = sender as Button;
    		btn.BackColor = System.Drawing.Color.Silver;
		}
	}
}