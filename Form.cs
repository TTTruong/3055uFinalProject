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

		private void zeroButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "0";
		}

		private void oneButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "1";
		}

		private void twoButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "2";
		}

		private void threeButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "3";
		}

		private void fourButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "4";
		}

		private void fiveButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "5";
		}

		private void sixButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "6";
		}

		private void sevenButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "7";
		}

		private void eightButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "8";
		}

		private void nineButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += "9";
		}

		private void decimalButton_Click(object sender, EventArgs e) {
			equationTextBox.Text += ".";
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void clearButton_Click(object sender, EventArgs e) {
			equationTextBox.Text = "";
		}

		private void backButton_Click(object sender, EventArgs e) {
			equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
		}

		private void button20_Click(object sender, EventArgs e) {

		}
	}
}
