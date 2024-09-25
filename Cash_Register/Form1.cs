namespace Cash_Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double item1CostVar = 2.17;
        const double item2CostVar = 3.25;
        const double item3CostVar = 10.00;
        double item1Output;
        double item2Output;
        double item3Output;
        double subOutput;
        double taxOutput;
        double totalOutput;
        bool err;
        const int timerVal = 500;


        private void calcButton_Click(object sender, EventArgs e)
        {
            int timeSec = DateTime.Now.Second;
            int timeMin = DateTime.Now.Minute;
            int timeHrr = DateTime.Now.Hour;
            int timeDay = DateTime.Now.Day;
            int timeMnt = DateTime.Now.Month;
            int timeYrr = DateTime.Now.Year;
            string dateOutput = $"{timeHrr}h{timeMin}m{timeSec}s    {timeDay}/{timeMnt}/{timeYrr}";
            err = false;


            if (err == false)
            {
                titleLabel.Text = "Cash Register";
            }

            try
            {
                double item1Val1 = Convert.ToDouble(item1Val.Text);
                double item2Val1 = Convert.ToDouble(item2Val.Text);
                double item3Val1 = Convert.ToDouble(item3Val.Text);
                item1Amnt.Text = $"Item1 ({item1Val1}x)";
                item2Amnt.Text = $"Item2 ({item2Val1}x)";
                item3Amnt.Text = $"Item3 ({item3Val1}x)";
                item1Output = item1Val1 * item1CostVar;
                item2Output = item2Val1 * item2CostVar;
                item3Output = item3Val1 * item3CostVar;
                subOutput = item1Output + item2Output + item3Output;
                taxOutput = (subOutput * 1.13) - subOutput;
                totalOutput = subOutput + taxOutput;
                item1Cost.Text = item1Output + "";
                item2Cost.Text = item2Output + "";
                item3Cost.Text = item3Output + "";
                subvalLabel.Text = subOutput + "";
                taxvalLabel.Text = taxOutput + "";
                totalvalLabel.Text = totalOutput + "";
            }
            catch
            {
                titleLabel.Text = "Error";
                err = true;
                while (err == true) { 
                    titleLabel.BackColor = Color.White;
                    titleLabel.ForeColor = Color.Black;
                    Thread.Sleep(timerVal);
                    Refresh();
                    titleLabel.BackColor = Color.Black;
                    titleLabel.ForeColor = Color.White;
                    Thread.Sleep(timerVal);
                    Refresh();
                }

            }
        }
    }
}