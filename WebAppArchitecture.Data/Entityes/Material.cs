using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppArchitecture.Data.Entityes
{
    internal class Material
    {
        public int MaterialId { get; set; }
        public int DirectoryId { get; set; }
        public Directory Directory { get; set; }
    }
}
