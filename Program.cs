using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication10
{
    public class Program
    {
        private string der;
        private string hans;
        private int goal;

        public string Der
        {
            get
            {
                return der;
            }

            set
            {
                der = value;
            }
        }

        public string Hans
        {
            get
            {
                return hans;
            }

            set
            {
                hans = value;
            }
        }

        public int Goal
        {
            get
            {
                return goal;
            }

            set
            {
                goal = value;
            }
        }

        static void Main(string[] args)
        {
            Program der = new Program();
            der.Der = "hans";
            der.Goal = 2;
            der.Hans = "der";
            XmlSerializer serialize = new XmlSerializer(der.GetType());
            using (StreamWriter writer = new StreamWriter(@"c:\Test\car.xml"))
            {
                serialize.Serialize(writer,der);
            }
            using (StreamReader reader = new StreamReader(@"c:\Test\car.xml"))
            {
                reader.ReadAsync()
            }
        }
    }
}
