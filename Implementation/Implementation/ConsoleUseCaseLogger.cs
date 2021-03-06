﻿using Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Implementation
{
    public class ConsoleUseCaseLogger : IUseCaseLogger
    {
        public void Log(IUseCase useCase, object useCaseData)
        {
            Console.WriteLine($"{DateTime.Now} Running action {useCase.Name}");
        }
    }
}
