using System;

namespace GleamTech.ImageUltimateExamples.AspNetCoreCS.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
