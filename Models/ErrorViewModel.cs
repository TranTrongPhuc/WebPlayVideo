using System;

namespace WebASPNETCore.Models
{
    public class ErrorViewModel
    {
		//Nhanh Master code moi
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}