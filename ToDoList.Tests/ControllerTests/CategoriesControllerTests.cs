using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoriesControllerTest
  {

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      CategoriesController controller = new CategoriesController();

      //Act
      IActionResult view = controller.Create("Walk the dog");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      CategoriesController controller = new CategoriesController();
      RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
