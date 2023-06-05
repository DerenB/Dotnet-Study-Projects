using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data {
    public class DemoWithData {
        private readonly int _numberToRemember;
        public DemoWithData(int numberToRemember) {
            _numberToRemember = numberToRemember;
        }
    }
}