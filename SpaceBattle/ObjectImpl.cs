using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle
{
    public class ObjectImpl : IUObject
    {
        Dictionary<string, object> values = new Dictionary<string, object>();

        public object GetProperty(string propName)
        {
            values.TryGetValue(propName, out var value);
            return value;
        }

        public void SetProperty(string propName, object newVal)
        {
            values.TryAdd(propName, newVal);
        }
    }
}
