using System;

//Logan Hardy 
//IS 413 
//Assignment 6
//24 Feb 2021

namespace MyOnlineBooks.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
