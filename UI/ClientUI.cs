using System;
using System.Windows.Forms;
using dog_facts_bus.Model;
using dog_facts_bus.Utils;

namespace dog_facts_bus
{
    public partial class ClientUI : Form
    {
        private string inputPath;
        private Sender messageSender;
        private Receiver messageReceiver;
        public ClientUI()
        {
            InitializeComponent();
            messageSender = new Sender();
            messageReceiver = new Receiver();
            tbEndpoint.Text = messageSender.ConnectionString;
        }

        private async void btnStartInput_Click(object sender, EventArgs e)
        {
            if (CheckEmptyTextBox(tbDogFactsInput) == false)
            {
                MessageBox.Show("Please select an input path.");
                return;
            }
            string[] cellValues = UtilsExcel.ReadExcel(inputPath);
            foreach (var cell in cellValues)
            {
                try
                {
                    await messageSender.SendMessage(await UtilsAPI.MakeRequestAsync(cell));
                }
                catch (Exception ex)
                {
                    CheckException(ex);
                }
            }
            MessageBox.Show("Messages sent successfully.");
        }

        private async void btnStartOutput_Click(object sender, EventArgs e)
        {
            if (CheckEmptyTextBox(tbDogFactsOutput) == false || CheckEmptyTextBox(tbOutputFileName) == false)
            {
                MessageBox.Show("Please select an output path and outuput file name.");
                return;
            }
            try
            {
                await messageReceiver.ReceiveMessages();
            }
            catch (Exception ex)
            {
                CheckException(ex);
            }
            MessageBox.Show("Successfully received messages.");
        }

        private void pbSelectInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel File (*.xlsx) | *.xlsx";
                if (ofd.ShowDialog() == DialogResult.OK && string.IsNullOrEmpty(ofd.FileName) == false)
                {
                    inputPath = ofd.FileName;
                    tbDogFactsInput.Text = ofd.FileName;
                }
            }
        }

        private void pbSelectOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && string.IsNullOrEmpty(fbd.SelectedPath) == false)
                {
                    UtilsExcel.outputPath = fbd.SelectedPath;
                    tbDogFactsOutput.Text = UtilsExcel.outputPath;
                }
            }
        }

        private bool CheckEmptyTextBox(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text) == true)
            {
                return false;
            }
            return true;
        }

        private static void CheckException(Exception ex)
        {
            if (ex is UriFormatException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Invalid endpoint. Please enter a valid endpoint.");
            }
            else
            {
                throw ex;
            }
        }

        private void tbEndpoint_TextChanged(object sender, EventArgs e)
        {
            messageSender.ConnectionString = tbEndpoint.Text;
            messageReceiver.ConnectionString = tbEndpoint.Text;
        }

        private void tbOutputFileName_TextChanged(object sender, EventArgs e)
        {
            UtilsExcel.SetOutputFileName(tbOutputFileName.Text);
        }

    }
}
