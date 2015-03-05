using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class ListVersion
    {
        List<Notary> _List;
        string _NameOfVersion;
        public List<Notary> GetList
        {
            get
            {
                return _List;
            }
        }
        public string GetNameOfVersion
        {
            get
            {
                return _NameOfVersion;
            }
        }
        public ListVersion(string name, List<Notary> list)
        {
            _List = list;
            _NameOfVersion = name;
        }
        public override string ToString()
        {
            return _NameOfVersion;
        }
    }
}
