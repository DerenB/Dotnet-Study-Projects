using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data {
    public class ProcessDemo {
        private readonly Demo _demo;
        public ProcessDemo(Demo demo) {
            _demo = demo;
        }

        public int GetDaysInMonth() {
            return _demo.StartUpTime.Month switch {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}