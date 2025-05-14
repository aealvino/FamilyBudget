namespace FamilyBudget
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            var testButton = new Button
            {
                Text = "Тест исключения",
                Location = new Point(10, 10),
                Size = new Size(150, 30)
            };

            testButton.Click += TestButton_Click;

            Controls.Add(testButton);
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            throw new Exception("Тестовое исключение, которое не будет прерывать выполнение.");
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
