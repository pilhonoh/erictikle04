using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKT.Glossary.Type
{
    public class GlossaryGatheringType
    {
        public string GatheringID { get; set; }        
        public string GatheringName { get; set; }
        
        public string UseYN { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditDate { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }        
    }
}
