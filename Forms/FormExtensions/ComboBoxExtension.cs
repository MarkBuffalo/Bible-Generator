using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Forms.FormExtensions
{
    public class ComboBoxExtension
    {
        int Id;
        string DisplayValue;

        public ComboBoxExtension(int _Id, string _DisplayValue)
        {
            Id = _Id;
            DisplayValue = _DisplayValue;
        }

        public int ComboId { get { return Id; } }
        public override string ToString() { return DisplayValue; }
    }
}
