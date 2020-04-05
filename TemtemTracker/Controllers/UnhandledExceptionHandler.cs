﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TemtemTracker.Controllers
{
    class UnhandledExceptionHandler
    {

        public static void HandleUnhandledException(object source, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            new ErrorMessage("Unhandled exception: " + e.Message, null);
        }

        public static void HandleUnhandledThreadException(object sender, ThreadExceptionEventArgs e)
        {
            new ErrorMessage("Unhandled exception: " + e.Exception.Message, null);
        }
    }
}