﻿using Application.DataTransfer;
using Application.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public interface IUpdateTaskAsync : ICommandAsync<TaskRequest>
    {
    }
}
