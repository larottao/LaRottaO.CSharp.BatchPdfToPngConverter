using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaRottaO.CSharp.BatchPdfToPngConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private OperationsService ops = new OperationsService();

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            executeConversions();
        }

        private Task executeConversions()
        {
            listBoxStatus.Items.Clear();

            return Task.Run(async () =>
            {
                Tuple<Boolean, String> resultSelectFolder = ops.launchSelectFolderDialog();

                if (!resultSelectFolder.Item1)
                {
                    MessageBox.Show(resultSelectFolder.Item2, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Tuple<Boolean, String, List<string>> resultGetPdfFiles = ops.getPdfFilesInPath(resultSelectFolder.Item2);

                if (!resultGetPdfFiles.Item1)
                {
                    MessageBox.Show(resultGetPdfFiles.Item2, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Boolean operationSuccess = true;

                List<Task<Tuple<bool, string>>> conversionTasks = new List<Task<Tuple<bool, string>>>();

                foreach (string pdfFile in resultGetPdfFiles.Item3)
                {
                    var task = ops.convertFileToPdf(
                        pdfFile,
                        Path.Combine(Path.GetDirectoryName(pdfFile),
                        Path.GetFileNameWithoutExtension(pdfFile) + ".png"),
                        Convert.ToInt32(textBoxRequiredDpi.Text));

                    conversionTasks.Add(task);
                }

                await Task.WhenAll(conversionTasks);

                foreach (var result in conversionTasks.Select(task => task.Result))
                {
                    if (!result.Item1)
                    {
                        operationSuccess = false;
                    }

                    listBoxStatus.Invoke((Action)(() =>
                    {
                        listBoxStatus.Items.Add(result.Item2);
                    }));
                }

                if (operationSuccess)
                {
                    System.Diagnostics.Process.Start("explorer.exe", resultSelectFolder.Item2);
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}