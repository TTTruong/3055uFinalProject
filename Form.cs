using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication {

	public partial class Calculator : Form {

		public Calculator() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void zeroButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "0";
		}

		private void oneButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "1";
		}

		private void twoButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "2";
		}

		private void threeButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "3";
		}

		private void fourButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "4";
		}

		private void fiveButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "5";
		}

		private void sixButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "6";
		}

		private void sevenButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "7";
		}

		private void eightButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "8";
		}

		private void nineButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += "9";
		}

		private void decimalButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text += ".";
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void clearButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text = "";
		}

		private void backButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text != "") {
				equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
			}
		}

		private void additionButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0+";
			} else {
				equationTextBox.Text += "+";
			}
		}

		private void subtractButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0-";
			} else {
				equationTextBox.Text += "-";
			}
		}

		private void multiplyButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0x";
			} else {
				equationTextBox.Text += "x";
			}
		}

		private void divideButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0÷";
			} else {
				equationTextBox.Text += "÷";
			}
		}

		private void wolframButton_MouseClick(object sender, MouseEventArgs e) {

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
