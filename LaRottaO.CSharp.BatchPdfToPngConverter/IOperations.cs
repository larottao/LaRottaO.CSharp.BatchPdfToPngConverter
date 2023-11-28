using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaRottaO.CSharp.BatchPdfToPngConverter
{
    internal interface IOperations
    {
        Tuple<Boolean, String> launchSelectFolderDialog();

        Tuple<Boolean, String, List<String>> getPdfFilesInPath(String path);

        Task<Tuple<Boolean, String>> convertFileToPdf(String pdfFilePath, String pngDestinationPath, int desiredDpi);
    }
}