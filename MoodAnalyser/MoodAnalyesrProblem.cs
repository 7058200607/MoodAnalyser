using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class AMoodAnalyser 
    {
        private string message;

        public AMoodAnalyser(string message)  
        {
            this.message = message;
        }
        public string AnalyseMood() 
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "Happy";
                }
            }
            catch 
            {
                return "Happy";
            }
        }

        
    }
}
