using ReactiveUI;

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ReactiveDemo
{
    public class ReactiveViewModelBase : ReactiveObject
    {
        private static readonly Dictionary<string, int> _vmInstancesCount = new Dictionary<string, int>();

        public ReactiveViewModelBase()
        {
            var vmTypeName = GetType().Name;
            var vmCount = _vmInstancesCount.ContainsKey(vmTypeName) ? _vmInstancesCount[vmTypeName] : 0;
            vmCount++;
            _vmInstancesCount[vmTypeName] = vmCount;
            Console.WriteLine($"ViewModel::{vmTypeName}::++::{vmCount}");
        }

        ~ReactiveViewModelBase()
        {
            var vmTypeName = GetType().Name;
            var vmCount = _vmInstancesCount[vmTypeName];
            vmCount--;
            _vmInstancesCount[vmTypeName] = vmCount;
            Console.WriteLine($"ViewModel::{vmTypeName}::--::{vmCount}");
        }
    }
}
