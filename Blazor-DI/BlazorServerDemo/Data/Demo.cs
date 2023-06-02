using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data {
    public class Demo : IDemo {
        public DateTime StartUpTime { get; init; }

        public Demo() {
            StartUpTime = DateTime.Now;
        }
    }
}