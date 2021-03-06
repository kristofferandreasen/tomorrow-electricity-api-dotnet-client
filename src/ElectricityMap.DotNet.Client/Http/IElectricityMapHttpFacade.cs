﻿using System;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Http
{
    public interface IElectricityMapHttpFacade
    {
        Task<T> GetAsync<T>(Uri url);
    }
}
