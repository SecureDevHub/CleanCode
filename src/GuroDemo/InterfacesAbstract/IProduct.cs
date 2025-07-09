using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.InterfacesAbstract
{
    internal interface IProduct
    {
        void WarrantyExtension(bool extension);
        void Packaging(bool packing);
        void Insurance(bool insurance);
    }
}
