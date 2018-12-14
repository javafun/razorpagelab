using Microsoft.AspNetCore.Mvc;
using System;
using tutorwebapp.Pages;
using Xunit;

namespace tutorwebapp.tests
{
    public class ContactUsTests
    {
        [Fact]
        public void WhenUserSubmitForm_ShouldRedirectToSuccessPage()
        {
            // Arrange
            var contactModel = new ContactModel();
            contactModel.Contact = new Models.Contact
            {
                Email = "test@test.com",
                Message = "aaaaa",
                Name = "vincent",
                Phone= "123213"
            };

            // Act
            IActionResult result = contactModel.OnPost();
            
            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<RedirectToPageResult>(result);
        }

        [Fact]
        public void WhenUserSubscribe_ShouldRedirectToSuccessPage()
        {
            // Arrange
            var contactModel = new ContactModel();
            contactModel.Contact = new Models.Contact
            {
                Email = "test@test.com",
                Message = "aaaaa",
                Name = "vincent",
                Phone = "123213"
            };

            // Act
            IActionResult result = contactModel.OnPostSubscribe("test@tset.com");

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<RedirectToPageResult>(result);
        }

        [Fact]
        public void WhenUserSubscribe_WithoutInvalidFormatEmail_ShouldReceiveError()
        {
            // Arrange
            var contactModel = new ContactModel();          

            // Act and Assert
            Assert.Throws<Exception>(()=>contactModel.OnPostSubscribe("testtset@com"));
        }

        [Fact]
        public void WhenUserSubscribe_WithoutEmptyEmail_ShouldReceiveError()
        {
            // Arrange
            var contactModel = new ContactModel();

            // Act and Assert
            Assert.Throws<Exception>(() => contactModel.OnPostSubscribe("testtset.com"));
        }
    }
}
