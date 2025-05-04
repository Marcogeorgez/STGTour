using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace GTour.Abstractions.JsInterop;

public interface IJsInteropPopper
{

    ValueTask<string> SetTourStepPopperByElement(ElementReference forElement, ElementReference gtourWrapper, string placement, string strategy);

    ValueTask<string> SetTourStepPopperBySelector(string forElementSelector, ElementReference gtourWrapper, string placement, string strategy);

    ValueTask<string> ResetTourStepPopper(ElementReference gtourWrapper, string placement, string strategy);
}
