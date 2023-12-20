using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient
{
    public partial class Form1 : Form
    {
        private const string Address = "https://localhost:7114/";
        private readonly Register.RegisterClient _client;

        public Form1()
        {
            InitializeComponent();

            var channel = GrpcChannel.ForAddress(Address);
            _client = new Register.RegisterClient(channel);
        }

        private async void reverseBtn_Click(object sender, EventArgs e)
        {
            var textToChange = new RegisterRequest
            {
                TextToChange = textBox5.Text
            };

            var reply = await RegisterReply(textToChange);

            textBox3.Text = reply.ChangedUp;
            textBox4.Text = reply.ChangedDown;
        }

        private async Task<RegisterReply> RegisterReply(RegisterRequest textToChange)
        {
            var reply = await _client.ChangeRegisterAsync(textToChange);
            return reply;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
