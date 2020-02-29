using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace app.master.models
{
    public class FileAttach : EntityBase
    {
        public FileAttach()
        {
            Type = FileType.Undefined;
        }
        public int FileAttachId { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string FileName { get; set; }
        public string Store { get; set; }
        public FileType Type { get; set; }

        public Product Product { get; set; }

    }
}
