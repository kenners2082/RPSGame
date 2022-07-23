using RPSWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RPSWebAPI.Controllers
{
    [RoutePrefix("Api/Results")]
    public class ResultsController : ApiController
    {
        //RPSGameDBEntities objEntity = new RPSGameDBEntities();


        //    [HttpGet]
        //    [Route("AllScoreboards")]
        //    public IQueryable<Scoreboard> GetResults()
        //    {
        //        try
        //        {
        //            return objEntity.Scoreboards;
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }

        //    [HttpGet]
        //    [Route("GetScoreboardsById/{GameId}")]
        //    public IHttpActionResult GetResultsById([FromUri]int GameId)
        //    {
        //        //create a new Scoreboard class
        //        Scoreboard objRes = new Scoreboard();

        //        try
        //        {
        //            objRes = objEntity.Scoreboards.Find(GameId);
        //            if (objRes == null)
        //            {
        //                return NotFound();
        //            }

        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }

        //        return Ok(objRes);
        //    }

        //    [HttpPost]
        //    [Route("InsertScoreboards")]
        //    public IHttpActionResult PostResults(Scoreboard data)
        //    {

        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }
        //        try
        //        {
        //            objEntity.Scoreboards.Add(data);
        //            objEntity.SaveChanges();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }

        //        return Ok(data);
        //    }

        //    [HttpPut]
        //    [Route("UpdateScoreboards")]
        //    public IHttpActionResult PutResultsMaster(Scoreboard Results)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        try
        //        {
        //            Scoreboard objRes = new Scoreboard();
        //            objRes = objEntity.Scoreboards.Find(Results.GameId);
        //            if (objRes != null)
        //            {
        //                objRes.GameId = Results.GameId;
        //                objRes.Date = Results.Date;
        //                objRes.CompScore = Results.CompScore;
        //                objRes.PlayerScore = Results.PlayerScore;
        //                objRes.Result = Results.Result;
        //                objRes.NumOfRounds = Results.NumOfRounds;

        //            }
        //            int i = this.objEntity.SaveChanges();

        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        return Ok(Results);
        //    }
        //    [HttpDelete]
        //    [Route("DeleteScoreboards/{GameId}")]
        //    public IHttpActionResult DeleteResultsDelete([FromUri]int GameId)
        //    {
        //        //int ResId = Convert.ToInt32(id);  
        //        Scoreboard Results = objEntity.Scoreboards.Find(GameId);
        //        if (Results == null)
        //        {
        //            return NotFound();
        //        }

        //        objEntity.Scoreboards.Remove(Results);
        //        objEntity.SaveChanges();

        //        return Ok(Results);
        //    }
        //}
    }
}
