using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_SV
{
     class QLNV
    {
        private string _id;
        private string _name;
        private DateTime _date;
        private string _address;
        private string _lop;
        private string _DTB;
        public QLNV(string id , string name , DateTime date , string address , string lop , string DTB)
        {
            _id = id;
            _name = name;
            _date = date;
            _address = address;
            _lop = lop;
            _DTB = DTB;
        }
        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Address { get => _address; set => _address = value; }
        public string Class { get => _lop; set => _lop = value; }
        public string DTB { get => _DTB; set => _DTB = value; }
    }
}
