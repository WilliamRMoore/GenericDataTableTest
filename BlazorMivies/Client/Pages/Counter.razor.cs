﻿using BlazorMivies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorMivies.Client.Shared.MainLayout;
using MathNet.Numerics.Statistics;

namespace BlazorMivies.Client.Pages
{
    public partial class Counter
    {

        private int currentCount = 0;

        public void IncrementCount()
        {
            var array = new double[] { 1, 2, 3, 4, 5 };
            var max = array.Maximum();
            var min = array.Minimum();

            Console.WriteLine($"Max is {max} and min is {min}");

            currentCount++;
        }

    }
}
