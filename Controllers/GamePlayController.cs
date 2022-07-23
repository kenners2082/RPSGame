using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using RPSWebAPI.Models;

namespace RPSWebAPI.Controllers
{
    [RoutePrefix("Api/GamePlay")]
    public class GamePlayController : ApiController
    {
        GameService playGame = new GameService();
        Entities objEntity = new Entities();


        // 
        // GET: /HelloWorld/
        [HttpGet]
        [Route("PlayGame")]
        public IHttpActionResult PlayGame(string userResponse)
        {
            return Ok(playGame.PlayGame(userResponse));
        }

        // 
        // POST: /HelloWorld/Welcome/ 
        [HttpPost]
        [Route("GameResult")]
        public IHttpActionResult PostGameResult(GameResult data)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                objEntity.GameResults.Add(data);
                objEntity.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

            return Ok(data);
        }
    }
}