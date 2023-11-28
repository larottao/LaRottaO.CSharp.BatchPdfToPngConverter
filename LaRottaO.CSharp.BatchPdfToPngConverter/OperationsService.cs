using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaRottaO.CSharp.BatchPdfToPngConverter
{
    internal class OperationsService : IOperations
    {
        public async Task<Tuple<bool, string>> convertFileToPdf(string pdfFilePath, string pngFilePath, int desiredDpi)
        {
            try
            {
                using (var document = PdfDocument.Load(pdfFilePath))
                {
                    for (int index = 0; index < document.PageCount; index++)
                    {
                        var image = document.Render(index, desiredDpi, desiredDpi, PdfRenderFlags.CorrectFromDpi);
                        image.Save(pngFilePath + "_page_" + index + 1.ToString("000") + Path.GetExtension(pngFilePath), ImageFormat.Png);
                    }
                }

                return new Tuple<bool, string>(true, pdfFilePath + " Conversion successful.");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, pdfFilePath + " Conversion failed: " + ex.ToString());
            }
        }

        public Tuple<Boolean, String, List<string>> getPdfFilesInPath(String path)
        {
            try
            {
                if (!Path.HasExtension("*.pdf"))
                {
                    return new Tuple<Boolean, String, List<String>>(false, "No pdf files in folder", new List<String>());
                }

                return new Tuple<Boolean, String, List<String>>(true, "", Directory.GetFiles(path, "*.pdf").ToList<String>());
            }
            catch (Exception ex)
            {
                return new Tuple<Boolean, String, List<String>>(false, "Unable to get pdf files in folder: " + ex.ToString(), new List<String>());
            }
        }

        public Tuple<Boolean, String> launchSelectFolderDialog()
        {
            try
            {
                string folderPathSelectedByUser = null;
                var t = new Thread((ThreadStart)(() =>
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                    folderBrowserDialog.ShowDialog((new Form() { TopMost = true }));

                    folderPathSelectedByUser = folderBrowserDialog.SelectedPath;
                }));

                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();

                if (String.IsNullOrEmpty(folderPathSelectedByUser))
                {
                    return new Tuple<Boolean, String>(false, "No folder selected by user.");
                }

                return new Tuple<Boolean, String>(true, folderPathSelectedByUser);
            }
            catch (Exception ex)
            {
                return new Tuple<Boolean, String>(false, "Unable to launch select folder dialog: " + ex.ToString());
            }
        }
    }
}