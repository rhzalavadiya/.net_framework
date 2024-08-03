using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomerBill
{
    internal class Customer
    {
        private String _cname;
        private int _unit;
        private float _TotalBill;
        private String _output;
        public void SetName(String cname)
        {
            _cname = cname;
        }
        public int Units
        {
            set
            {
                _unit = value;
            }
        }
        public void CalculateTotalBill()
        {
            _TotalBill = 0;
            if (_unit <= 100) 
            {
                _TotalBill = _unit * 2.5f;
                _output=_unit.ToString()+"* 2.5 = "+ _TotalBill.ToString()+"\n";
            }
            else  if (_unit <= 300)
            {
                _TotalBill = 250 + (_unit - 100) * 3.5f;
                _output = "100 * 2.5 = 250\n" +(_unit-100).ToString()+" * 3.5 = "+ _TotalBill.ToString() + "\n";

            }
            else if (_unit > 300) 
            {
                _TotalBill = 250 + 700 + (_unit - 300) * 4.5f;
                _output = "100 * 2.5 = 250\n200 * 2.5 = 700 \n" + (_unit - 300).ToString() + " * 4.5 = " + _TotalBill.ToString() + "\n";
            }
        }
        public Tuple<String, int,String, float> GetData()
        {
            return new Tuple<String, int, String,float>(_cname, _unit,_output,_TotalBill);
        }

    }
}
