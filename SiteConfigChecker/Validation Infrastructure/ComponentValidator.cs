using SiteConfigChecker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteConfigChecker.Validation_Infrastructure
{
    public interface ComponentValidator
    {
        List<Result> PublishValidationResults();

        bool RunValidation();
    }
}
