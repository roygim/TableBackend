using Microsoft.AspNetCore.Mvc;

namespace TableBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<TableObj>>> GetAll()
        {
            List<TableObj> data = await _tableService.GetAll();
            return Ok(data);
        }

        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            bool isDeleted = await _tableService.DeleteUser(id);
            return Ok(isDeleted);
        }

        [HttpPost("AddUser")]
        public async Task<ActionResult<TableObj>> AddUser([FromBody] TableObj tableObj)
        {
            TableObj newUser= await _tableService.AddUser(tableObj);
            return Ok(newUser);
        }

        //[HttpDelete("DeleteTask/{id}")]
        //public async Task<ActionResult<bool>> DeleteTask(int id)
        //{
        //    bool isDeleted = await _taskService.DeleteTask(id);
        //    return Ok(isDeleted);
        //}

        //[HttpDelete("DeleteTasks")]
        //public async Task<ActionResult<int>> DeleteTasks([FromBody] string ids)
        //{
        //    int deletedTasks = await _taskService.DeleteTasks(ids);
        //    return Ok(deletedTasks);
        //}
    }
}