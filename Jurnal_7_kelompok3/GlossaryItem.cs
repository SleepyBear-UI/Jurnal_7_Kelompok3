using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_7_kelompok3
{
    public class GlossaryItem
    {
        public GlossaryItem glosary { get; set; }

    }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }

    }
    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }
    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef Glossdef
    }
}
