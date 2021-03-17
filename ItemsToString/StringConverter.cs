using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsToString
{


    public class StringConverter
    {
        private readonly object[] _objectArray;

        public StringConverter(object[] objectArray)
        {
            _objectArray = objectArray;
        }

        public string[] ConvertToString()
        {
            var stringList = new List<string>();
            foreach (var element in _objectArray)
            {
                stringList.Add(element.ToString());
            }
            return stringList.ToArray();
        }
    }
}
