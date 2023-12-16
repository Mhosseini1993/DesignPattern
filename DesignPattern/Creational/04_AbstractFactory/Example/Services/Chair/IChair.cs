using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational._04_AbstractFactory.Example.Services.Chair
{
    public interface IChair
    {
        void HasLegs();
        void SitOn();
    }
}
