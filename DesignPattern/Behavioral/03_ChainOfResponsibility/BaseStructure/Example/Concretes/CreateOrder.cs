﻿using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Model;
using DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Service;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._03_ChainOfResponsibility.BaseStructure.Example.Concretes
{
    public class CreateOrder : IHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            bool orderCreated = true;
            if (orderCreated)
            {
                if (Successor!=null)
                {
                    Console.WriteLine($"Order Created at {DateTime.Now} and send to {Successor.GetType().Name}");
                    return Successor.Execute(requestContext);
                }
                else
                {
                    return new ResponseContext()
                    {
                        IsSuccess = false,
                        Message=$"Order Created successfully at {DateTime.Now}"
                    };
                }
            }
            else
            {
                Console.WriteLine($"Order Created failed {DateTime.Now}");
                return new ResponseContext()
                {
                    IsSuccess = false,
                    Message="Order Failed to created"
                };
            }
        }
    }
}
