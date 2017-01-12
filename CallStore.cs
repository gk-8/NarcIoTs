//*********************************************************
//
//    Copyright (c) Microsoft. All rights reserved.
//    This code is licensed under the Microsoft Public License.
//    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
//    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
//    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
//    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telcodatagen
{
    class CallStore
    {
        public string[] CallNos;
        public string[] switchCountries = { "United States", "Colombia", "Spain", "Bolivia", "Mexico" };
        static string[] NumPrefix = { "001", "0057", "0034", "0591","0052" };

        public CallStore(int size)
        {
            Random coin = new Random();

            // CallNoStore
            CallNos = new String[size];

            // Start generating the n numbers and putting it into the store
            for (int i = 0; i < size; i++)
            {
                int prefixIdx = coin.Next(0, NumPrefix.Length);
                string prefix = NumPrefix[prefixIdx];
                CallNos[i] = prefix + String.Format("{0:00000}", i);
            }

            
        }
    }
}
