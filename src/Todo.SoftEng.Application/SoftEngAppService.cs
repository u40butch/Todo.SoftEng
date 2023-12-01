using System;
using System.Collections.Generic;
using System.Text;
using Todo.SoftEng.Localization;
using Volo.Abp.Application.Services;

namespace Todo.SoftEng;

/* Inherit your application services from this class.
 */
public abstract class SoftEngAppService : ApplicationService
{
    protected SoftEngAppService()
    {
        LocalizationResource = typeof(SoftEngResource);
    }
}
