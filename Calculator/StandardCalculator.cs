/**
 * Robbie Biesser
 * CIS317
 * 
 * StandardCalculator.cs
 * Implementation of a basic calculator using .NET Framework for Window Forms
 *
 * Version 1.0.0: 12/15/2019
 * Version 1.1.0: 1/24/2020
 *      - Removed/Hid History feature
 *      - fixed Multi-multiplication operation
 *
 * Required Features:
 * - Contain a logo
 * - Add, subtract, mulitply, divide
 * - Account for division by zero
 * - Show at least two decimal places
 * - Retain the last calculation after window closes
 * - Have a memory so user can store and recall values
 * - Operate with a mouse clicking buttons
 * - Operate with a keyboard only
 * - Contain a clear and clear all button
 * - Display window updates with key presses and calculations
 * 
 * We determined these functions were not necessary,
 * Removed Features:
 * - Retain the last calculation after window closes
 * - Have a memory so user can store and recall values
 *
 * Additional Features:
 * - Can enter negative values
 * - Keeps track of the current operation maintaining operator precedence
 * - Pressing the Equals button starts a new operation
 * 
 *
 * TODO:
 * - Retain the last calculation - implement with the History feature (Required)
 * - Memory feature (Required), will be using memory and history
 * - History
 *      - clear history is specific to history
 *      - explore visual elements to be used for adding and selecting history items
 * - I'm not happy with the current History feature, so it is hidden until further testing.
 *      - Expand the window size to the right.
 *      
 * - Need to implement Unit Testing for CI/CD
 *
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class StandardCalculator : Form
    {
        
        // private variables used to track the state of the input
        private bool isNewOperation = true;
        private bool isNewOperand = true;

        /*
         * constructor
         */
        public StandardCalculator()
        {
            InitializeComponent();

            lblOperation.Text = ""; // clear placeholder text

            // update math operator buttons with Unicode character
            btnAdd.Text = Unicode.PLUS_SIGN.ToString(); // "\u002B";
            btnMultiply.Text = Unicode.MULTIPLICATION_SIGN.ToString(); // "\u00D7";
            btnDivide.Text = Unicode.DIVISION_SIGN.ToString(); //  "\u00F7";
            btnSubtract.Text = Unicode.MINUS_SIGN.ToString(); // "\u2212";
            btnEquals.Text = Unicode.EQUALS_SIGN.ToString(); // "\u003D";
            btnPlusMinus.Text = Unicode.PLUS_MINUS_SIGN.ToString(); // "\u00B1";
        }

        /*
         * An operand is on either side of an operation
         * https://www.computerhope.com/jargon/o/operand.htm
         */
        private void updateOperand(char c)
        {
            // reset current operation list after an equals
            if (isNewOperation) {
                lblOperation.Text = "";
            }

            // 0 is a special case, 000 is the same as 0 so don't update
            // note that pressing 0 in a new operation appears similar to the clear button
            //  since you can change a single zero operand to anything else
            if (c == '0' && isNewOperand) {
                lblOperand.Text = "0"; // only allowed to set zero if new operand
                return;
            }

            // period is a special case, there is only one period per operand
            if (c == '.') {
                if (lblOperand.Text.IndexOf('.') > -1)
                    return; // if it already exists, just return
                if (isNewOperand) {
                    isNewOperand = false; // for a decimal starting with zero
                }
            }

            // the negative sign is special case
            // negative numbers are indicated with minus
            if (c == Unicode.PLUS_MINUS_SIGN) {
                // check if it already exists
                if (lblOperand.Text.IndexOf('-') > -1) {
                    // remove the negative sign
                    lblOperand.Text = lblOperand.Text.Substring(1); // skip the first character
                    return;
                }
                else {
                    // zero cannot be negative
                    if (double.Parse(lblOperand.Text) != 0) {
                        // add a negative sign to the front
                        lblOperand.Text = "-" + lblOperand.Text;
                    }
                    return;
                }
            }

            if (isNewOperand) {
                // clear current and set to new KeyPress/ButtonClick value
                lblOperand.Text = c.ToString();
                isNewOperand = false;
            }
            else {
                lblOperand.Text += c.ToString(); // append to operand
            }

            // update the state variables
            isNewOperation = false;
            btnClear.Text = "CE";
        }

        /**
         * Should only be called by an operator button
         * https://www.computerhope.com/jargon/o/operand.htm
         */
        private void updateOperation(char c)
        {
            if (isNewOperation) {
                // clear current and set to new KeyPress/ButtonClick value
                lblOperation.Text = lblOperand.Text + " " + c.ToString() + " ";
            }
            else {
                // append to operation
                lblOperation.Text += lblOperand.Text + " " + c.ToString() + " ";
            }

            // only equals and clear starts a new operation
            if (c == Unicode.EQUALS_SIGN) {
                // if equals is following a previous operation, should it clear the last operation?
                isNewOperation = true;
            }
            else {
                isNewOperation = false;
            }

            isNewOperand = true; // expect that the next digit starts a new operand

            // parse the current operation and update the operand/result text
            // trim off the last operation to make the operands even
            // Length-3 is the two extra spaces and the operation
            lblOperand.Text = calculate(lblOperation.Text.Substring(0, lblOperation.Text.Length-3));
        }

        /**
         * The current calculation is made for every change to an operation or an equal operation
         *
         * Performs the calculation in the operations list following proper order of operations
         *
         *  2 + 2 * 3 + 2 * 10 = 28 , incorrect: 140
         *
         *  there are no parentheses or exponents in the standard calculator, so just need to find 
         *  multiplication or division and do those first, then do addition and subtraction.
         *
         *  the updateOperation method already makes sure that we have a string with space separated 
         *  operands and operations
         *
         *  2 * 2 * 2 * 2 * 2 = 32
         * 
         * When a calculation returns a negative number it is displayed with a minus sign and no space,
         * allowing it to be interpreted correctly if the result is used for the next calculation.
         *
         * There may be many algorithms to perform a calculation and some may be proven to be easier to 
         * extend when adding new operations. This current method runs through the entire operation list
         * twice. 
         */
        private string calculate( string curOperation) 
        {
            char[] operatorsMD = {Unicode.MULTIPLICATION_SIGN, Unicode.DIVISION_SIGN};
            char[] operatorsAS = {Unicode.PLUS_SIGN, Unicode.MINUS_SIGN};

            
            double result = 0; // the result is returned as a string

            // use ArrayList so you can use the RemoveAt method
            ArrayList operations = new ArrayList(curOperation.Split(' '));
            
            // need at least two operands to make an operation
            if (operations.Count > 2) 
            {
                // loop through the entire operation
                for(int i = 0; i < operations.Count - 1; i++)
                {
                    // mulitplication and division are at the same precedence
                    if ( operations[i].ToString() == Unicode.MULTIPLICATION_SIGN.ToString()) 
                    {
                        // multiply the left operand by the right operand
                        // and store back to left operand
                        result = Double.Parse(operations[i-1].ToString()) * 
                                    Double.Parse(operations[i+1].ToString());
                        operations[i-1] = result.ToString();
                        
                        operations.RemoveAt(i + 1); // delete the right operand and previous operator
                        operations.RemoveAt(i);

                        i--; // check the last index again
                    }
                    else if ( operations[i].ToString() == Unicode.DIVISION_SIGN.ToString()) 
                    {
                        // cannot divide by zero
                        try {
                            // multiply the left operand by the right operand
                            // and store back to left operand
                            result = Double.Parse(operations[i-1].ToString()) / 
                                        Double.Parse(operations[i+1].ToString());
                            operations[i-1] = result.ToString();
                            
                            operations.RemoveAt(i + 1); // delete the right operand and previous operator
                            operations.RemoveAt(i);

                            i--; // check the last index again
                        }
                        catch (DivideByZeroException) {
                            // double actually handles divide by zero with infinity
                            // int throws cannot divide by zero exception
                            return "Cannot divide by zero";
                        }
                    }
                }

                // the operations list should now only contain addition or subtraction operations
                for(int i = 0; i < operations.Count - 1; i++)
                {
                    // addition and subtraction are at the same precedence
                    if ( operations[i].ToString() == Unicode.PLUS_SIGN.ToString()) 
                    {
                        // add the left operand and the right operand
                        // and store back to left operand
                        result = Double.Parse(operations[i-1].ToString()) +
                                    Double.Parse(operations[i+1].ToString());
                        operations[i-1] = result.ToString();
                        
                        operations.RemoveAt(i + 1); // delete the right operand and previous operator
                        operations.RemoveAt(i);

                        i--; // check the last index again
                    }
                    else if ( operations[i].ToString() == Unicode.MINUS_SIGN.ToString()) 
                    {
                        // subtract the right operand from the left operand
                        // and store back to left operand
                        result = Double.Parse(operations[i-1].ToString()) -
                                    Double.Parse(operations[i+1].ToString());
                        operations[i-1] = result.ToString();
                        
                        operations.RemoveAt(i + 1); // delete the right operand and previous operator
                        operations.RemoveAt(i);

                        i--; // check the last index again
                    }
                }
            }
            else {
                result = Double.Parse(operations[0].ToString());
            }

            return result.ToString();
        }

        private void updateHistory() {
            // tbHistory.Text += "\n" + lblOperation.Text;
            lvHistory.Items.Add(lblOperation.Text + lblOperand.Text);

        }

        /***********************************************************
         * 
         * ui button click events
         *
         ***********************************************************/
        private void btnEquals_Click(object sender, EventArgs e)
        {
            // updateOperation handles any necessary logic
            updateOperation(Unicode.EQUALS_SIGN);

            // update history handles saving to file
            updateHistory();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (btnClear.Text == "C") 
            {
                lblOperation.Text = ""; // clear the current operation
                                        // lblResult should already be 0
                isNewOperation = true;
            }
            else
            {
                lblOperand.Text = "0";
                btnClear.Text = "C"; // reset clear button
            }

            isNewOperand = true;
            lblOperand.Focus();
        }

        /** 
         * Keyboard entry
         */
        private void StandardCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * Set KeyPreview on the Form = true
             * Set KeyPress Event to StandardCalculator_KeyPress
             * https://stackoverflow.com/questions/19905555/c-sharp-key-pressed-listener-in-a-windows-forms-usercontrol
             */

            // array of allowed math operations from KeyPress, all others ignored
            char[] operators = { '*', '/', '+', '-', '=' };

            // a decimal point is a special case, there should only be one decimal per operand
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                // updateOperand handles any necessary logic
                updateOperand(e.KeyChar);
            }
            else if (Array.IndexOf(operators, e.KeyChar) >= 0)
            {
                // convert KeyChar to its Unicode equivalent
                switch (e.KeyChar)
                {
                    case '*':
                        updateOperation(Unicode.MULTIPLICATION_SIGN);
                        break;
                    case '/':
                        updateOperation(Unicode.DIVISION_SIGN);
                        break;
                    case '+':
                        updateOperation(Unicode.PLUS_SIGN);
                        break;
                    case '-':
                        updateOperation(Unicode.MINUS_SIGN);
                        break;
                    case '=':
                        updateOperation(Unicode.EQUALS_SIGN);
                        break;
                    default:
                        MessageBox.Show(e.KeyChar.ToString());
                        break;
                }
            }
            else {
                // check the console for output
                Debug.WriteLine(e.KeyChar.ToString());
            }
        }
        
        private void lblHistory_Click(object sender, EventArgs e)
        {
            pHistory.Visible = true;
        }

        private void lblMemory_Click(object sender, EventArgs e)
        {
            pHistory.Visible = false;
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lvHistory.Items.Clear();
            lblOperand.Focus();
        }

        private void lvHistory_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(sender.ToString());
            Debug.WriteLine(e.ToString());

        }

        /***********************************************************
         * 
         * digit button click events
         * lblOperand.Focus(); resets the focus to the Equals button
         *
         ***********************************************************/

        private void btn0_Click(object sender, EventArgs e)
        {
            updateOperand('0');
            lblOperand.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            updateOperand('1');
            lblOperand.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            updateOperand('2');
            lblOperand.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            updateOperand('3');
            lblOperand.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            updateOperand('4');
            lblOperand.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            updateOperand('5');
            lblOperand.Focus();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            updateOperand('6');
            lblOperand.Focus();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            updateOperand('7');
            lblOperand.Focus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            updateOperand('8');
            lblOperand.Focus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            updateOperand('9');
            lblOperand.Focus();
        }


        /***********************************************************
         * 
         * operator button click events
         * lblOperand.Focus(); resets the focus to the Equals button
         *
         ***********************************************************/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateOperation(Unicode.PLUS_SIGN);
            lblOperand.Focus();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            updateOperation(Unicode.MINUS_SIGN);
            lblOperand.Focus();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            updateOperation(Unicode.MULTIPLICATION_SIGN);
            lblOperand.Focus();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            updateOperation(Unicode.DIVISION_SIGN);
            lblOperand.Focus();
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            updateOperand('.');
            lblOperand.Focus();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            updateOperand(Unicode.PLUS_MINUS_SIGN);
            lblOperand.Focus();
        }
    }
}
