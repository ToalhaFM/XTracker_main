using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ToDoController : ControllerBase
{
	private readonly AppToDoDbContext _DbToDOContext;
	public ToDoController(AppToDoDbContext ToDoContext)
	{
		_DbToDOContext = ToDoContext;
	}

}