﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGeneratorException : Exception
    {
        public ExceptionType type;

        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDES, INVALID_USER_ID, INVALID_RIDETYPE
        }

        public InvoiceGeneratorException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }   }   
