﻿namespace CafeManagement.Application.Contracts.Dtos.Generics
{
    public class Generic<T>
    {
        public bool IsSuccess { get; set; }
        public string Messeage { get; set; }
        public T Data { get; set; }
    }
}
