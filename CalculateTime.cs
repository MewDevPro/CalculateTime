using System;
using System.Windows.Forms;

namespace CalculateTime
{
    public partial class CalculateTime : Form
    {
        private uint _oldInput = 0;
        public CalculateTime()
        {
            InitializeComponent();
        }

        private uint GetOldInput()
        {
            return _oldInput;
        }

        private void SetOldInput(uint oldInput)
        {
            _oldInput = oldInput;
        }

        private void ClearResult()
        {
            outputDate.Clear();
        }

        private void ClearInput()
        {
            inputSeconds.Clear();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            _ = Calc();
        }

        private void UseFullTime_CheckedChanged(object sender, EventArgs e)
        {
            _ = Calc();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ClearResult();
            ClearInput();
        }

        private void InputSeconds_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9
                || e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                && e.KeyCode != Keys.Enter)
            {
                e.SuppressKeyPress = false;
                return;
            }
            else
            {
                e.SuppressKeyPress = Calc();
                return;
            }
        }

        private void UseFullTime_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = Calc();
            return;
        }

        private bool Calc()
        {
            ClearResult();
            if (!uint.TryParse(inputSeconds.Text, out _) || uint.Parse(inputSeconds.Text) == 0)
            {
                _ = MessageBox.Show(inputSeconds.Text + " không phải là số nguyên dương lớn hơn 0 hoặc quá dài.", "Lỗi");
                SetOldInput(GetOldInput());
                inputSeconds.Text = _oldInput == 0 ? "" : GetOldInput().ToString();
                return false;
            }
            uint parsed = uint.Parse(inputSeconds.Text);

            Controller calc = new Controller(parsed, useFullTime.Checked);
            outputDate.Text = calc.Converter();
            SetOldInput(parsed);
            return true;
        }
    }
}

