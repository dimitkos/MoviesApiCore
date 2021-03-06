﻿using Microsoft.AspNetCore.Mvc;
using MoviesApi.DTOs;
using MoviesApi.Helpers;
using System.Collections.Generic;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = "getRoot")]
        [HttpHeaderIsPresent("x-version", "1")]
        public ActionResult<IEnumerable<Link>> Get()
        {
            List<Link> links = new List<Link>();

            links.Add(new Link(href: Url.Link("getRoot", new { }), rel: "self", method: "GET"));
            links.Add(new Link(href: Url.Link("createUser", new { }), rel: "create-user", method: "POST"));
            links.Add(new Link(href: Url.Link("Login", new { }), rel: "login", method: "POST"));
            links.Add(new Link(href: Url.Link("getGenres", new { }), rel: "get-genres", method: "GET"));
            links.Add(new Link(href: Url.Link("getPeople", new { }), rel: "get-people", method: "GET"));

            return links;
        }
    }
}
