using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data {
    public class UtcDemo : IDemo {
        public DateTime StartUpTime { get; init; }

        public UtcDemo() {
            StartUpTime = DateTime.UtcNow;
        }
    }
}