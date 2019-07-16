using SiteConfigChecker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteConfigChecker.Validation_Infrastructure
{
    public class ValidationResult
    {
        public Result Result { get; set; }

        List<KeyValuePair<string, string>> AdditionalInformation;

        public ValidationResult(Result result, List<KeyValuePair<string, string>> additionalInfo)
        {
            Result = Result;
            AdditionalInformation = additionalInfo;
        }
    }
}
