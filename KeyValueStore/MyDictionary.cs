using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    public struct KeyValue
    {
        public KeyValue(string key, object value)
        {
            this.Key = key;
            this.Value = value;
        }
        public readonly string Key;
        public readonly object Value;
    }

    public class MyDictionary
    {
        KeyValue[] structArray = new KeyValue[5];
        int count = 0;
        public object this[string index]
        {
            get
            {
                for (int i = 0; i < structArray.Length; i++)
                {
                    if (structArray[i].Key == index)
                        return structArray[i].Value;
                }
                throw new KeyNotFoundException(index);
            }
            set
            {
                for (int i = 0; i < structArray.Length; i++)
                {
                    if (structArray[i].Key == index)
                    {
                        structArray[i] = new KeyValue(index, value);
                        return;
                    }
                }
                for (int i = 0; i < structArray.Length; i++)
                {
                    if (structArray[i].Key == null)
                    {
                        structArray[i] = new KeyValue(index, value);
                        count++;
                        return;
                    }
                }
            }
        }

    }
}
