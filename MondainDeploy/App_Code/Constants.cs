﻿using System.Collections.Generic;
using System.Linq;

namespace MondainDeploy
{
    internal struct Constants
    {
        public static readonly List<int> WordLengths = Enumerable.Range(2, 14).ToList();
        public static readonly int WordLengthMinDefault = 7;
        public static readonly int WordLengthMaxDefault = 8;
        public static readonly int DefaultQuizLength = 10;
        public static readonly int ProbabilityMinDefault = 0;
        public static readonly int ProbabilityMaxDefault = 99999;

    }
}
