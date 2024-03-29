/*
 * Copyright © 2017 mik14a <mik14a@gmail.com>
 * This work is free. You can redistribute it and/or modify it under the
 * terms of the Do What The Fuck You Want To Public License, Version 2,
 * as published by Sam Hocevar. See the COPYING file for more details.
 */

using System;
using System.Reflection;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    class Program
    {
        static void Main(string[] args) {
            var program = new Program();
            program.Run(Assembly.GetEntryAssembly());
        }

        void Run(Assembly assembly) {
            Console.WriteLine($"Program: Running [ {assembly} ]");
            var testRunner = new TestRunner();
            testRunner.Run(assembly);
            var benchmarkRunner = new BenchmarkRunner();
            benchmarkRunner.Run(assembly);
        }
    }
}
