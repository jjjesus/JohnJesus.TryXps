using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Xps.Packaging;
using System.Windows.Documents;

namespace JohnJesus.TryXps
{
    public class MainWindowViewModel
    {
        public FixedDocumentSequence Document { get; set; }
        public string DocDir { get; set; }
        public string Filename { get; set; }
        public string Filepath { get; set; }

        public MainWindowViewModel()
        {
            Configure();
            var doc = new XpsDocument(this.Filepath, System.IO.FileAccess.Read);
            this.Document = doc.GetFixedDocumentSequence();
        }

        public void Configure()
        {
            this.DocDir = "Data";
            this.Filename = "HelloWorld.xps";
            this.Filepath= this.DocDir + System.IO.Path.DirectorySeparatorChar + this.Filename;

        }
    }
}
