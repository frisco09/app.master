using System;
using System.Collections.Generic;
using System.Text;

namespace app.master.models
{
    public class EntityBase
    {
        public long? CreatorUserId { get; set; }

        public DateTime CreationTime { get; set; }

        public long? LastModifierUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public long? DeleterUserId { get; set; }

        public DateTime? DeletionTime { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
