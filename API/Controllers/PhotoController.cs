using Application.Photos;

namespace API.Controllers;

public sealed class PhotoController : ControllerTemplate
{
    [HttpPost]
    public async Task<IActionResult> Add([FromForm] Add.Command command) =>
        HandleResult(await Mediator.Send(command));

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id) =>
        HandleResult(await Mediator.Send(new Delete.Command{Id = id}));

    [HttpPost("{id}/setMain")]
    public async Task<IActionResult> SetMain(string id) =>
        HandleResult(await Mediator.Send(new SetMain.Command{Id = id}));
}
