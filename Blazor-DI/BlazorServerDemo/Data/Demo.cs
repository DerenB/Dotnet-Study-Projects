using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data {
    public class Demo {
        public DateTime StartUpTime { get; init; }

        public Demo() {
            StartUpTime = DateTime.Now;
        }
    }
}