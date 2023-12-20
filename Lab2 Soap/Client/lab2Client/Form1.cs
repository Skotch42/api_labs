using SoapServiceReference;

namespace lab2Client
{
    public partial class Form1 : Form
    {
        private ISoapService _soapServiceChannel;

        public Form1()
        {
            _soapServiceChannel =
                new SoapServiceClient(SoapServiceClient.EndpointConfiguration.BasicHttpBinding_ISoapService_soap);


            InitializeComponent();
        }

        private async void reverseBtn_Click(object sender, EventArgs e)
        {
            string words = inputField.Text;

            var stringResponse = await _soapServiceChannel.StringToUpperAsync(new StringToUpperRequest()
            {
                Body = new StringToUpperRequestBody()
                {
                    words = words
                }
            });

            outputLabelWords.Text = stringResponse.Body.StringToUpperResult;

            var charResponse = await _soapServiceChannel.StringToLowerAsync(new StringToLowerRequest()
            {
                Body = new StringToLowerRequestBody()
                {
                    words = words
                }
            });

            outputLabelChars.Text = charResponse.Body.StringToLowerResult;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
