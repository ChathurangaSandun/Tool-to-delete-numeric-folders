using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tooltodeletenumericfolders
{
    public class Directory 
    {
        private String _directoryName;
        private DateTime _createDateTime;
        private DateTime _modifieDateTime;

        public string DirectoryName
        {
            get
            {
                return _directoryName;
            }

            set
            {
                _directoryName = value;
            }
        }

        public DateTime CreateDateTime
        {
            get
            {
                return _createDateTime;
            }

            set
            {
                _createDateTime = value;
            }
        }

        public DateTime ModifieDateTime
        {
            get
            {
                return _modifieDateTime;
            }

            set
            {
                _modifieDateTime = value;
            }
        }

        public Directory(string directoryName, DateTime createDateTime, DateTime modifieDateTime)
        {
            DirectoryName = directoryName;
            CreateDateTime = createDateTime;
            ModifieDateTime = modifieDateTime;
        }




    }
}
