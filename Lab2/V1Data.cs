using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    abstract class V1Data
    {
        public string data { set; get; }
        public DateTime date { set; get; }

        public V1Data()
        {

        }
        public V1Data(string new_data, DateTime new_date)
        {
            data = new_data;
            date = new_date;
        }

        public abstract float[] NearZero(float eps);
        public abstract string ToLongString();
        public override string ToString()
        {
            return "data is:" + data + "\ndate is: " + date;
        }
        public abstract string ToLongString(string format);
    }
}