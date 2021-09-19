using FrameworkTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameworkTest2.Services
{
    public interface INumberCompositionService
    {
        NumberComposition CalculateNumberComposition(int number);
    }
}
