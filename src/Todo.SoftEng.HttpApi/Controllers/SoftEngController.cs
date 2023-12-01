using Todo.SoftEng.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Todo.SoftEng.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SoftEngController : AbpControllerBase
{
    protected SoftEngController()
    {
        LocalizationResource = typeof(SoftEngResource);
    }
}
