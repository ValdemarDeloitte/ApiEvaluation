using ApiEvaluation.Models;
using ApiEvaluation.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiEvaluation.Controllers
{
    [Route("api/[users-inv]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly IEvaluationService _evaluationService;
        public userController(IEvaluationService evaluationService)
        {
            _evaluationService = evaluationService;
        }

        [HttpPost("addUser")]
        public ActionResult AddUser(UserItem newItem)
        {
            _evaluationService.AddUser(newItem);
            return Ok();
        }
        [HttpGet("getUsers")]
        public ActionResult GetUsers()
        {
            return Ok(_evaluationService.GetUsers());
        }
        [HttpPut("updateUser")]

        public ActionResult updateUser(UserItem itemToUpdate)
        {
            _evaluationService.updtaeUser(itemToUpdate);
            return Ok();
        }
        [HttpPut("GetUserById/{id}")]

        public IActionResult GetUser(int id)
        {
            _evaluationService.GetUser(id);
            return Ok();
        }

    }
    public class InventoryController : ControllerBase
    {
        private readonly IEvaluationInvService _evaluationInvService;
        public InventoryController(IEvaluationService evaluationInvService)
        {
            _evaluationInvService = (IEvaluationInvService?)evaluationInvService;
        }
        [HttpPost("addItem")]
        public ActionResult AddUser(UserItem newItem)
        {
            _evaluationInvService.AddItem(newItem);
            return Ok();
        }
        [HttpGet("getAllItems")]
        public ActionResult GetItems()
        {
            return Ok(_evaluationInvService.GetItems());
        }

    }

}
