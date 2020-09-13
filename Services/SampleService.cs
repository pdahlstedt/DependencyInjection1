using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection1.Services
{
    public class SampleService : ISampleService
    {
        public string GetCurrentDate() => DateTime.Now.ToLongDateString();
    }
}
