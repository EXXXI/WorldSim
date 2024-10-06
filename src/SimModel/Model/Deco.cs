using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimModel.Model
{
    public class Deco : Equipment
    {
        public Deco(EquipKind kind) : base(kind)
        {
        }

        public int DecoCount { get; set; }

        public string DecoCateory { get; set; }
    }
}
