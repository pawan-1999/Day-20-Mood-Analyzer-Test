﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
        }
        public string analyseMood()
        {
            if (this.message.Contains("sad"))
                return "SAD";
            else if (this.message.Contains("I"))
                return "SAD";
            else
                return "HAPPY";
        }
    }

}
