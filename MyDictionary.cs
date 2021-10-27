using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class MyDictionary<key,value>
    {
        key[] items_key;
        value[] items_value;
        //constructor
        public MyDictionary()
        {
            items_key = new key[0];
            items_value = new value[0];
        }
        
        public void Add(key item1, value item2)
        {
            key[] tempArrayKeys = items_key;
            value[] tempArrayValues = items_value;

            items_key = new key[items_key.Length + 1];
            items_value = new value[items_value.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                items_key[i]= tempArrayKeys[i];
            }
            for (int j = 0; j < tempArrayValues.Length; j++)
            {
                items_value[j] = tempArrayValues[j];
            }

            items_key[items_key.Length - 1] = item1;
            items_value[items_value.Length - 1] = item2;

        }
        public key[] fonk1
        {
            get { return items_key; }

        }
        public value[] fonk2
        {
            get { return items_value; }

        }
    }
}
