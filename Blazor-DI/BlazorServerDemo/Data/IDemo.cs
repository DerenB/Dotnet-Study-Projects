using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data {
    public interface IDemo {
        DateTime StartUpTime { get; init; }
    }
}