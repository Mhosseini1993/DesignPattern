using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Model
{
    public class RequestContext
    {
        public int UserId { get; set; }
        public Point Origin { get; set; }
        public Point Destination { get; set; }
    }
    public class ResponseContext
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    public class Point
    {
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
