using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Controllers;
using Studio_Chen.Entities;

namespace StudioControllerTest
{
    public class TeacherControllerTest
    {
        private readonly TeacherController _teacherController;
        public TeacherControllerTest()
        {
            _teacherController = new TeacherController();
        }
        [Fact]
        public void GetAll_ReturnsOk()
        {
            //AAA
            //Arrange
            //Act
            var result = _teacherController.Get();
            //Assert
            Assert.IsType<List<Teacher>>(result);
        }
        [Fact]
        public void GetAll_ReturnsCount()
        {
            //AAA
            //Arrange
            //Act
            var result = _teacherController.Get();
            //Assert
            Assert.Equal(2, result.Count());
        }
        [Fact]
        public void Get_ReturnsOk()
        {
            //AAA
            //Arrange
            string id = "1";
            //Act
            var result = _teacherController.Get(id);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Get_NotFound()
        {
            //AAA
            //Arrange
            string id = "100";
            //Act
            var result = _teacherController.Get(id);
            //Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}