namespace StrangeLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            var input = tbxInput.Text;
            var length = input.Length;

            var lengthOfFirstPart = length / 2;
            var firstPart = input.Substring(0, lengthOfFirstPart);
            var secondPart = input.Substring(lengthOfFirstPart);
            var result = secondPart + firstPart;
            MessageBox.Show(result);
        }
    }
}