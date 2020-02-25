using System;
using System.Collections.Generic;
using System.Text;

namespace app.master.models
{
    public class FileAttach : EntityBase
    {
        public int FileAttachId { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string FileName { get; set; }
        public string Store { get; set; }
        public FileType Type { get; set; }


    }
}
