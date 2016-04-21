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
		}

		private void number(string num) {
			if (recEquals) {
				equationTextBox.Text = num;
				recEquals = false;
			} else {
				if (equationTextBox.Text != "" && equationTextBox.Text[equationTextBox.Text.Length-1] == ')') {
					equationTextBox.Text += "*";
				}
				equationTextBox.Text += num;
			}
			recOp = false;
		}

		private void operation(string op) {
			if (equationTextBox.Text == "" || equationTextBox.Text == "Undefined" || equationTextBox.Text == "Overflow") {
				equationTextBox.Text = "0" + op;
				//equationTextBox.Text = "0{op}";
				recEquals = false;
				recOp = true;
			} else {
				if (recOp) {
					equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
				}
				if (equationTextBox.Text[equationTextBox.Text.Length-1] != '(' &&
					equationTextBox.Text[equationTextBox.Text.Length-1] != '.') {

					equationTextBox.Text += op;
					recEquals = false;
					recOp = true;
				} else {
					equationTextBox.Text += "0" + op;
					//equationTextBox.Text += "0{op}";
					recEquals = false;
					recOp = true;
				}
			}
		}

		private void specConstant(string constant) {
			if (equationTextBox.Text == "" || recEquals) {
				equationTextBox.Text = "(" + constant + ")";
				//equationTextBox.Text = "({constant})";
				recEquals = false;
			} else {
				if (!(recOp || equationTextBox.Text[equationTextBox.Text.Length-1] == '(')) {
					equationTextBox.Text += "*";
				}
					equationTextBox.Text += "(" + constant + ")";
					//equationTextBox.Text += "({constant})";
			}
			recOp = false;
		}

		private void specOperator(string specOp) {
			if (equationTextBox.Text != "") {
				if (equationTextBox.Text[equationTextBox.Text.Length-1] == '.') {
					equationTextBox.Text += "0*" + specOp;
					//equationTextBox.Text += "0*{specOp}";
				} else {
					if (recOp || equationTextBox.Text[equationTextBox.Text.Length-1] == '(') {
						equationTextBox.Text += specOp;
					} else {
						equationTextBox.Text += "*" + specOp;
						//equationTextBox.Text += "*{specOp}";
					}
				}
			} else {
				equationTextBox.Text += specOp;
			}

			leftPCount++;
			recEquals = false;
			recOp = false;
		}

		private void Calculator_Load(object sender, EventArgs e) {

		}

		private void zeroButton_MouseClick(object sender, MouseEventArgs e) {
			number("0");
		}

		private void oneButton_MouseClick(object sender, MouseEventArgs e) {
			number("1");
		}

		private void twoButton_MouseClick(object sender, MouseEventArgs e) {
			number("2");
		}

		private void threeButton_MouseClick(object sender, MouseEventArgs e) {
			number("3");
		}

		private void fourButton_MouseClick(object sender, MouseEventArgs e) {
			number("4");
		}

		private void fiveButton_MouseClick(object sender, MouseEventArgs e) {
			number("5");
		}

		private void sixButton_MouseClick(object sender, MouseEventArgs e) {
			number("6");
		}

		private void sevenButton_MouseClick(object sender, MouseEventArgs e) {
			number("7");
		}

		private void eightButton_MouseClick(object sender, MouseEventArgs e) {
			number("8");
		}

		private void nineButton_MouseClick(object sender, MouseEventArgs e) {
			number("9");
		}

		private void decimalButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "0.";
				recEquals = false;
			} else {
				if (recOp || equationTextBox.Text == "" || equationTextBox.Text[equationTextBox.Text.Length-1] == '(') {
					equationTextBox.Text += "0.";
				} else {

					int prevCounter = equationTextBox.Text.Length-1;
					bool validDec = true;

					while (prevCounter >= 0) {
						if (Regex.IsMatch(equationTextBox.Text[prevCounter].ToString(), "[.]+")) {
							validDec = false;
							break;
						} else if (!Regex.IsMatch(equationTextBox.Text[prevCounter].ToString(), "[0123456789]+")) {
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

			equationTextBox.SelectionAlignment = HorizontalAlignment.Right;
		}

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
					if (recOp || equationTextBox.Text[equationTextBox.Text.Length-1] == '(' ||
						         equationTextBox.Text[equationTextBox.Text.Length-1] == '.') {
						equationTextBox.Text += "0";
					}
	
					for (int i=rightPCount; i < leftPCount; i++) {
						equationTextBox.Text += ")";
					}
	
					NCalc.Expression exp = new NCalc.Expression(equationTextBox.Text);
					var v = exp.Evaluate();
	
					if (v.ToString() == "Infinity" || v.ToString() == "NaN") {
						equationTextBox.Text = "Undefined";
					} else {
						equationTextBox.Text = v.ToString();
					}
				}
			} catch (Exception except) {
				Console.Write("Error: " + except.GetType() + "\n");
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
						if (!Regex.IsMatch(equationTextBox.Text[equationTextBox.Text.Length-1].ToString(), "[+-/*]+")) {
	          				recOp = true;
     					} else {
     						recOp = false;
     					}
     				}
				}
			}
		}

		private void additionButton_MouseClick(object sender, MouseEventArgs e) {
			operation("+");
		}

		private void subtractButton_MouseClick(object sender, MouseEventArgs e) {
			operation("-");
		}

		private void multiplyButton_MouseClick(object sender, MouseEventArgs e) {
			operation("*");
		}

		private void divideButton_MouseClick(object sender, MouseEventArgs e) {
			operation("/");
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
				if (equationTextBox.Text != "" && !(recOp || equationTextBox.Text[equationTextBox.Text.Length-1] == '(')) {
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

				if (recOp || equationTextBox.Text[equationTextBox.Text.Length-1] == '(') {
					equationTextBox.Text += "0";
				}

				equationTextBox.Text += ")";

				rightPCount++;
				recEquals = false;
				recOp = false;
			}
		}

		private void piButton_MouseClick(object sender, MouseEventArgs e) {
			specConstant("3.14159");
		}

		private void eulerButton_MouseClick(object sender, MouseEventArgs e) {
			specConstant("2.718");
		}

		private void squareRootButton_MouseClick(object sender, MouseEventArgs e) {
			specOperator("Sqrt(");
		}

		private void logButton_MouseClick(object sender, MouseEventArgs e) {
			specOperator("Log10(");
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