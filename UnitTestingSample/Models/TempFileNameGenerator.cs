using System;
namespace UnitTestingSample.Models
{
    public class TempFileNameGenerator
    {
        public TempFileNameGenerator()
        {
        }

        public string Generate()
        {
            return $"{DateTime.Now:yyyy-MM-dd_HHmmss}_{Guid.NewGuid().ToString("N").Substring(0, 7)}";    
        }
    }
}
